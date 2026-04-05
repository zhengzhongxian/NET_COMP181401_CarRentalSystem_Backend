using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Ai;
using NET_CarRentalSystem.Application.Interfaces.Services.Storage;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using MassTransit;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Shared.Utilities;
using NET_CarRentalSystem.Application.Models.DTOs.BookingViolationDTOs.Create;
using NET_CarRentalSystem.Application.Models.DTOs.ReturnImageDTOs.Create;
using Microsoft.Extensions.Configuration;
using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Features.Bookings.Commands.UpdateAfterReturnCommand;

public class UpdateAfterReturnCommand : ICommand<(bool Success, string Message, int ViolationCount, List<BookingViolation> Violations)>
{
    public Guid BookingId { get; set; }
    public int MileageEnd { get; set; }
    public int FuelLevelEnd { get; set; }
    public string? VehicleDamageNotes { get; set; }
    public List<FileModel>? ReturnImages { get; set; }
}

public class UpdateAfterReturnCommandHandler(
    IUnitOfWork unitOfWork,
    ICloudinaryService cloudinaryService,
    IPublishEndpoint publishEndpoint,
    IAiImageVerificationService aiVerificationService,
    IImageResizeService imageResizeService,
    IConfiguration configuration) : IRequestHandler<UpdateAfterReturnCommand, (bool, string, int, List<BookingViolation>)>
{
    private readonly int _maxImageWidth = int.Parse(configuration[KeyConstants.FinalPaymentSettings.MaxImageWidth] ?? "1920");
    private readonly int _maxImageHeight = int.Parse(configuration[KeyConstants.FinalPaymentSettings.MaxImageHeight] ?? "1080");
    private readonly int _imageQuality = int.Parse(configuration[KeyConstants.FinalPaymentSettings.ImageQuality] ?? "80");
    public async Task<(bool, string, int, List<BookingViolation>)> Handle(
        UpdateAfterReturnCommand request,
        CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async ct =>
        {
            var booking = await unitOfWork.GetWriteRepository<Booking>()
                .GetFirstOrDefaultAsync(b => b.Id == request.BookingId, ct);

            if (booking == null)
                return (false, BookingMessage.UpdateAfterReturn.BookingNotFound, 0, []);
            
            var customer = await unitOfWork.GetWriteRepository<Customer>()
                .GetFirstOrDefaultAsync(c => c.CustomerId == booking.CustomerId, cancellationToken: ct);

            var user = customer?.UserId.HasValue == true
                ? await unitOfWork.GetReadRepository<User>().GetFirstOrDefaultAsync(u => u.Id == customer.UserId.Value, cancellationToken: ct)
                : null;
            

            if (booking.Status != BookingStatus.Returned)
                return (false, BookingMessage.UpdateAfterReturn.InvalidStatus, 0, []);

            if (booking.MileageEnd.HasValue)
                return (false, BookingMessage.UpdateAfterReturn.AlreadyUpdated, 0, []);
            
            if (request.MileageEnd < booking.MileageStart)
                return (false, BookingMessage.UpdateAfterReturn.MileageLessThanStart, 0, new List<BookingViolation>());

            var latePenaltyRatio = booking.LatePenaltyRatio;
            
            booking.MileageEnd = request.MileageEnd;
            booking.FuelLevelEnd = request.FuelLevelEnd;
            
            var vehicleModel = await unitOfWork.GetWriteRepository<VehicleModel>()
                .GetByIdAsync(booking.VehicleModelId, ct);
            
            var pickupImages = await unitOfWork.GetWriteRepository<BookingImage>()
                .GetAsync(filter: bi => bi.BookingId == booking.Id, cancellationToken: ct);
            
            var pickupImageBytes = new List<byte[]>();
            string? detectedPickupPlate = null;
            
            foreach (var pickupImage in pickupImages)
            {
                var imageBytes = await cloudinaryService.DownloadImageAsync(pickupImage.ImageUrl);
                if (imageBytes != null)
                {
                    pickupImageBytes.Add(imageBytes);
                    
                    if (detectedPickupPlate == null && !string.IsNullOrEmpty(vehicleModel?.NumberPlate))
                    {
                        var pickupPlateResult = await aiVerificationService.ExtractLicensePlateAsync(
                            imageBytes,
                            vehicleModel.NumberPlate,
                            pickupImage.ImageUrl,
                            ct);
                        
                        if (!pickupPlateResult.WasSkipped && pickupPlateResult.PlateDetected)
                        {
                            detectedPickupPlate = pickupPlateResult.DetectedPlate;
                        }
                    }
                }
            }
            
            var returnImageBytes = new List<byte[]>();
            byte[]? firstReturnImageBytes = null;
            
            if (request.ReturnImages?.Count > 0)
            {
                for (var i = 0; i < request.ReturnImages.Count; i++)
                {
                    var returnImage = request.ReturnImages[i];
                    
                    var resizedReturnImage = await imageResizeService.ResizeAndCompressAsync(
                        returnImage,
                        _maxImageWidth,
                        _maxImageHeight,
                        _imageQuality);

                    request.ReturnImages[i] = resizedReturnImage;

                    using var ms = new MemoryStream();
                    await resizedReturnImage.Content.CopyToAsync(ms, ct);
                    var imgBytes = ms.ToArray();
                    returnImageBytes.Add(imgBytes);
                    
                    if (i == 0)
                    {
                        firstReturnImageBytes = imgBytes;
                    }
                    
                    if (resizedReturnImage.Content.CanSeek)
                    {
                        resizedReturnImage.Content.Position = 0;
                    }
                }
            }
            
            if (!string.IsNullOrEmpty(vehicleModel?.NumberPlate) && firstReturnImageBytes != null)
            {
                var plateResult = await aiVerificationService.ExtractLicensePlateAsync(
                    firstReturnImageBytes,
                    vehicleModel.NumberPlate,
                    request.ReturnImages![0].FileName,
                    ct);
                
                if (!plateResult.WasSkipped && plateResult.PlateDetected && !plateResult.IsMatched)
                {
                    return (false, string.Format(BookingMessage.AiVerification.LicensePlateMismatch, 
                        plateResult.DetectedPlate, vehicleModel.NumberPlate), 0, []);
                }
                
                if (detectedPickupPlate != null && plateResult.PlateDetected)
                {
                    var normalizedPickup = detectedPickupPlate.Replace("-", "").Replace(" ", "").ToUpperInvariant();
                    var normalizedReturn = plateResult.DetectedPlate.Replace("-", "").Replace(" ", "").ToUpperInvariant();
                    
                    if (normalizedPickup != normalizedReturn)
                    {
                        return (false, string.Format(BookingMessage.AiVerification.LicensePlatePickupReturnMismatch, 
                            detectedPickupPlate, plateResult.DetectedPlate), 0, []);
                    }
                }
            }
            
            var existingReturnImages = await unitOfWork.GetWriteRepository<VehicleReturnImage>()
                .GetAsync(filter: ri => ri.BookingId == booking.Id, cancellationToken: ct);
            
            if (existingReturnImages.Count > 0)
            {
                foreach (var existingImage in existingReturnImages)
                {
                    if (!string.IsNullOrEmpty(existingImage.PublicId))
                    {
                        await cloudinaryService.DeleteImageAsync(existingImage.PublicId);
                    }
                }
                
                unitOfWork.GetWriteRepository<VehicleReturnImage>().RemoveRange(existingReturnImages);
                await unitOfWork.SaveChangesAsync(ct);
            }
            
            var returnImages = new List<VehicleReturnImage>();
          
            for (var i = 0; i < request.ReturnImages!.Count; i++)
            {
                var image = request.ReturnImages![i];
                var uploadResult = await cloudinaryService.UploadImageAsync(image, folder: $"bookings/{booking.Id}/returns");

                returnImages.Add(new VehicleReturnImage
                {
                    BookingId = booking.Id,
                    ImageUrl = uploadResult.Url,
                    PublicId = uploadResult.PublicId,
                    DisplayOrder = i + 1,
                    Description = null
                });
            }

            await unitOfWork.GetWriteRepository<VehicleReturnImage>().AddRangeAsync(returnImages, ct);
            
            var violations = new List<BookingViolation>();
            
            var fuelShortage = booking.FuelLevelStart - request.FuelLevelEnd;
            if (fuelShortage > 0)
            {
                var fuelLitersShortage = (fuelShortage / 100m) * 50m;
                var fuelPrice = booking.FuelPrice ?? 0m;
                var fuelCost = fuelLitersShortage * fuelPrice;

                violations.Add(new BookingViolation
                {
                    BookingId = booking.Id,
                    ViolationType = ViolationType.FuelShortage,
                    Status = ViolationStatus.Pending,
                    Amount = fuelCost,
                    Description = $"Thiếu nhiên liệu {fuelShortage}%",
                    Details = $"Mức nhiên liệu lúc nhận: {booking.FuelLevelStart}%, lúc trả: {request.FuelLevelEnd}%. " +
                             $"Ước tính thiếu {fuelLitersShortage:F2} lít, giá {fuelPrice:N0} VND/lít."
                });
            }
            
            if (booking.ActualEndDate.HasValue && booking.ActualEndDate.Value > booking.EndDate)
            {
                var lateDays = (booking.ActualEndDate.Value - booking.EndDate).TotalDays;
                var latePenalty = booking.TotalPrice * latePenaltyRatio * (decimal)Math.Ceiling(lateDays);

                violations.Add(new BookingViolation
                {
                    BookingId = booking.Id,
                    ViolationType = ViolationType.LateReturn,
                    Status = ViolationStatus.Pending,
                    Amount = latePenalty,
                    Description = $"Trả xe muộn {Math.Ceiling(lateDays)} ngày",
                    Details = $"Ngày hẹn trả: {booking.EndDate:dd/MM/yyyy HH:mm}, " +
                             $"Ngày trả thực tế: {booking.ActualEndDate.Value:dd/MM/yyyy HH:mm}. " +
                             $"Phạt {latePenaltyRatio * 100}% giá thuê mỗi ngày."
                });
            }
            
            string? damageNotes = request.VehicleDamageNotes;
            
            if (string.IsNullOrWhiteSpace(damageNotes) && pickupImageBytes.Count > 0 && returnImageBytes.Count > 0)
            {
                var damageResult = await aiVerificationService.DetectDamageAsync(
                    pickupImageBytes,
                    returnImageBytes,
                    0.7f,
                    ct);
                
                if (!damageResult.WasSkipped && damageResult.DamageDetected)
                {
                    damageNotes = $"[AI] {damageResult.DamageDescriptionVi}";
                }
            }
            
            if (!string.IsNullOrWhiteSpace(damageNotes))
            {
                violations.Add(new BookingViolation
                {
                    BookingId = booking.Id,
                    ViolationType = ViolationType.VehicleDamage,
                    Status = ViolationStatus.Pending,
                    Amount = 0,
                    Description = "Xe bị hư hỏng",
                    Details = damageNotes
                });
            }
            
            if (violations.Count != 0)
            {
                await unitOfWork.GetWriteRepository<BookingViolation>().AddRangeAsync(violations, ct);
                
                if (customer != null)
                {
                    customer.HasActiveViolation = true;
                    unitOfWork.GetWriteRepository<Customer>().Update(customer);
                }
            }

            unitOfWork.GetWriteRepository<Booking>().Update(booking);
            await unitOfWork.SaveChangesAsync(ct);
            
            if (violations.Count != 0)
            {
                var customerName = customer != null ? $"{customer.FirstName} {customer.LastName}" : "Khách hàng";
                var violationDetailsHtml = string.Join("", violations.Select((v, index) =>
                {
                    var violationTypeText = v.ViolationType switch
                    {
                        ViolationType.FuelShortage => "🔋 Thiếu nhiên liệu",
                        ViolationType.LateReturn => "⏰ Trả xe muộn",
                        ViolationType.VehicleDamage => "🔧 Xe bị hư hỏng",
                        _ => "Vi phạm"
                    };

                    return $"<div><strong>{index + 1}. {violationTypeText}</strong><div>{v.Description}</div><div>{v.Details}</div><div>Số tiền: {v.Amount:N0} VND</div></div>";
                }));

                var totalAmount = violations.Sum(v => v.Amount);

                var evt = new BookingReturnViolationEvent
                {
                    BookingId = booking.Id,
                    CustomerId = booking.CustomerId,
                    CustomerName = customerName,
                    CustomerEmail = user?.Email,
                    ViolationDetailsHtml = violationDetailsHtml,
                    ViolationCount = violations.Count,
                    TotalAmount = totalAmount,
                    CreatedAt = DateTime.UtcNow
                };
                
                await publishEndpoint.Publish(evt, ct);
                await unitOfWork.SaveChangesAsync(ct);
            }
            
            var bookingViolationsDto = violations.Select(v => new CreateJsonBookingViolationDto
            {
                Id = v.Id,
                ViolationType = v.ViolationType.ToString(),
                Amount = v.Amount,
                Description = v.Description,
                Details = v.Details,
                Status = v.Status.ToString()
            }).ToList();

            var returnImagesDto = returnImages.Select(ri => new CreateJsonReturnImageDto
            {
                Id = ri.Id,
                ImageUrl = ri.ImageUrl,
                PublicId = ri.PublicId,
                DisplayOrder = ri.DisplayOrder
            }).ToList();

            var bookingViolationsJson = bookingViolationsDto.ToJson();
            var returnImagesJson = returnImagesDto.ToJson();

            var bookingUpdatedEvent = booking.ToUpdatedEvent<Booking, BookingUpdatedEvent, Guid>(_ => new BookingUpdatedEvent
            {
                Status = booking.Status,
                FuelLevelStart = booking.FuelLevelStart,
                FuelLevelEnd = booking.FuelLevelEnd,
                MileageEnd = booking.MileageEnd,
                BookingViolationsJson = bookingViolationsJson,
                ReturnImagesJson = returnImagesJson,
                Id = default,
                CreatedAt = default,
                CreatedBy = null,
                UpdatedAt = default,
                UpdatedBy = null
            });

            await publishEndpoint.Publish(bookingUpdatedEvent, ct);
            await unitOfWork.SaveChangesAsync(ct);

            var message = violations.Count != 0
                ? string.Format(BookingMessage.UpdateAfterReturn.SuccessWithViolations, violations.Count)
                : BookingMessage.UpdateAfterReturn.Success;

            return (true, message, violations.Count, violations);

        }, cancellationToken);
    }
}
