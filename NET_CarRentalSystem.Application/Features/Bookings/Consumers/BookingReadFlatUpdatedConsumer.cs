using MassTransit;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Bookings.Consumers;

public class BookingReadFlatUpdatedConsumer(
    ILogger<BookingReadFlatUpdatedConsumer> logger,
    IDapperRepository dapperRepository) : IConsumer<BookingUpdatedEvent>
{
    public async Task Consume(ConsumeContext<BookingUpdatedEvent> context)
    {
        var msg = context.Message;
        
        logger.LogInformation("[BookingUpdatedEvent] ========== STARTING UPDATE PROCESS ==========");
        logger.LogInformation("[BookingUpdatedEvent] Booking ID: {Id}", msg.Id);
        logger.LogInformation("[BookingUpdatedEvent] Updated At: {UpdatedAt}", msg.UpdatedAt);
        logger.LogInformation("[BookingUpdatedEvent] Updated By: {UpdatedBy}", msg.UpdatedBy);

        var setClauses = new List<string>();
        var parameters = new Dictionary<string, object?>
        {
            { "@Id", msg.Id },
            { "@UpdatedAt", msg.UpdatedAt },
            { "@UpdatedBy", msg.UpdatedBy }
        };

        logger.LogInformation("[BookingUpdatedEvent] Checking fields to update...");

        if (msg.VehicleModelId.HasValue)
        {
            setClauses.Add("vehicle_model_id = @VehicleModelId");
            parameters.Add("@VehicleModelId", msg.VehicleModelId.Value);
            logger.LogInformation("[BookingUpdatedEvent] ✓ VehicleModelId: {VehicleModelId}", msg.VehicleModelId.Value);
        }

        if (msg.NumberPlate != null)
        {
            setClauses.Add("number_plate = @NumberPlate");
            parameters.Add("@NumberPlate", msg.NumberPlate);
            logger.LogInformation("[BookingUpdatedEvent] ✓ NumberPlate: {NumberPlate}", msg.NumberPlate);
        }

        if (msg.VehicleStatus != null)
        {
            setClauses.Add("vehicle_status = @VehicleStatus");
            parameters.Add("@VehicleStatus", msg.VehicleStatus);
            logger.LogInformation("[BookingUpdatedEvent] ✓ VehicleStatus: {VehicleStatus}", msg.VehicleStatus);
        }

        if (msg.Status.HasValue)
        {
            setClauses.Add("status = @Status");
            parameters.Add("@Status", msg.Status.Value.ToString());
            logger.LogInformation("[BookingUpdatedEvent] ✓ Status: {Status}", msg.Status.Value);
        }

        if (msg.ActualEndDate.HasValue)
        {
            setClauses.Add("actual_end_date = @ActualEndDate");
            parameters.Add("@ActualEndDate", msg.ActualEndDate.Value);
            logger.LogInformation("[BookingUpdatedEvent] ✓ ActualEndDate: {ActualEndDate}", msg.ActualEndDate.Value);
        }

        if (msg.FuelLevelEnd.HasValue)
        {
            setClauses.Add("fuel_level_end = @FuelLevelEnd");
            parameters.Add("@FuelLevelEnd", msg.FuelLevelEnd.Value);
            logger.LogInformation("[BookingUpdatedEvent] ✓ FuelLevelEnd: {FuelLevelEnd}", msg.FuelLevelEnd.Value);
        }

        if (msg.FuelLevelStart.HasValue)
        {
            setClauses.Add("fuel_level_start = @FuelLevelStart");
            parameters.Add("@FuelLevelStart", msg.FuelLevelStart.Value);
            logger.LogInformation("[BookingUpdatedEvent] ✓ FuelLevelStart: {FuelLevelStart}", msg.FuelLevelStart.Value);
        }

        if (msg.FuelPrice.HasValue)
        {
            setClauses.Add("fuel_price = @FuelPrice");
            parameters.Add("@FuelPrice", msg.FuelPrice.Value);
            logger.LogInformation("[BookingUpdatedEvent] ✓ FuelPrice: {FuelPrice}", msg.FuelPrice.Value);
        }

        if (msg.ConditionNotes != null)
        {
            setClauses.Add("condition_notes = @ConditionNotes");
            parameters.Add("@ConditionNotes", msg.ConditionNotes);
            logger.LogInformation("[BookingUpdatedEvent] ✓ ConditionNotes: {ConditionNotes}", msg.ConditionNotes);
        }

        if (msg.Description != null)
        {
            setClauses.Add("description = @Description");
            parameters.Add("@Description", msg.Description);
            logger.LogInformation("[BookingUpdatedEvent] ✓ Description: {Description}", msg.Description);
        }

        if (msg.SwapReason != null)
        {
            setClauses.Add("swap_reason = @SwapReason");
            parameters.Add("@SwapReason", msg.SwapReason);
            logger.LogInformation("[BookingUpdatedEvent] ✓ SwapReason: {SwapReason}", msg.SwapReason);
        }

        if (msg.CancellationReason != null)
        {
            setClauses.Add("cancellation_reason = @CancellationReason");
            parameters.Add("@CancellationReason", msg.CancellationReason);
            logger.LogInformation("[BookingUpdatedEvent] ✓ CancellationReason: {CancellationReason}", msg.CancellationReason);
        }

        if (msg.BookingImagesJson != null)
        {
            setClauses.Add("booking_images_json = @BookingImagesJson");
            parameters.Add("@BookingImagesJson", msg.BookingImagesJson);
            logger.LogInformation("[BookingUpdatedEvent] ✓ BookingImagesJson: {BookingImagesJson}", msg.BookingImagesJson);
        }

        if (msg.BookingViolationsJson != null)
        {
            setClauses.Add("booking_violations_json = @BookingViolationsJson");
            parameters.Add("@BookingViolationsJson", msg.BookingViolationsJson);
            logger.LogInformation("[BookingUpdatedEvent] ✓ BookingViolationsJson: {BookingViolationsJson}", msg.BookingViolationsJson);
        }

        if (msg.ReturnImagesJson != null)
        {
            setClauses.Add("return_images_json = @ReturnImagesJson");
            parameters.Add("@ReturnImagesJson", msg.ReturnImagesJson);
            logger.LogInformation("[BookingUpdatedEvent] ✓ ReturnImagesJson: {ReturnImagesJson}", msg.ReturnImagesJson);
        }

        if (msg.FileName != null)
        {
            setClauses.Add("file_name = @FileName");
            parameters.Add("@FileName", msg.FileName);
            logger.LogInformation("[BookingUpdatedEvent] ✓ FileName: {FileName}", msg.FileName);
        }

        setClauses.Add("updated_at = @UpdatedAt");
        setClauses.Add("updated_by = @UpdatedBy");

        if (setClauses.Count == 2)
        {
            logger.LogWarning("[BookingUpdatedEvent] ⚠ No fields to update for booking_read_flat with ID: {Id}", msg.Id);
            logger.LogWarning("[BookingUpdatedEvent] ========== UPDATE SKIPPED ==========");
            return;
        }

        logger.LogInformation("[BookingUpdatedEvent] Total fields to update: {Count}", setClauses.Count);

        var sql = $@"
            UPDATE booking_read_flat
            SET {string.Join(", ", setClauses)}
            WHERE booking_id_src = @Id
        ";

        logger.LogInformation("[BookingUpdatedEvent] Executing SQL Query...");
        logger.LogDebug("[BookingUpdatedEvent] SQL: {Sql}", sql);
        logger.LogDebug("[BookingUpdatedEvent] Parameters: {@Parameters}", parameters);

        await dapperRepository.ExecuteAsync(sql, parameters);

        logger.LogInformation("[BookingUpdatedEvent] ✅ Successfully updated booking_read_flat");
        logger.LogInformation("[BookingUpdatedEvent] Record ID: {Id}", msg.Id);
        logger.LogInformation("[BookingUpdatedEvent] Updated At: {UpdatedAt}", msg.UpdatedAt);
        logger.LogInformation("[BookingUpdatedEvent] Updated By: {UpdatedBy}", msg.UpdatedBy);
        logger.LogInformation("[BookingUpdatedEvent] ========== UPDATE COMPLETED ==========");
    }
}
