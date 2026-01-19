using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleDTOs.Get;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehicleDetailsQuery;

public class GetVehicleDetailsQuery : IQuery<GetVehicleDetailsDto?>
{
    public required Guid VehicleId { get; set; }
}

public class GetVehicleDetailsQueryHandler(
    IDapperRepository dapperRepository) : IRequestHandler<GetVehicleDetailsQuery, GetVehicleDetailsDto?>
{
    public async Task<GetVehicleDetailsDto?> Handle(GetVehicleDetailsQuery request, CancellationToken cancellationToken)
    {
        var sql = """

                              SELECT
                                  vehicle_id as VehicleId, 
                                  manufacturer as Manufacturer,
                                  model as Model, 
                                  price_per_hour as PricePerHour,
                                  rating as Rating, 
                                  color as Color,
                                  thumbnail as Thumbnail,
                                  available_count as AvailableCount,
                                  vehicle_category_id as VehicleCategoryId,
                                  fuel_id as FuelId,
                                  transmission_id as TransmissionId,
                                  category_name as VehicleCategoryCode,
                                  fuel_name as FuelName, 
                                  transmission_name as TransmissionName,
                                  vehicle_models_json as VehicleModelsJson,
                                  images_json as ImagesJson,
                                  attributes_json as AttributesJson,
                                  metadata as Metadata
                              FROM vehicle_read_flat
                              WHERE vehicle_id = @VehicleId AND is_deleted = 0
                  """;

        var parameters = new Dictionary<string, object> { { "VehicleId", request.VehicleId } };

        return await dapperRepository.QueryFirstOrDefaultAsync<GetVehicleDetailsDto>(
            sql, parameters, cancellationToken: cancellationToken);
    }
}