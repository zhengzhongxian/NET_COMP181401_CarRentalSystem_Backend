using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleDTOs.Get;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehiclesPagedQuery;

public class GetVehiclesPagedQuery : IQuery<PagedList<GetVehicleDto>>
{
    public required GetVehiclesPagedQueryParams RequestParams { get; set; }
}

public class GetVehiclesPagedQueryHandler(IDapperRepository dapperRepository) : IRequestHandler<GetVehiclesPagedQuery, PagedList<GetVehicleDto>>
{
    public async Task<PagedList<GetVehicleDto>> Handle(GetVehiclesPagedQuery request, CancellationToken cancellationToken)
    {
        var parameters = new Dictionary<string, object>();
        var query = request.RequestParams;
        
        var whereConditions = new List<string> { "is_deleted = 0" };
        
        if (!string.IsNullOrWhiteSpace(query.SearchKeyword))
        {
            var keyword = $"%{query.SearchKeyword.Trim()}%";
            
            whereConditions.Add("""

                                                (
                                                    number_plate LIKE @Keyword OR 
                                                    manufacturer LIKE @Keyword OR 
                                                    model LIKE @Keyword OR 
                                                    color LIKE @Keyword OR
                                                    location_name LIKE @Keyword OR
                                                    description LIKE @Keyword
                                                )
                                """);
            
            parameters["Keyword"] = keyword;
        }

        if (query.MinPrice.HasValue)
        {
            whereConditions.Add("price_per_hour >= @MinPrice");
            parameters["MinPrice"] = query.MinPrice.Value;
        }

        if (query.MaxPrice.HasValue)
        {
            whereConditions.Add("price_per_hour <= @MaxPrice");
            parameters["MaxPrice"] = query.MaxPrice.Value;
        }
        
        if (query.CategoryId.HasValue)
        {
            whereConditions.Add("vehicle_category_id = @CategoryId");
            parameters["CategoryId"] = query.CategoryId.Value;
        }

        if (query.FuelId.HasValue)
        {
            whereConditions.Add("fuel_id = @FuelId");
            parameters["FuelId"] = query.FuelId.Value;
        }

        if (query.LocationId.HasValue)
        {
            whereConditions.Add("location_id = @LocationId");
            parameters["LocationId"] = query.LocationId.Value;
        }

        if (!string.IsNullOrWhiteSpace(query.Status))
        {
            whereConditions.Add("status = @Status");
            parameters["Status"] = query.Status;
        }
        
        var whereClause = string.Join(" AND ", whereConditions);
        
        var allowedSortColumns = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "Price", "price_per_hour" },
            { "Name", "model" },
            { "Date", "updated_at" },     
            { "Created", "created_at" },  
            { "Updated", "updated_at" },  
            { "Rating", "rating" }
        };

        var sortBy = "updated_at"; 
        
        if (!string.IsNullOrEmpty(query.SortBy) && allowedSortColumns.TryGetValue(query.SortBy, out var column))
        {
            sortBy = column;
        }
        
        var sortDirection = query.SortDirection?.ToLower() == "asc" ? "ASC" : "DESC";
        var orderByClause = $"ORDER BY {sortBy} {sortDirection}";
        
        var offset = (query.PageNumber - 1) * query.PageSize;
        parameters["Offset"] = offset;
        parameters["PageSize"] = query.PageSize;
        
        var countSql = $"SELECT COUNT(*) FROM vehicle_read_flat WHERE {whereClause}";
        var totalCount = await dapperRepository.ExecuteScalarAsync<int>(countSql, parameters, cancellationToken: cancellationToken);
        
        var dataSql = $"""

                                   SELECT
                                       vehicle_id as VehicleId, number_plate as NumberPlate, manufacturer as Manufacturer,
                                       model as Model, color as Color, mileage as Mileage,
                                       price_per_hour as PricePerHour, thumbnail as Thumbnail, last_checkout_at as LastCheckoutAt,
                                       rating as Rating, status as Status, condition_notes as ConditionNotes,
                                       real_time_location as RealTimeLocation, location_id as LocationId, location_name as LocationName,
                                       vehicle_category_id as VehicleCategoryId, category_name as VehicleCategoryCode,
                                       fuel_id as FuelId, fuel_name as FuelName,
                                       transmission_id as TransmissionId, transmission_name as TransmissionName
                                   FROM vehicle_read_flat
                                   WHERE {whereClause}
                                   {orderByClause}
                                   OFFSET @Offset ROWS
                                   FETCH NEXT @PageSize ROWS ONLY
                       """;

        var vehicles = await dapperRepository.QueryAsync<GetVehicleDto>(dataSql, parameters, cancellationToken: cancellationToken);

        return new PagedList<GetVehicleDto>(
            vehicles.ToList(),
            totalCount,
            query.PageNumber,
            query.PageSize);
    }
}