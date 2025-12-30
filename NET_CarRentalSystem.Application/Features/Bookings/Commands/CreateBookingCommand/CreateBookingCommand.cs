using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
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
    public Guid VehicleId { get; set; }
    
    public Guid PickupLocationId { get; set; }
    
    public Guid? ReturnLocationId { get; set; }
    
    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    public PaymentMethod PaymentMethod { get; set; }
    
    public string? Note { get; set; }
}

public class CreateBookingCommandHandler(
    IUnitOfWork unitOfWork,
    ICurrentUserService currentUserService,
    IVnPayService vnPayService,
    IPayOsService payOsService) : IRequestHandler<CreateBookingCommand, (bool, string, PaymentTransactionDto?)>
{
    public async Task<(bool, string, PaymentTransactionDto?)> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
    {
        var userId = currentUserService.GetUserId();

        return await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var include = new IncludeBuilder<User>().Include(u => u.Customer);
            var builder = include.Build();
            var user = await unitOfWork.GetReadRepository<User>()
                .GetFirstAsync(c => c.Id == userId, includeProperties: builder, cancellationToken: ct);
            
            var vehicleRead = await unitOfWork.GetReadRepository<VehicleReadFlat>().GetByIdAsync(request.VehicleId, ct);
            if (vehicleRead == null) 
                return (false, BookingMessage.Create.VehicleNotFound, null);
            
            var vehicleWrite = await unitOfWork.GetWriteRepository<Vehicle>().GetByIdAsync(request.VehicleId, ct);
            if (vehicleWrite == null || vehicleWrite.Status != VehicleStatus.Available) 
                return (false, BookingMessage.Create.VehicleNotAvailable, null);
            
            var settings = await unitOfWork.GetReadRepository<SystemSetting>().GetAsync(cancellationToken: ct);
            
            var duration = request.EndDate - request.StartDate;
            var hours = duration.TotalHours;
            if (hours <= 0) 
                return (false, BookingMessage.Create.InvalidDate, null);
            
            var originalPrice = vehicleRead.PricePerHour * (decimal)hours;
            var discountRate = GetDiscountRate(user.Customer!.LoyaltyPoints, settings);
            var discountAmount = originalPrice * discountRate;
            var finalTotalPrice = originalPrice - discountAmount;
            
            var depositRatio = GetDepositRatio(settings);
            var depositAmount = finalTotalPrice * depositRatio;
            
            var createdDate = DateTime.UtcNow;
            var expireDate = createdDate.AddMinutes(15);

            var booking = new Booking
            {
                CustomerId = user.Customer.Id,
                VehicleId = request.VehicleId,
                PickupLocationId = request.PickupLocationId,
                ReturnLocationId = request.ReturnLocationId ?? request.PickupLocationId,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                TotalPrice = finalTotalPrice,
                DepositRatio = depositRatio,
                MileageStart = vehicleRead.Mileage,
                Description = request.Note,
                CreatedAt = createdDate
            };

            await unitOfWork.GetWriteRepository<Booking>().AddAsync(booking, ct);
            await unitOfWork.SaveChangesAsync(ct);
            
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
                        TransactorName = $"{user.Customer!.FirstName} {user.Customer.LastName}",
                        TransactorEmail = user.Email,
                        TransactorPhone = user.Customer.PhoneNumber,
                        TransactorAddress = user.Customer.Address ?? "N/A",
                        Description = $"Deposit for booking: {booking.Id}"
                    };

                    var payOsResponse = await payOsService.CreatePaymentAsync(payOsRequest);
                    
                    paymentUrl = payOsResponse.CheckoutUrl;
                    qrCodeContent = payOsResponse.QrCode;
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
            
            return (true, BookingMessage.Create.Success, transactionDto);

        }, cancellationToken);
    }
    
    private static decimal GetDiscountRate(int points, List<SystemSetting> settings)
    {
        var diamondThreshold = GetValue(nameof(SystemSettingConstants.MembershipThresholds.Diamond));
        var platinumThreshold = GetValue(nameof(SystemSettingConstants.MembershipThresholds.Platinum));
        var goldThreshold = GetValue(nameof(SystemSettingConstants.MembershipThresholds.Gold));
        var silverThreshold = GetValue(nameof(SystemSettingConstants.MembershipThresholds.Silver));
        var bronzeThreshold = GetValue(nameof(SystemSettingConstants.MembershipThresholds.Bronze));
        
        var diamondDiscount = GetValue(nameof(SystemSettingConstants.MembershipDiscounts.Diamond));
        var platinumDiscount = GetValue(nameof(SystemSettingConstants.MembershipDiscounts.Platinum));
        var goldDiscount = GetValue(nameof(SystemSettingConstants.MembershipDiscounts.Gold));
        var silverDiscount = GetValue(nameof(SystemSettingConstants.MembershipDiscounts.Silver));
        var bronzeDiscount = GetValue(nameof(SystemSettingConstants.MembershipDiscounts.Bronze));
        
        if (points >= diamondThreshold) return diamondDiscount;
        if (points >= platinumThreshold) return platinumDiscount;
        if (points >= goldThreshold) return goldDiscount;
        if (points >= silverThreshold) return silverDiscount;
        return points >= bronzeThreshold ? bronzeDiscount : 0;

        decimal GetValue(string keyName)
        {
            var setting = settings.FirstOrDefault(s => s.SettingKey == keyName);
            return setting != null && decimal.TryParse(setting.SettingValue, out var val) ? val : 0;
        }
    }
    
    private static decimal GetDepositRatio(List<SystemSetting> settings)
    {
        var setting = settings.FirstOrDefault(s => s.SettingKey == SystemSettingConstants.BookingSettings.DepositRatio);
        return setting != null && decimal.TryParse(setting.SettingValue, out var val) ? val : 0.3m;
    }
}
