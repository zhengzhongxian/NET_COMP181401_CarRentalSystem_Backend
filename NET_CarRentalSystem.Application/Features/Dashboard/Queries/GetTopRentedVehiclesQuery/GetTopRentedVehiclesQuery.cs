using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Dashboard.Queries.GetTopRentedVehiclesQuery;

public class GetTopRentedVehiclesQuery : IQuery<List<TopRentedVehicleDto>>
{
    public int Top { get; set; } = 5;
}

public class GetTopRentedVehiclesQueryHandler(IDapperRepository dapperRepository)
    : IRequestHandler<GetTopRentedVehiclesQuery, List<TopRentedVehicleDto>>
{
    public async Task<List<TopRentedVehicleDto>> Handle(
        GetTopRentedVehiclesQuery request, 
        CancellationToken cancellationToken)
    {
        var sql = $"""
            SELECT TOP (@Top)
                v.vehicle_id AS VehicleId,
                v.manufacturer AS Manufacturer,
                v.model AS Model,
                v.thumbnail AS Thumbnail,
                v.category_name AS CategoryName,
                v.price_per_hour AS PricePerHour,
                v.rating AS Rating,
                COUNT(b.booking_id) AS BookingCount
            FROM vehicle_read_flat v
            INNER JOIN booking_read_flat b ON v.vehicle_id = b.vehicle_id
            WHERE b.status IN ('{nameof(BookingStatus.InProgress)}', '{nameof(BookingStatus.Completed)}', '{nameof(BookingStatus.Returned)}')
            GROUP BY v.vehicle_id, v.manufacturer, v.model, v.thumbnail, 
                     v.category_name, v.price_per_hour, v.rating
            ORDER BY BookingCount DESC
            """;

        var result = await dapperRepository.QueryAsync<TopRentedVehicleDto>(
            sql,
            new { request.Top },
            cancellationToken: cancellationToken);

        return result.ToList();
    }
}
