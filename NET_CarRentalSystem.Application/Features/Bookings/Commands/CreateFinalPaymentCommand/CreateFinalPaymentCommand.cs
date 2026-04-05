using MediatR;
using MassTransit;
using Microsoft.Extensions.Configuration;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Ai;
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
    IAiImageVerificationService aiVerificationService,
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
            
            var vehicleModel = await unitOfWork.GetWriteRepository<VehicleModel>()
                .GetByIdAsync(booking.VehicleModelId, ct);
            
            // AI vehicle image verification - verify ALL images are vehicle images
            if (request.Images?.Count > 0)
            {
                var imagesToVerify = new List<(byte[] Data, string Filename)>();
                
                foreach (var image in request.Images)
                {
                    using var ms = new MemoryStream();
                    image.Content.Position = 0;
                    await image.Content.CopyToAsync(ms, ct);
                    imagesToVerify.Add((ms.ToArray(), image.FileName));
                }
                
                var batchResult = await aiVerificationService.VerifyVehicleImagesBatchAsync(
                    imagesToVerify,
                    minConfidence: 0.6f,
                    cancellationToken: ct);
                
                if (!batchResult.AllValid)
                {
                    // Get invalid image filenames using indices
                    var invalidFilenames = batchResult.InvalidIndices
                        .Where(i => i < imagesToVerify.Count)
                        .Select(i => imagesToVerify[i].Filename)
                        .ToList();
                    
                    return (false, string.Format(BookingMessage.AiVerification.NotVehicleImage, 
                        string.Join(", ", invalidFilenames)), null);
                }
                
                // License plate verification - only check first image
                if (!string.IsNullOrEmpty(vehicleModel?.NumberPlate))
                {
                    var firstImageBytes = imagesToVerify[0].Data;
                    var firstImageFilename = imagesToVerify[0].Filename;
                    
                    var plateResult = await aiVerificationService.ExtractLicensePlateAsync(
                        firstImageBytes,
                        vehicleModel.NumberPlate,
                        firstImageFilename,
                        ct);
                    
                    if (!plateResult.WasSkipped && plateResult.PlateDetected && !plateResult.IsMatched)
                    {
                        return (false, string.Format(BookingMessage.AiVerification.LicensePlateMismatch, 
                            plateResult.DetectedPlate, vehicleModel.NumberPlate), null);
                    }
                }
            }

            booking.MileageStart = request.MileageStart;
            booking.FuelLevelStart = request.FuelLevelStart;
            booking.FuelPrice = request.FuelPrice;
            booking.ConditionNotes = request.ConditionNotes;

            unitOfWork.GetWriteRepository<Booking>().Update(booking);
            await unitOfWork.SaveChangesAsync(ct);
            
            if (request.Images is { Count: > 0 })
            {
                var existingImages = await unitOfWork.GetWriteRepository<BookingImage>()
                    .GetAsync(filter: bi => bi.BookingId == booking.Id, cancellationToken: ct);
                
                foreach (var existingImage in existingImages)
                {
                    if (!string.IsNullOrEmpty(existingImage.PublicId))
                    {
                        await cloudinaryService.DeleteImageAsync(existingImage.PublicId);
                    }
                    
                    unitOfWork.GetWriteRepository<BookingImage>().Remove(existingImage, hardDelete: true);
                }
                
                if (existingImages.Count != 0)
                {
                    await unitOfWork.SaveChangesAsync(ct);
                }
            }
            
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
            
            // Thanh toán 100% giá thuê - tiền cọc giữ riêng, hoàn trả sau 30 ngày
            var paymentAmount = booking.TotalPrice;
            
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
                Amount = paymentAmount,
                PaymentDate = createdDate,
                PaymentMethod = PaymentMethod.PayOs,
                Status = TransactionStatus.Pending,
                Type = TransactionType.FinalPayment,
                Note = $"Full payment (100%) for booking {booking.Id}. Deposit held separately for 30 days. Mileage: {request.MileageStart}km, Fuel Price: {request.FuelPrice:N0}đ"
            };
            
            await unitOfWork.GetWriteRepository<PaymentTransaction>().AddAsync(transaction, ct);
            await unitOfWork.SaveChangesAsync(ct);
            
            var payOsRequest = new PayOsCreateRequest
            {
                TransactionCode = transactionCode,
                TotalAmount = (long)paymentAmount,
                TransactorName = $"{customer!.FirstName} {customer.LastName}",
                TransactorEmail = user?.Email!,
                TransactorPhone = customer.PhoneNumber,
                TransactorAddress = customer.Address ?? "N/A",
                Description = $"Thue xe: {booking.Id.ToString()[..8]}"
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
                MileageStart = booking.MileageStart,
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