using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.BookingDTOs.Get;
using NET_CarRentalSystem.Application.Models.DTOs.BookingImageDTOs.Get;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Bookings.Queries.GetBookingDetailQuery;

public class GetBookingDetailQuery : IQuery<GetBookingDetailDto?>
{
    public required Guid BookingId { get; set; }
}

public class GetBookingDetailQueryHandler(IDapperRepository dapperRepository) 
    : IRequestHandler<GetBookingDetailQuery, GetBookingDetailDto?>
{
    public async Task<GetBookingDetailDto?> Handle(GetBookingDetailQuery request, CancellationToken cancellationToken)
    {
        const string sql = """
            SELECT
                booking_id_src AS BookingId,
                customer_id AS CustomerId,
                customer_name AS CustomerName,
                customer_email AS CustomerEmail,
                customer_phone AS CustomerPhone,
                vehicle_id AS VehicleId,
                vehicle_price_per_hour AS VehiclePricePerHour,
                vehicle_model_id AS VehicleModelId,
                number_plate AS NumberPlate,
                vehicle_status AS VehicleStatus,
                pickup_location_name AS PickupLocationName,
                return_location_name AS ReturnLocationName,
                file_name AS FileName,
                status AS Status,
                start_date AS StartDate,
                end_date AS EndDate,
                actual_end_date AS ActualEndDate,
                total_price AS TotalPrice,
                deposit_ratio AS DepositRatio,
                discount_rate AS DiscountRate,
                late_penalty_ratio AS LatePenaltyRatio,
                mileage_start AS MileageStart,
                fuel_level_end AS FuelLevelEnd,
                fuel_price AS FuelPrice,
                condition_notes AS ConditionNotes,
                description AS Description,
                swap_reason AS SwapReason,
                cancellation_reason AS CancellationReason,
                booking_images_json AS BookingImagesJson,
                metadata AS Metadata,
                created_at AS CreatedAt,
                created_by AS CreatedBy,
                updated_at AS UpdatedAt,
                updated_by AS UpdatedBy
            FROM booking_read_flat
            WHERE booking_id_src = @BookingId AND is_deleted = 0
        """;

        var bookingFlat = await dapperRepository.QueryFirstOrDefaultAsync<GetBookingReadFlatDto>(
            sql, 
            new { request.BookingId }, 
            cancellationToken: cancellationToken);

        if (bookingFlat == null)
            return null;

        var bookingImages = !string.IsNullOrEmpty(bookingFlat.BookingImagesJson)
            ? bookingFlat.BookingImagesJson.FromJson<List<GetBookingImageDto>>()
            : new List<GetBookingImageDto>();

        return new GetBookingDetailDto
        {
            BookingId = bookingFlat.BookingId,
            CustomerId = bookingFlat.CustomerId,
            CustomerName = bookingFlat.CustomerName,
            CustomerEmail = bookingFlat.CustomerEmail,
            CustomerPhone = bookingFlat.CustomerPhone,
            VehicleId = bookingFlat.VehicleId,
            VehiclePricePerHour = bookingFlat.VehiclePricePerHour,
            VehicleModelId = bookingFlat.VehicleModelId,
            NumberPlate = bookingFlat.NumberPlate,
            VehicleStatus = bookingFlat.VehicleStatus,
            PickupLocationName = bookingFlat.PickupLocationName,
            ReturnLocationName = bookingFlat.ReturnLocationName,
            FileName = bookingFlat.FileName,
            Status = bookingFlat.Status,
            StartDate = bookingFlat.StartDate,
            EndDate = bookingFlat.EndDate,
            ActualEndDate = bookingFlat.ActualEndDate,
            TotalPrice = bookingFlat.TotalPrice,
            DepositRatio = bookingFlat.DepositRatio,
            DiscountRate = bookingFlat.DiscountRate,
            LatePenaltyRatio = bookingFlat.LatePenaltyRatio,
            MileageStart = bookingFlat.MileageStart,
            FuelLevelEnd = bookingFlat.FuelLevelEnd,
            FuelPrice = bookingFlat.FuelPrice,
            ConditionNotes = bookingFlat.ConditionNotes,
            Description = bookingFlat.Description,
            SwapReason = bookingFlat.SwapReason,
            CancellationReason = bookingFlat.CancellationReason,
            BookingImages = bookingImages,
            Metadata = bookingFlat.Metadata,
            CreatedAt = bookingFlat.CreatedAt,
            CreatedBy = bookingFlat.CreatedBy,
            UpdatedAt = bookingFlat.UpdatedAt,
            UpdatedBy = bookingFlat.UpdatedBy
        };
    }
}
