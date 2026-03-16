using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Quartz;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Application.Features.Payments.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Notifications;
using NET_CarRentalSystem.Application.Models.Notifications;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Infrastructure.Configurations;

namespace NET_CarRentalSystem.Infrastructure.Services.Scheduling.Jobs;

[DisallowConcurrentExecution]
public class DepositRefundJob(
    ILogger<DepositRefundJob> logger,
    IServiceScopeFactory serviceScopeFactory,
    IOptions<DepositRefundJobConfig> configOptions) : IJob
{
    private readonly DepositRefundJobConfig _config = configOptions.Value;

    public async Task Execute(IJobExecutionContext context)
    {
        logger.LogInformation(
            "[DepositRefundJob] Starting deposit refund check at {Time}. AdminOverrideHours={AdminOverrideHours}",
            DateTime.UtcNow, _config.AdminOverrideHours);

        try
        {
            using var scope = serviceScopeFactory.CreateScope();
            var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();
            var publishEndpoint = scope.ServiceProvider.GetRequiredService<IPublishEndpoint>();
            var notificationHub = scope.ServiceProvider.GetRequiredService<INotificationHub>();

            var now = DateTime.UtcNow;
            
            // Phase 1: Check Pending deposit refunds that have reached their scheduled date
            await ProcessPendingRefundsAsync(unitOfWork, publishEndpoint, notificationHub, now, context.CancellationToken);
            
            // Phase 2: Auto-approve ReadyToProcess refunds that have passed the 24h admin override window
            await ProcessReadyToProcessRefundsAsync(unitOfWork, now, context.CancellationToken);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "[DepositRefundJob] Fatal error during deposit refund check");
            throw;
        }
    }

    /// <summary>
    /// Phase 1: Find Pending deposit refunds where ScheduledAt <= now.
    /// - If booking has unresolved violations → Freeze (OnHold + Disputed booking)
    /// - If no violations → Move to ReadyToProcess
    /// </summary>
    private async Task ProcessPendingRefundsAsync(
        IUnitOfWork unitOfWork,
        IPublishEndpoint publishEndpoint,
        INotificationHub notificationHub,
        DateTime now,
        CancellationToken ct)
    {
        var pendingRefunds = (await unitOfWork.GetWriteRepository<RefundRequest>()
            .GetAsync(
                filter: r => r.IsDepositRefund
                             && r.Status == RefundStatus.Pending
                             && r.ScheduledAt.HasValue
                             && r.ScheduledAt.Value <= now,
                sortBy: "ScheduledAt",
                sortDirection: "asc",
                cancellationToken: ct))
            .Take(_config.BatchSize)
            .ToList();

        logger.LogInformation(
            "[DepositRefundJob] Phase 1: Found {Count} pending deposit refunds due for processing",
            pendingRefunds.Count);

        foreach (var refund in pendingRefunds)
        {
            try
            {
                // Check for unresolved violations on this booking
                var hasUnresolvedViolations = await unitOfWork.GetWriteRepository<BookingViolation>()
                    .ExistsAsync(
                        v => v.BookingId == refund.BookingId
                             && v.Status != ViolationStatus.Resolved
                             && v.Status != ViolationStatus.Paid,
                        ct);

                if (hasUnresolvedViolations)
                {
                    await FreezeDepositRefundAsync(unitOfWork, publishEndpoint, notificationHub, refund, ct);
                }
                else
                {
                    await MoveToReadyToProcessAsync(unitOfWork, refund, now, ct);
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex,
                    "[DepositRefundJob] Error processing pending refund {RefundId} for booking {BookingId}",
                    refund.Id, refund.BookingId);
            }
        }
    }

    /// <summary>
    /// Phase 2: Find ReadyToProcess deposit refunds where the 24h admin override window has passed.
    /// Auto-approve them so the existing RefundProcessingJob picks them up.
    /// </summary>
    private async Task ProcessReadyToProcessRefundsAsync(
        IUnitOfWork unitOfWork,
        DateTime now,
        CancellationToken ct)
    {
        var readyRefunds = (await unitOfWork.GetWriteRepository<RefundRequest>()
            .GetAsync(
                filter: r => r.IsDepositRefund
                             && r.Status == RefundStatus.ReadyToProcess
                             && r.ReadyToProcessAt.HasValue
                             && r.ReadyToProcessAt.Value.AddHours(_config.AdminOverrideHours) <= now,
                sortBy: "ReadyToProcessAt",
                sortDirection: "asc",
                cancellationToken: ct))
            .Take(_config.BatchSize)
            .ToList();

        logger.LogInformation(
            "[DepositRefundJob] Phase 2: Found {Count} deposit refunds ready to auto-approve (24h window passed)",
            readyRefunds.Count);

        foreach (var refund in readyRefunds)
        {
            try
            {
                // Re-check for violations (could have appeared during 24h window)
                var hasUnresolvedViolations = await unitOfWork.GetWriteRepository<BookingViolation>()
                    .ExistsAsync(
                        v => v.BookingId == refund.BookingId
                             && v.Status != ViolationStatus.Resolved
                             && v.Status != ViolationStatus.Paid,
                        ct);

                if (hasUnresolvedViolations)
                {
                    logger.LogWarning(
                        "[DepositRefundJob] Violations detected during 24h window for RefundId={RefundId}. Moving to OnHold.",
                        refund.Id);
                    
                    refund.Status = RefundStatus.OnHold;
                    refund.AdminNotes = $"Vi phạm được phát hiện trong thời gian chờ 24h. Chuyển sang OnHold lúc {now:dd/MM/yyyy HH:mm} UTC.";
                    unitOfWork.GetWriteRepository<RefundRequest>().Update(refund);
                    await unitOfWork.SaveChangesAsync(ct);
                    continue;
                }

                // Auto-approve: admin didn't flag within 24h and no violations
                refund.Status = RefundStatus.Approved;
                refund.ApprovedAt = now;
                refund.AdminNotes = $"Tự động duyệt hoàn cọc sau {_config.AdminOverrideHours}h không có can thiệp từ Admin.";
                unitOfWork.GetWriteRepository<RefundRequest>().Update(refund);
                await unitOfWork.SaveChangesAsync(ct);

                logger.LogInformation(
                    "[DepositRefundJob] ✅ Auto-approved deposit refund {RefundId} for booking {BookingId}, Amount={Amount}VND",
                    refund.Id, refund.BookingId, refund.Amount);
            }
            catch (Exception ex)
            {
                logger.LogError(ex,
                    "[DepositRefundJob] Error auto-approving refund {RefundId}",
                    refund.Id);
            }
        }
    }

    /// <summary>
    /// Freeze a deposit refund due to unresolved violations.
    /// Sets RefundRequest to OnHold, Booking to Disputed, and sends notifications.
    /// </summary>
    private async Task FreezeDepositRefundAsync(
        IUnitOfWork unitOfWork,
        IPublishEndpoint publishEndpoint,
        INotificationHub notificationHub,
        RefundRequest refund,
        CancellationToken ct)
    {
        logger.LogWarning(
            "[DepositRefundJob] ⚠️ Freezing deposit refund {RefundId} for booking {BookingId} due to unresolved violations",
            refund.Id, refund.BookingId);

        // Update refund status to OnHold
        refund.Status = RefundStatus.OnHold;
        refund.AdminNotes = $"Tạm giữ tiền cọc do có vi phạm chưa giải quyết. Phát hiện lúc {DateTime.UtcNow:dd/MM/yyyy HH:mm} UTC.";
        unitOfWork.GetWriteRepository<RefundRequest>().Update(refund);

        // Update booking status to Disputed
        var booking = await unitOfWork.GetWriteRepository<Booking>()
            .GetByIdAsync(refund.BookingId, ct);

        if (booking != null && booking.Status == BookingStatus.Completed)
        {
            booking.Status = BookingStatus.Disputed;
            unitOfWork.GetWriteRepository<Booking>().Update(booking);

            // Publish booking updated event to sync ReadDB
            var bookingUpdatedEvent = booking.ToUpdatedEvent<Booking, BookingUpdatedEvent, Guid>(_ => new BookingUpdatedEvent
            {
                Status = BookingStatus.Disputed,
                Id = default,
                CreatedAt = default,
                CreatedBy = null,
                UpdatedAt = default,
                UpdatedBy = null
            });
            await publishEndpoint.Publish(bookingUpdatedEvent, ct);
        }

        await unitOfWork.SaveChangesAsync(ct);

        // Send notification to admin
        var notification = new PaymentSuccessNotification
        {
            BookingId = refund.BookingId,
            TransactionType = TransactionType.DepositRefund,
            Amount = refund.Amount,
            CustomerName = "Khách hàng",
            VehicleName = "",
            NotificationType = "DepositRefundFrozen",
            Message = $"⚠️ Hoàn cọc bị tạm giữ cho đơn {refund.BookingId.ToString()[..8]} do có vi phạm chưa giải quyết. Số tiền: {refund.Amount:N0} VND"
        };

        await notificationHub.SendToRoleAsync("Admin", "ReceivePaymentNotification", notification, ct);
        await notificationHub.SendToRoleAsync("Staff", "ReceivePaymentNotification", notification, ct);

        logger.LogInformation(
            "[DepositRefundJob] ✅ Frozen deposit refund {RefundId}, booking {BookingId} set to Disputed",
            refund.Id, refund.BookingId);
    }

    /// <summary>
    /// Move a pending deposit refund to ReadyToProcess status (starts the 24h admin override window).
    /// </summary>
    private async Task MoveToReadyToProcessAsync(
        IUnitOfWork unitOfWork,
        RefundRequest refund,
        DateTime now,
        CancellationToken ct)
    {
        refund.Status = RefundStatus.ReadyToProcess;
        refund.ReadyToProcessAt = now;
        refund.AdminNotes = $"Sẵn sàng hoàn cọc. Admin có {_config.AdminOverrideHours}h để chặn (Hold) nếu cần. " +
                            $"Tự động hoàn sau: {now.AddHours(_config.AdminOverrideHours):dd/MM/yyyy HH:mm} UTC.";
        unitOfWork.GetWriteRepository<RefundRequest>().Update(refund);
        await unitOfWork.SaveChangesAsync(ct);

        logger.LogInformation(
            "[DepositRefundJob] ✅ Moved refund {RefundId} to ReadyToProcess. Auto-approve after {Hours}h at {AutoApproveAt}",
            refund.Id, _config.AdminOverrideHours, now.AddHours(_config.AdminOverrideHours));
    }
}
