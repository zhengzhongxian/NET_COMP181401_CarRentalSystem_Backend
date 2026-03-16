using MassTransit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Quartz;
using System.Text.Json;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Application.Models.DTOs.BookingViolationDTOs.Create;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Infrastructure.Configurations;
using NET_CarRentalSystem.Shared.Utilities;
using NET_CarRentalSystem.Application.Common.Extensions;

namespace NET_CarRentalSystem.Infrastructure.Services.Scheduling.Jobs;

[DisallowConcurrentExecution]
public class OverdueBookingJob(
    ILogger<OverdueBookingJob> logger,
    IServiceScopeFactory serviceScopeFactory,
    IOptions<OverdueBookingJobConfig> configOptions) : IJob
{
    private readonly OverdueBookingJobConfig _config = configOptions.Value;

    public async Task Execute(IJobExecutionContext context)
    {
        try
        {
            logger.LogInformation(
                "[OverdueBookingJob] Starting overdue booking check at {Time}. MinOverdueMinutes={MinOverdueMinutes}, CriticalHours={CriticalHours}",
                DateTime.UtcNow, _config.MinOverdueMinutes, _config.CriticalHours);

            using var scope = serviceScopeFactory.CreateScope();
            var serviceProvider = scope.ServiceProvider;

            var unitOfWork = serviceProvider.GetRequiredService<IUnitOfWork>();
            var publishEndpoint = serviceProvider.GetRequiredService<IPublishEndpoint>();

            var now = DateTime.UtcNow;
            var minOverdueTime = now.AddMinutes(-_config.MinOverdueMinutes);
            
            var overdueBookings = await unitOfWork.GetReadRepository<BookingReadFlat>()
                .GetQueryable()
                .Where(b => b.Status == BookingStatus.InProgress &&
                            b.EndDate < minOverdueTime)
                .ToListAsync(context.CancellationToken);

            logger.LogInformation(
                "[OverdueBookingJob] Found {Count} overdue bookings (EndDate < {MinOverdueTime})",
                overdueBookings.Count, minOverdueTime);

            if (overdueBookings.Count == 0)
            {
                logger.LogInformation("[OverdueBookingJob] No overdue bookings found");
                return;
            }
            
            var adminEmails = await GetAdminEmailsAsync(unitOfWork, context.CancellationToken);
            var adminEmailString = string.Join(";", adminEmails);

            logger.LogInformation("[OverdueBookingJob] Found {Count} admin emails for notification", adminEmails.Count);

            var processedCount = 0;

            foreach (var readBooking in overdueBookings)
            {
                try
                {
                    var overdueMinutes = (int)(now - readBooking.EndDate).TotalMinutes;
                    var severity = GetSeverity(overdueMinutes);
                    var notifyAdmin = overdueMinutes >= _config.CriticalHours * 60;
                    
                    var existingViolation = await unitOfWork.GetWriteRepository<BookingViolation>()
                        .GetFirstOrDefaultAsync(
                            v => v.BookingId == readBooking.BookingId && 
                                 v.ViolationType == ViolationType.LateReturn,
                            context.CancellationToken);

                    if (existingViolation != null)
                    {
                        logger.LogInformation(
                            "[OverdueBookingJob] Skipping BookingId={BookingId} - LateReturn violation already exists",
                            readBooking.BookingId);
                        
                        if (notifyAdmin)
                        {
                            await PublishOverdueEventAsync(
                                publishEndpoint, readBooking, overdueMinutes, severity, 
                                true, adminEmailString, context.CancellationToken);
                        }
                        continue;
                    }
                    
                    var booking = await unitOfWork.GetWriteRepository<Booking>()
                        .GetFirstOrDefaultAsync(b => b.Id == readBooking.BookingId, context.CancellationToken);

                    if (booking == null)
                    {
                        logger.LogWarning("[OverdueBookingJob] Booking {BookingId} not found in WriteDB", readBooking.BookingId);
                        continue;
                    }
                    
                    var customer = await unitOfWork.GetWriteRepository<Customer>()
                        .GetFirstOrDefaultAsync(c => c.CustomerId == booking.CustomerId, context.CancellationToken);
                    
                    var lateDays = (now - booking.EndDate).TotalDays;
                    var latePenalty = booking.TotalPrice * booking.LatePenaltyRatio * (decimal)Math.Ceiling(lateDays);
                    
                    var violation = new BookingViolation
                    {
                        BookingId = booking.Id,
                        ViolationType = ViolationType.LateReturn,
                        Status = ViolationStatus.Pending,
                        Amount = latePenalty,
                        Description = $"Trả xe muộn {Math.Ceiling(lateDays)} ngày (Tự động phát hiện)",
                        Details = $"Ngày hẹn trả: {booking.EndDate:dd/MM/yyyy HH:mm}, " +
                                 $"Hiện tại: {now:dd/MM/yyyy HH:mm}. " +
                                 $"Phạt {booking.LatePenaltyRatio * 100}% giá thuê mỗi ngày."
                    };

                    await unitOfWork.GetWriteRepository<BookingViolation>().AddAsync(violation, context.CancellationToken);
                    
                    if (customer != null)
                    {
                        customer.HasActiveViolation = true;
                        unitOfWork.GetWriteRepository<Customer>().Update(customer);
                    }

                    await unitOfWork.SaveChangesAsync(context.CancellationToken);

                    logger.LogInformation(
                        "[OverdueBookingJob] ✅ Created LateReturn violation for BookingId={BookingId}, Amount={Amount}",
                        booking.Id, latePenalty);
                    
                    var violationDto = new CreateJsonBookingViolationDto
                    {
                        Id = violation.Id,
                        ViolationType = violation.ViolationType.ToString(),
                        Amount = violation.Amount,
                        Description = violation.Description,
                        Details = violation.Details,
                        Status = violation.Status.ToString()
                    };

                    var bookingUpdatedEvent = booking.ToUpdatedEvent<Booking, BookingUpdatedEvent, Guid>(_ => new BookingUpdatedEvent
                    {
                        Id = booking.Id,
                        Status = booking.Status,
                        BookingViolationsJson = new List<CreateJsonBookingViolationDto> { violationDto }.ToJson(),
                        CreatedAt = default,
                        CreatedBy = null,
                        UpdatedAt = default,
                        UpdatedBy = null
                    });

                    await publishEndpoint.Publish(bookingUpdatedEvent, context.CancellationToken);
                    
                    var user = customer?.UserId.HasValue == true
                        ? await unitOfWork.GetReadRepository<User>()
                            .GetFirstOrDefaultAsync(u => u.Id == customer.UserId.Value, cancellationToken: context.CancellationToken)
                        : null;

                    var customerName = customer != null ? $"{customer.FirstName} {customer.LastName}" : "Khách hàng";

                    var violationEvent = new BookingReturnViolationEvent
                    {
                        BookingId = booking.Id,
                        CustomerId = booking.CustomerId,
                        CustomerName = customerName,
                        CustomerEmail = user?.Email,
                        ViolationDetailsHtml = $"<div><strong>1. ⏰ Trả xe muộn</strong><div>{violation.Description}</div><div>{violation.Details}</div><div>Số tiền: {violation.Amount:N0} VND</div></div>",
                        ViolationCount = 1,
                        TotalAmount = violation.Amount,
                        CreatedAt = DateTime.UtcNow
                    };

                    await publishEndpoint.Publish(violationEvent, context.CancellationToken);
                    
                    await PublishOverdueEventAsync(
                        publishEndpoint, readBooking, overdueMinutes, severity,
                        notifyAdmin, adminEmailString, context.CancellationToken);

                    await unitOfWork.SaveChangesAsync(context.CancellationToken);
                    processedCount++;

                    logger.LogInformation(
                        "[OverdueBookingJob] Published events for BookingId={BookingId}, OverdueMinutes={OverdueMinutes}, Severity={Severity}",
                        readBooking.BookingId, overdueMinutes, severity);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex,
                        "[OverdueBookingJob] Failed to process BookingId={BookingId}",
                        readBooking.BookingId);
                }
            }

            logger.LogInformation(
                "[OverdueBookingJob] Completed at {Time}. Processed: {ProcessedCount}/{TotalCount} bookings",
                DateTime.UtcNow, processedCount, overdueBookings.Count);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "[OverdueBookingJob] Fatal error during overdue booking check");
            throw;
        }
    }

    private async Task PublishOverdueEventAsync(
        IPublishEndpoint publishEndpoint,
        BookingReadFlat booking,
        int overdueMinutes,
        string severity,
        bool notifyAdmin,
        string? adminEmailString,
        CancellationToken ct)
    {
        var vehicleInfo = ParseVehicleInfo(booking.Metadata);

        var overdueEvent = new OverdueBookingDetectedEvent
        {
            BookingId = booking.BookingId,
            CustomerId = booking.CustomerId,
            CustomerName = booking.CustomerName ?? "N/A",
            CustomerEmail = booking.CustomerEmail,
            CustomerPhone = booking.CustomerPhone,
            NumberPlate = booking.NumberPlate ?? "N/A",
            VehicleInfo = vehicleInfo,
            PickupLocationName = booking.PickupLocationName,
            StartDate = booking.StartDate,
            EndDate = booking.EndDate,
            OverdueMinutes = overdueMinutes,
            Severity = severity,
            NotifyAdmin = notifyAdmin,
            AdminEmail = notifyAdmin ? adminEmailString : null,
            DetectedAt = DateTime.UtcNow
        };

        await publishEndpoint.Publish(overdueEvent, ct);
    }

    private async Task<List<string>> GetAdminEmailsAsync(IUnitOfWork unitOfWork, CancellationToken ct)
    {
        try
        {
            // ReadDB không có quan hệ, phải query riêng từng bảng
            var adminRole = await unitOfWork.GetReadRepository<Role>()
                .GetFirstOrDefaultAsync(r => r.Name == RoleConstants.Admin, cancellationToken: ct);

            if (adminRole == null)
            {
                logger.LogWarning("[OverdueBookingJob] Admin role not found");
                return [];
            }

            var adminUserRoles = await unitOfWork.GetReadRepository<UserRole>()
                .GetAsync(filter: ur => ur.RoleId == adminRole.Id, cancellationToken: ct);

            var adminUserIds = adminUserRoles.Select(ur => ur.UserId).Distinct().ToList();

            if (adminUserIds.Count == 0)
                return [];

            var adminUsers = await unitOfWork.GetReadRepository<User>()
                .GetAsync(filter: u => adminUserIds.Contains(u.Id) && u.Status == UserStatus.Active, cancellationToken: ct);

            return adminUsers.Where(u => !string.IsNullOrEmpty(u.Email)).Select(u => u.Email!).ToList();
        }
        catch (Exception ex)
        {
            logger.LogWarning(ex, "[OverdueBookingJob] Failed to get admin emails from DB");
            return [];
        }
    }

    private string GetSeverity(int overdueMinutes)
    {
        return overdueMinutes switch
        {
            >= 1440 => "Critical",  // >= 24 giờ
            >= 360 => "Urgent",     // >= 6 giờ
            _ => "Warning"          // < 6 giờ
        };
    }

    private string ParseVehicleInfo(string? metadata)
    {
        if (string.IsNullOrEmpty(metadata))
            return "N/A";

        try
        {
            using var doc = JsonDocument.Parse(metadata);
            var root = doc.RootElement;

            var manufacturer = root.TryGetProperty("Manufacturer", out var manuProp)
                ? manuProp.GetString() ?? "N/A" : "N/A";
            var model = root.TryGetProperty("Model", out var modelProp)
                ? modelProp.GetString() ?? "N/A" : "N/A";
            var color = root.TryGetProperty("Color", out var colorProp)
                ? colorProp.GetString() ?? "N/A" : "N/A";

            return $"{manufacturer} {model} ({color})";
        }
        catch
        {
            return "N/A";
        }
    }
}
