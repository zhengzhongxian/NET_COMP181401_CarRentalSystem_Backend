using MassTransit;
using MediatR;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Application.Features.Payments.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using NET_CarRentalSystem.Application.Models.DTOs.TransactionDTOs;
using NET_CarRentalSystem.Application.Models.Payments.PayOs;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.CoreHelpers;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Bookings.Commands.CreateBookingCommand;

public class CreateBookingCommand : ICommand<(bool, string, PaymentTransactionDto?)>
{
    public required Guid VehicleId { get; init; }
    
    public required Guid PickupLocationId { get; init; }
    
    public required DateTime StartDate { get; init; }
    
    public required DateTime EndDate { get; init; }
    
    public required PaymentMethod PaymentMethod { get; init; }
    
    public string? Note { get; init; }
    
    public List<Guid>? InsurancePackageIds { get; init; }
    
    public required bool AcceptTerms { get; init; }
    
    public string? AcceptedTermsVersion { get; init; }
}

public class CreateBookingCommandHandler(
    IUnitOfWork unitOfWork,
    ICurrentUserService currentUserService,
    IPayOsService payOsService,
    IPublishEndpoint publishEndpoint,
    ICacheService cacheService,
    ILogger<CreateBookingCommandHandler> logger) : IRequestHandler<CreateBookingCommand, (bool, string, PaymentTransactionDto?)>
{
    private static readonly TimeSpan CustomerLockTimeout = TimeSpan.FromSeconds(60);
    
    public async Task<(bool, string, PaymentTransactionDto?)> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
    {
        var userId = currentUserService.GetUserId();
        
        var include = new IncludeBuilder<User>().Include(u => u.Customer);
        var builder = include.Build();
        var user = await unitOfWork.GetReadRepository<User>()
            .GetFirstAsync(c => c.Id == userId, includeProperties: builder, cancellationToken: cancellationToken);
        
        if (user.Customer == null)
        {
            return (false, BookingMessage.Create.CustomerNotFound, null);
        }
        
        var customerId = user.Customer.CustomerId;
        
        var lockKey = CacheKeyHelper.GetCustomerPaymentLockKey(customerId);
        var lockValue = Guid.NewGuid().ToString();
        var lockAcquired = await cacheService.AcquireLockAsync(lockKey, lockValue, CustomerLockTimeout, cancellationToken);
        
        if (!lockAcquired)
        {
            logger.LogWarning("[CreateBooking] Customer {CustomerId} has another operation in progress. Please wait.", customerId);
            return (false, BookingMessage.Create.PaymentBeingProcessed, null);
        }
        
        try
        {
            return await CreateBookingInternalAsync(request, user, cancellationToken);
        }
        finally
        {
            await cacheService.ReleaseLockAsync(lockKey, lockValue, cancellationToken);
        }
    }
    
    private async Task<(bool, string, PaymentTransactionDto?)> CreateBookingInternalAsync(
        CreateBookingCommand request, 
        User user, 
        CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var settings = await unitOfWork.GetReadRepository<SystemSetting>().GetAsync(cancellationToken: ct);
            var maxCancellations = settings.GetInt(SystemSettingConstants.CancellationSettings.MaxCancellationsPerMonth, 3);
            
            var cancellationCount = await GetCancellationCountAsync(user.Customer!.CustomerId, ct);
            if (cancellationCount >= maxCancellations)
            {
                return (false, BookingMessage.CreateWithCancellationLimit.MaxCancellationsReached, null);
            }
            
            var customer = await unitOfWork.GetWriteRepository<Customer>()
                .GetByIdAsync(user.Customer.CustomerId, ct);
            
            if (customer == null)
            {
                return (false, BookingMessage.Create.CustomerNotExists, null);
            }
            
            await CheckAndProcessPendingTransactionsAsync(customer, user, ct);
            
            if (customer.IsRenting)
            {
                return (false, BookingMessage.Create.AlreadyHasActiveBooking, null);
            }
            
            if (!request.AcceptTerms)
            {
                return (false, BookingMessage.Create.MustAcceptTerms, null);
            }
            
            var vehicleRead = await unitOfWork.GetReadRepository<VehicleReadFlat>().GetByIdAsync(request.VehicleId, ct);
            if (vehicleRead == null) 
                return (false, BookingMessage.Create.VehicleNotFound, null);
            
            var pickupLocation = await unitOfWork.GetReadRepository<Location>()
                .GetByIdAsync(request.PickupLocationId, ct);
            
            if (pickupLocation == null)
                return (false, BookingMessage.Create.InvalidLocation, null);
            
            var availableModels = await unitOfWork.GetWriteRepository<VehicleModel>()
                .GetAsync(
                    filter: vm => vm.VehicleId == request.VehicleId 
                               && vm.LocationId == request.PickupLocationId 
                               && vm.Status == VehicleStatus.Available,
                    sortBy: nameof(VehicleModel.LastAvailableAt),
                    sortDirection: "asc",
                    cancellationToken: ct
                );
            
            if (availableModels.Count == 0)
                return (false, BookingMessage.Create.NoVehicleAtLocation, null);
            
            var vehicleModel = availableModels.First();
            
            var duration = request.EndDate - request.StartDate;
            var hours = duration.TotalHours;
            if (hours <= 0) 
                return (false, BookingMessage.Create.InvalidDate, null);
            
            var originalPrice = vehicleRead.PricePerHour * (decimal)hours;
            var discountRate = GetDiscountRate(customer.LoyaltyPoints, settings);
            var discountAmount = originalPrice * discountRate;
            var finalTotalPrice = originalPrice - discountAmount;
            
            List<InsurancePackage> selectedInsurances = [];
            
            if (request.InsurancePackageIds != null && request.InsurancePackageIds.Count != 0)
            {
                selectedInsurances = await unitOfWork.GetReadRepository<InsurancePackage>()
                    .GetAsync(
                        filter: ip => request.InsurancePackageIds.Contains(ip.Id) && ip.IsActive,
                        cancellationToken: ct
                    );
                
                if (selectedInsurances.Count != request.InsurancePackageIds.Count)
                {
                    return (false, BookingMessage.Create.InvalidInsurance, null);
                }
                
                finalTotalPrice += selectedInsurances.Sum(i => i.Price);
            }
            
            var depositRatio = settings.GetDecimal(SystemSettingConstants.BookingSettings.DepositRatio, 0.3m);
            var latePenaltyRatio = settings.GetDecimal(SystemSettingConstants.BookingSettings.LatePenaltyRatio, 0.1m);
            var depositAmount = finalTotalPrice * depositRatio;
            
            var createdDate = DateTime.UtcNow;

            var booking = new Booking
            {
                CustomerId = customer.CustomerId,
                VehicleId = request.VehicleId,
                VehicleModelId = vehicleModel.Id,
                PickupLocationId = request.PickupLocationId,
                ReturnLocationId = request.PickupLocationId,
                Status = BookingStatus.Pending,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                TotalPrice = finalTotalPrice,
                DepositRatio = depositRatio,
                LatePenaltyRatio = latePenaltyRatio,
                MileageStart = vehicleModel.Mileage,
                Description = request.Note,
                AcceptedTermsVersion = request.AcceptedTermsVersion,
                AcceptedTermsAt = createdDate,
                CreatedAt = createdDate
            };

            await unitOfWork.GetWriteRepository<Booking>().AddAsync(booking, ct);
            await unitOfWork.SaveChangesAsync(ct);
            
            if (selectedInsurances.Count != 0)
            {
                foreach (var bookingInsurance in selectedInsurances.Select(insurance => new BookingInsurance
                         {
                             BookingId = booking.Id,
                             InsurancePackageId = insurance.Id,
                             Price = insurance.Price
                         }))
                {
                    await unitOfWork.GetWriteRepository<BookingInsurance>().AddAsync(bookingInsurance, ct);
                }

                await unitOfWork.SaveChangesAsync(ct);
            }
            
            var transactionCode = TransactionHelper.CreateCode();
            
            var transaction = new PaymentTransaction
            {
                TransactionCode = transactionCode,
                BookingId = booking.Id,
                Amount = depositAmount,
                PaymentDate = createdDate,
                PaymentMethod = request.PaymentMethod,
                Status = TransactionStatus.Pending,
                Type = TransactionType.Deposit,
                Note = $"Deposit for booking {booking.Id}. Discount applied: {discountRate * 100}%"
            };

            await unitOfWork.GetWriteRepository<PaymentTransaction>().AddAsync(transaction, ct);
            await unitOfWork.SaveChangesAsync(ct);
            

            string? qrCodeContent = null;
            string? paymentUrl = null;
            DateTime? expireDate = null;
            
            switch (request.PaymentMethod)
            {
                case PaymentMethod.VnPay:

                case PaymentMethod.InCash:
                    break;

                case PaymentMethod.PayOs:
                    var payOsRequest = new PayOsCreateRequest
                    {
                        TransactionCode = transactionCode,
                        TotalAmount = (long)depositAmount,
                        TransactorName = $"{customer.FirstName} {customer.LastName}",
                        TransactorEmail = user.Email,
                        TransactorPhone = customer.PhoneNumber,
                        TransactorAddress = customer.Address ?? "N/A",
                        Description = "Dat coc thue xe"
                    };

                    var payOsResponse = await payOsService.CreatePaymentAsync(payOsRequest);
                    
                    paymentUrl = payOsResponse.CheckoutUrl;
                    qrCodeContent = payOsResponse.QrCode;
                    
                    if (payOsResponse.ExpiredAt.HasValue)
                    {
                        expireDate = DateTimeOffset.FromUnixTimeSeconds(payOsResponse.ExpiredAt.Value).UtcDateTime;
                    }
                    
                    transaction.ExternalTransactionId = payOsResponse.PaymentLinkId;
                    unitOfWork.GetWriteRepository<PaymentTransaction>().Update(transaction);
                    await unitOfWork.SaveChangesAsync(ct);
                    break;
            }
            
            var transactionDto = new PaymentTransactionDto
            {
                BookingId = transaction.BookingId,
                TransactionCode = transaction.TransactionCode,
                TransactionId = transaction.Id,
                Status = transaction.Status,
                AmountToPay = transaction.Amount,
                PaymentMethod = transaction.PaymentMethod,
                PaymentUrl = paymentUrl,
                QrCode = qrCodeContent,
                ExpireDate = expireDate,
                TransactionType = TransactionType.Deposit
            };
            
            var bookingCreatedEvent = booking.ToCreatedEvent<Booking, BookingCreatedEvent, Guid>(_ => new BookingCreatedEvent
            {
                CustomerId = customer.CustomerId,
                CustomerName = $"{customer.FirstName} {customer.LastName}",
                CustomerEmail = user.Email,
                CustomerPhone = customer.PhoneNumber,
                VehicleId = booking.VehicleId,
                VehiclePricePerHour = vehicleRead.PricePerHour,
                VehicleModelId = vehicleModel.Id,
                NumberPlate = vehicleModel.NumberPlate,
                VehicleStatus = vehicleModel.Status.ToString(),
                PickupLocationId = booking.PickupLocationId,
                PickupLocationName = pickupLocation.Name,
                ReturnLocationId = booking.ReturnLocationId,
                ReturnLocationName = pickupLocation.Name,
                Status = booking.Status,
                StartDate = booking.StartDate,
                EndDate = booking.EndDate,
                TotalPrice = booking.TotalPrice,
                DepositRatio = booking.DepositRatio,
                DiscountRate = discountRate,
                LatePenaltyRatio = booking.LatePenaltyRatio,
                MileageStart = booking.MileageStart,
                Description = booking.Description,
                BookingImagesJson = null,
                Metadata = null,
                Id = default,
                CreatedAt = default,
                CreatedBy = null,
                UpdatedAt = default,
                UpdatedBy = null
            });

            await publishEndpoint.Publish(bookingCreatedEvent, ct);
            await unitOfWork.SaveChangesAsync(ct);
            
            return (true, BookingMessage.Create.Success, transactionDto);

        }, cancellationToken);
    }
    
    private async Task CheckAndProcessPendingTransactionsAsync(Customer customer, User user, CancellationToken ct)
    {
        var pendingBookings = await unitOfWork.GetWriteRepository<Booking>()
            .GetAsync(
                filter: b => b.CustomerId == customer.CustomerId && b.Status == BookingStatus.Pending,
                cancellationToken: ct
            );
        
        if (pendingBookings.Count == 0)
            return;
        
        var pendingBookingIds = pendingBookings.Select(b => b.Id).ToList();
        
        var pendingTransactions = await unitOfWork.GetWriteRepository<PaymentTransaction>()
            .GetAsync(
                filter: t => pendingBookingIds.Contains(t.BookingId) 
                          && t.Status == TransactionStatus.Pending 
                          && t.TransactionCode > 0,
                cancellationToken: ct
            );
        
        if (pendingTransactions.Count == 0)
            return;
        
        logger.LogInformation(
            "[CreateBooking] Found {Count} pending transactions for customer {CustomerId}. Checking PayOS status...",
            pendingTransactions.Count, customer.CustomerId);
        
        var paidTransactions = new List<PaymentTransaction>();

        foreach (var transaction in pendingTransactions)
        {
            var payOsStatus = await payOsService.GetPaymentLinkInformationAsync(transaction.TransactionCode);

            if (!payOsStatus.Status.Equals("PAID", StringComparison.OrdinalIgnoreCase))
                continue;

            logger.LogInformation(
                "[CreateBooking] Transaction {TransactionCode} was PAID on PayOS but not processed. Marking for refund.",
                transaction.TransactionCode);

            paidTransactions.Add(transaction);

            transaction.Status = TransactionStatus.Success;
            unitOfWork.GetWriteRepository<PaymentTransaction>().Update(transaction);
        }
        
        if (paidTransactions.Count == 0)
            return;
        
        await unitOfWork.SaveChangesAsync(ct);
        
        var refundRequestIds = new List<Guid>();
        
        foreach (var transaction in paidTransactions)
        {
            var refundRequest = new RefundRequest
            {
                BookingId = transaction.BookingId,
                CustomerId = customer.CustomerId,
                Amount = transaction.Amount,
                Reason = "Giao dịch được thanh toán nhưng hệ thống chưa xử lý do lỗi webhook. Tự động tạo yêu cầu hoàn tiền.",
                Status = RefundStatus.Pending,
                CreatedAt = DateTime.UtcNow
            };
            
            await unitOfWork.GetWriteRepository<RefundRequest>().AddAsync(refundRequest, ct);
            refundRequestIds.Add(refundRequest.Id);
            
            var booking = pendingBookings.FirstOrDefault(b => b.Id == transaction.BookingId);
            if (booking == null) continue;
            booking.Status = BookingStatus.Cancelled;
            booking.CancellationReason = "Đã thanh toán nhưng hệ thống chưa xử lý. Tự động hủy và tạo yêu cầu hoàn tiền.";
            unitOfWork.GetWriteRepository<Booking>().Update(booking);
        }
        
        await unitOfWork.SaveChangesAsync(ct);
        
        var refundNoticeEvent = new PendingTransactionsRefundNoticeEvent
        {
            CustomerId = customer.CustomerId,
            CustomerName = $"{customer.FirstName} {customer.LastName}",
            CustomerEmail = user.Email,
            TransactionCount = paidTransactions.Count,
            TotalAmount = paidTransactions.Sum(t => t.Amount),
            TransactionCodes = paidTransactions.Select(t => t.TransactionCode.ToString()).ToList(),
            RefundRequestIds = refundRequestIds,
            CreatedAt = DateTime.UtcNow
        };
        
        await publishEndpoint.Publish(refundNoticeEvent, ct);
        await unitOfWork.SaveChangesAsync(ct);
        
        logger.LogInformation(
            "[CreateBooking] Created {Count} refund requests and sent notification for customer {CustomerId}",
            paidTransactions.Count, customer.CustomerId);
    }
    
    private static decimal GetDiscountRate(int points, IEnumerable<SystemSetting> settings)
    {
        var settingsList = settings.ToList();
        
        var diamondThreshold = settingsList.GetInt(SystemSettingConstants.MembershipThresholds.Diamond);
        var platinumThreshold = settingsList.GetInt(SystemSettingConstants.MembershipThresholds.Platinum);
        var goldThreshold = settingsList.GetInt(SystemSettingConstants.MembershipThresholds.Gold);
        var silverThreshold = settingsList.GetInt(SystemSettingConstants.MembershipThresholds.Silver);
        var bronzeThreshold = settingsList.GetInt(SystemSettingConstants.MembershipThresholds.Bronze);
        
        var diamondDiscount = settingsList.GetDecimal(SystemSettingConstants.MembershipDiscounts.Diamond);
        var platinumDiscount = settingsList.GetDecimal(SystemSettingConstants.MembershipDiscounts.Platinum);
        var goldDiscount = settingsList.GetDecimal(SystemSettingConstants.MembershipDiscounts.Gold);
        var silverDiscount = settingsList.GetDecimal(SystemSettingConstants.MembershipDiscounts.Silver);
        var bronzeDiscount = settingsList.GetDecimal(SystemSettingConstants.MembershipDiscounts.Bronze);
        
        if (points >= diamondThreshold) return diamondDiscount;
        if (points >= platinumThreshold) return platinumDiscount;
        if (points >= goldThreshold) return goldDiscount;
        if (points >= silverThreshold) return silverDiscount;
        return points >= bronzeThreshold ? bronzeDiscount : 0;
    }
    
    private async Task<int> GetCancellationCountAsync(Guid customerId, CancellationToken ct)
    {
        var key = CacheKeyHelper.GetCancellationCacheKey(customerId);
        var countStr = await cacheService.GetStringAsync(key, ct);
        return int.TryParse(countStr, out var count) ? count : 0;
    }
}

