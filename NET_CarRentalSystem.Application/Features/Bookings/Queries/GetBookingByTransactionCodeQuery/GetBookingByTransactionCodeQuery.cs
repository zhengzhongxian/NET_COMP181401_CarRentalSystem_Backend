using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.BookingDTOs.Get;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Bookings.Queries.GetBookingByTransactionCodeQuery;

public class GetBookingByTransactionCodeQuery : IQuery<GetBookingByTransactionCodeDto?>
{
    public required long TransactionCode { get; set; }
}

public class GetBookingByTransactionCodeQueryHandler(IDapperRepository dapperRepository) 
    : IRequestHandler<GetBookingByTransactionCodeQuery, GetBookingByTransactionCodeDto?>
{
    public async Task<GetBookingByTransactionCodeDto?> Handle(
        GetBookingByTransactionCodeQuery request, 
        CancellationToken cancellationToken)
    {
        const string sql = """
            SELECT TOP 1
                b.booking_id_src AS BookingId,
                pt.transaction_code AS TransactionCode,
                b.customer_id AS CustomerId,
                b.customer_name AS CustomerName,
                b.customer_email AS CustomerEmail,
                b.vehicle_id AS VehicleId,
                b.vehicle_model_id AS VehicleModelId,
                b.number_plate AS NumberPlate,
                b.pickup_location_name AS PickupLocationName,
                b.return_location_name AS ReturnLocationName,
                b.status AS Status,
                b.start_date AS StartDate,
                b.end_date AS EndDate,
                b.total_price AS TotalPrice,
                pt.amount AS Amount,
                pt.payment_method AS PaymentMethod,
                pt.status AS TransactionStatus,
                pt.payment_date AS PaymentDate
            FROM payment_transactions pt
            INNER JOIN booking_read_flat b ON pt.booking_id = b.booking_id_src
            WHERE pt.transaction_code = @TransactionCode
                AND b.is_deleted = 0
                AND pt.is_deleted = 0
            ORDER BY pt.payment_date DESC
            """;

        var result = await dapperRepository.QueryFirstOrDefaultAsync<GetBookingByTransactionCodeDto>(
            sql,
            new { request.TransactionCode },
            cancellationToken: cancellationToken);

        return result;
    }
}

