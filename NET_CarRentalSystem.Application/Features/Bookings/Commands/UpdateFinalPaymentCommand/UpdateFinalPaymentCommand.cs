using MassTransit;
using MediatR;
using Microsoft.Extensions.Configuration;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Storage;
using NET_CarRentalSystem.Application.Models.DTOs.BookingImageDTOs;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Bookings.Commands.UpdateFinalPaymentCommand;

public class UpdateFinalPaymentCommand : ICommand<(bool, string)>
{
    public required Guid BookingId { get; init; }

    public required int MileageStart { get; init; }

    public required int FuelLevelStart { get; init; }

    public required decimal FuelPrice { get; init; }

    public required string ConditionNotes { get; init; }

    public List<FileModel>? Images { get; init; }
}

public class UpdateFinalPaymentCommandHandler(
    IUnitOfWork unitOfWork,
    IPublishEndpoint publishEndpoint,
    IImageResizeService imageResizeService,
    IConfiguration configuration,
    ICloudinaryService cloudinaryService) : IRequestHandler<UpdateFinalPaymentCommand, (bool, string)>
{
    private readonly int _maxImageWidth =
        int.Parse(configuration[KeyConstants.FinalPaymentSettings.MaxImageWidth] ?? "1920");

    private readonly int _maxImageHeight =
        int.Parse(configuration[KeyConstants.FinalPaymentSettings.MaxImageHeight] ?? "1080");

    private readonly int _imageQuality =
        int.Parse(configuration[KeyConstants.FinalPaymentSettings.ImageQuality] ?? "80");

    public async Task<(bool, string)> Handle(UpdateFinalPaymentCommand request, CancellationToken ct)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async (token) =>
        {
            var bookingRepo = unitOfWork.GetWriteRepository<Booking>();
            var booking = await bookingRepo
                .GetFirstOrDefaultAsync(b => b.Id == request.BookingId, token);

            if (booking == null)
                return (false, BookingMessage.FinalPayment.BookingNotFound);

            if (booking.Status == BookingStatus.Cancelled)
                return (false, BookingMessage.FinalPayment.BookingCancelled);

            if (booking.Status != BookingStatus.DepositPaid)
                return (false, BookingMessage.FinalPayment.InvalidBookingStatus);

            booking.MileageStart = request.MileageStart;
            booking.FuelLevelStart = request.FuelLevelStart;
            booking.FuelPrice = request.FuelPrice;
            booking.ConditionNotes = request.ConditionNotes;

            bookingRepo.Update(booking);
            await unitOfWork.SaveChangesAsync(token);
            
            var bookingImageRepo = unitOfWork.GetWriteRepository<BookingImage>();
            var existingImages = await bookingImageRepo.GetAsync(
                filter: bi => bi.BookingId == booking.Id,
                cancellationToken: token);
            
            foreach (var image in existingImages)
            {
                var deleted = await cloudinaryService.DeleteImageAsync(image.PublicId);
                if (!deleted)
                    return (false, BookingMessage.UpdateFinalPayment.Error);
            }
            
            bookingImageRepo.RemoveRange(existingImages);
            await unitOfWork.SaveChangesAsync(token);
            
            var folder = $"{booking.CustomerId}/bookings/{booking.Id}";
            var uploadedImages = new List<(string Url, string PublicId)>();

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

                await bookingImageRepo.AddAsync(bookingImage, token);
            }

            await unitOfWork.SaveChangesAsync(token);

            //này là event sau khi update xog phải get lại
            var bookingImages = await bookingImageRepo.GetAsync(
                filter: bi => bi.BookingId == booking.Id,
                cancellationToken: token);

            var imagesJson = bookingImages
                .Select(bi => new CreateJsonBookingImageDto
                {
                    Id = bi.Id,
                    ImageUrl = bi.ImageUrl,
                    PublicId = bi.PublicId,
                    CreatedAt = bi.CreatedAt ?? DateTime.UtcNow
                })
                .ToList()
                .ToJson();

            var bookingUpdatedEvent = booking.ToUpdatedEvent<Booking, BookingUpdatedEvent, Guid>(_ =>
                new BookingUpdatedEvent
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

            await publishEndpoint.Publish(bookingUpdatedEvent, token);

            return (true, BookingMessage.UpdateFinalPayment.Success);
        }, ct);
    }
}
