using MediatR;
using MassTransit;
using Microsoft.Extensions.Configuration;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using NET_CarRentalSystem.Application.Interfaces.Services.Storage;
using NET_CarRentalSystem.Application.Models.DTOs.BookingImageDTOs;
using NET_CarRentalSystem.Application.Models.DTOs.TransactionDTOs;
using NET_CarRentalSystem.Application.Models.Payments.PayOs;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.CoreHelpers;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Bookings.Commands.CreateFinalPaymentCommand;

#pragma warning disable IDE0051
public class CreateFinalPaymentCommand : ICommand<(bool, string, PaymentTransactionDto?)>
{
    public required Guid BookingId { get; init; }

    public required int MileageStart { get; init; }

    public int FuelLevelStart { get; set; }

    public required decimal FuelPrice { get; init; }

    public required string ConditionNotes { get; init; }

    public List<FileModel>? Images { get; init; }
}

public class CreateFinalPaymentCommandHandler(
    IUnitOfWork unitOfWork,
    IPublishEndpoint publishEndpoint,
    IPayOsService payOsService,
    ICloudinaryService cloudinaryService,
    IImageResizeService imageResizeService,
    IConfiguration configuration) : IRequestHandler<CreateFinalPaymentCommand, (bool, string, PaymentTransactionDto?)>
{
    private readonly int _maxImageWidth = int.Parse(configuration[KeyConstants.FinalPaymentSettings.MaxImageWidth] ?? "1920");
    private readonly int _maxImageHeight = int.Parse(configuration[KeyConstants.FinalPaymentSettings.MaxImageHeight] ?? "1080");
    private readonly int _imageQuality = int.Parse(configuration[KeyConstants.FinalPaymentSettings.ImageQuality] ?? "80");
    
    public async Task<(bool, string, PaymentTransactionDto?)> Handle(CreateFinalPaymentCommand request, CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var booking = await unitOfWork.GetWriteRepository<Booking>()
                .GetFirstOrDefaultAsync(b => b.Id == request.BookingId, ct);
            
            if (booking == null)
            {
                return (false, BookingMessage.FinalPayment.BookingNotFound, null);
            }

            if (booking.Status == BookingStatus.Cancelled)
            {
                return (false, BookingMessage.FinalPayment.BookingCancelled, null);
            }
            
            if (booking.Status != BookingStatus.DepositPaid)
            {
                return (false, BookingMessage.FinalPayment.InvalidBookingStatus, null);
            }

            booking.MileageStart = request.MileageStart;
            booking.FuelLevelStart = request.FuelLevelStart;
            booking.FuelPrice = request.FuelPrice;
            booking.ConditionNotes = request.ConditionNotes;

            unitOfWork.GetWriteRepository<Booking>().Update(booking);
            await unitOfWork.SaveChangesAsync(ct);
            
            var uploadedImages = new List<(string Url, string PublicId)>();
            var folder = $"{booking.CustomerId}/bookings/{booking.Id}";
            
            foreach (var image in request.Images ?? [])
            {
                var resizedFile = await imageResizeService.ResizeAndCompressAsync(
                    image, 
                    _maxImageWidth, 
                    _maxImageHeight, 
                    _imageQuality);
                
                var uploadResult = await cloudinaryService.UploadImageAsync(resizedFile, folder);
                uploadedImages.Add((uploadResult.SecureUrl, uploadResult.PublicId));
            }
            
            foreach (var (url, publicId) in uploadedImages)
            {
                var bookingImage = new BookingImage
                {
                    BookingId = booking.Id,
                    ImageUrl = url,
                    PublicId = publicId,
                    CreatedAt = DateTime.UtcNow
                };
                await unitOfWork.GetWriteRepository<BookingImage>().AddAsync(bookingImage, ct);
            }
            await unitOfWork.SaveChangesAsync(ct);
            
            var depositAmount = booking.TotalPrice * booking.DepositRatio;
            var remainingAmount = booking.TotalPrice - depositAmount;
            
            var customer = await unitOfWork.GetWriteRepository<Customer>()
                .GetByIdAsync(booking.CustomerId, ct);
            
            var user = await unitOfWork.GetReadRepository<User>()
                .GetFirstOrDefaultAsync(u => u.Id == customer!.UserId, cancellationToken: ct);
            
            var createdDate = DateTime.UtcNow;
            var transactionCode = TransactionHelper.CreateCode();
            
            var transaction = new PaymentTransaction
            {
                TransactionCode = transactionCode,
                BookingId = booking.Id,
                Amount = remainingAmount,
                PaymentDate = createdDate,
                PaymentMethod = PaymentMethod.PayOs,
                Status = TransactionStatus.Pending,
                Type = TransactionType.FinalPayment,
                Note = $"Final payment for booking {booking.Id}. Mileage: {request.MileageStart}km, Fuel: 100% (full tank), Fuel Price: {request.FuelPrice:N0}đ"
            };
            
            await unitOfWork.GetWriteRepository<PaymentTransaction>().AddAsync(transaction, ct);
            await unitOfWork.SaveChangesAsync(ct);
            
            var payOsRequest = new PayOsCreateRequest
            {
                TransactionCode = transactionCode,
                TotalAmount = (long)remainingAmount,
                TransactorName = $"{customer!.FirstName} {customer.LastName}",
                TransactorEmail = user?.Email!,
                TransactorPhone = customer.PhoneNumber,
                TransactorAddress = customer.Address ?? "N/A",
                Description = $"Final: {booking.Id.ToString()[..8]}"
            };
            
            var payOsResponse = await payOsService.CreatePaymentAsync(payOsRequest);
            
            transaction.ExternalTransactionId = payOsResponse.PaymentLinkId;
            unitOfWork.GetWriteRepository<PaymentTransaction>().Update(transaction);
            
            var bookingImages = await unitOfWork.GetWriteRepository<BookingImage>()
                .GetAsync(filter: bi => bi.BookingId == booking.Id, cancellationToken: ct);
            
            var imagesJson = bookingImages.Select(bi => new CreateJsonBookingImageDto
            {
                Id = bi.Id,
                ImageUrl = bi.ImageUrl,
                PublicId = bi.PublicId,
                CreatedAt = bi.CreatedAt ?? DateTime.UtcNow
            }).ToList().ToJson();
            
            var bookingUpdatedEvent = booking.ToUpdatedEvent<Booking, BookingUpdatedEvent, Guid>(_ => new BookingUpdatedEvent
            {
                Status = booking.Status,
                FuelLevelStart = booking.FuelLevelStart,
                FuelLevelEnd = booking.FuelLevelEnd,
                FuelPrice = booking.FuelPrice,
                ConditionNotes = booking.ConditionNotes,
                BookingImagesJson = imagesJson,
                Id = default,
                CreatedAt = default,
                CreatedBy = null,
                UpdatedAt = default,
                UpdatedBy = null
            });
            
            await publishEndpoint.Publish(bookingUpdatedEvent, ct);
            await unitOfWork.SaveChangesAsync(ct);
            
            var expireDate = payOsResponse.ExpiredAt.HasValue
                ? DateTimeOffset.FromUnixTimeSeconds(payOsResponse.ExpiredAt.Value).UtcDateTime
                : createdDate.AddMinutes(15);
            
            var transactionDto = new PaymentTransactionDto
            {
                BookingId = transaction.BookingId,
                TransactionCode = transaction.TransactionCode,
                TransactionId = transaction.Id,
                Status = transaction.Status,
                AmountToPay = transaction.Amount,
                PaymentMethod = transaction.PaymentMethod,
                PaymentUrl = payOsResponse.CheckoutUrl,
                QrCode = payOsResponse.QrCode,
                ExpireDate = expireDate,
                TransactionType = TransactionType.FinalPayment
            };
            
            return (true, BookingMessage.FinalPayment.Success, transactionDto);
            
        }, cancellationToken);
    }
}

