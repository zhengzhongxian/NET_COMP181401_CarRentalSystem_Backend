using MediatR;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Ai;
using NET_CarRentalSystem.Application.Interfaces.Services.Search;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleDTOs.Get;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehiclesPagedQuery;

public class GetVehiclesPagedQuery : IQuery<PagedList<GetVehicleDto>>
{
    public required GetVehiclesPagedQueryParams RequestParams { get; set; }
}

public class GetVehiclesPagedQueryHandler(
    IDapperRepository dapperRepository,
    IAiTextEmbeddingService embeddingService,
    IVehicleSearchService vehicleSearchService,
    ILogger<GetVehiclesPagedQueryHandler> logger) : IRequestHandler<GetVehiclesPagedQuery, PagedList<GetVehicleDto>>
{
    public async Task<PagedList<GetVehicleDto>> Handle(GetVehiclesPagedQuery request, CancellationToken cancellationToken)
    {
        var query = request.RequestParams;

        if (!string.IsNullOrWhiteSpace(query.SearchKeyword))
        {
            logger.LogInformation(
                "Vehicle search request received. Keyword='{Keyword}', UseHybridSearch={UseHybridSearch}, Page={PageNumber}, Size={PageSize}",
                query.SearchKeyword,
                query.UseHybridSearch,
                query.PageNumber,
                query.PageSize);
        }

        // Try hybrid search when keyword is present AND UseHybridSearch is enabled (client-side search)
        if (query.UseHybridSearch && !string.IsNullOrWhiteSpace(query.SearchKeyword))
        {
            var hybridResult = await TryHybridSearchAsync(query, cancellationToken);
            if (hybridResult != null)
                return hybridResult;
            
            // Fallback to SQL LIKE if hybrid search failed
            logger.LogInformation("Hybrid search unavailable, falling back to SQL LIKE");
        }

        return await SearchWithSqlServerAsync(query, cancellationToken);
    }

    /// <summary>
    /// Hybrid search: embed keyword → Redis KNN → SQL by IDs.
    /// Returns null if AI/Redis is unavailable so caller can fallback.
    /// </summary>
    private async Task<PagedList<GetVehicleDto>?> TryHybridSearchAsync(
        GetVehiclesPagedQueryParams query,
        CancellationToken cancellationToken)
    {
        try
        {
            var embedding = await embeddingService.GetEmbeddingAsync(query.SearchKeyword!.Trim(), cancellationToken);
            if (embedding == null)
                return null;

            // Get top candidates from Redis (fetch more than page size for filtering)
            var topK = Math.Max(query.PageSize * 3, 60);
            var searchResults = await vehicleSearchService.HybridSearchAsync(
                embedding, query.SearchKeyword!.Trim(), topK, cancellationToken);

            if (searchResults.Count == 0)
                return null;

            var vehicleIds = searchResults.Select(r => r.VehicleId).ToList();

            // Build SQL query with vehicleId filter + existing filters
            var parameters = new Dictionary<string, object>();
            var whereConditions = new List<string> { "is_deleted = 0" };

            // IN clause for vehicle IDs from Redis
            var idParams = new List<string>();
            for (var i = 0; i < vehicleIds.Count; i++)
            {
                var paramName = $"VId{i}";
                idParams.Add($"@{paramName}");
                parameters[paramName] = vehicleIds[i];
            }
            whereConditions.Add($"vehicle_id IN ({string.Join(",", idParams)})");

            // Add remaining SQL filters (price, category, fuel, etc.)
            AddCommonFilters(query, whereConditions, parameters);

            var whereClause = string.Join(" AND ", whereConditions);

            // Count total matches
            var countSql = $"SELECT COUNT(*) FROM vehicle_read_flat WHERE {whereClause}";
            var totalCount = await dapperRepository.ExecuteScalarAsync<int>(countSql, parameters, cancellationToken: cancellationToken);

            if (totalCount == 0)
                return null; // Fallback to SQL LIKE

            // Build ORDER BY using Redis relevance score
            var scoreOrderCases = new List<string>();
            for (var i = 0; i < vehicleIds.Count; i++)
            {
                scoreOrderCases.Add($"WHEN @VId{i} THEN {i}");
            }
            var orderByClause = $"ORDER BY CASE vehicle_id {string.Join(" ", scoreOrderCases)} ELSE {vehicleIds.Count} END";

            var offset = (query.PageNumber - 1) * query.PageSize;
            parameters["Offset"] = offset;
            parameters["PageSize"] = query.PageSize;

            var dataSql = $"""

                               SELECT
                                   vehicle_id as VehicleId,
                                   manufacturer as Manufacturer,
                                   model as Model,
                                   title as Title,
                                   color as Color,
                                   price_per_hour as PricePerHour,
                                   thumbnail as Thumbnail,
                                   rating as Rating,
                                   available_count as AvailableCount,
                                   vehicle_category_id as VehicleCategoryId,
                                   category_name as VehicleCategoryCode,
                                   fuel_id as FuelId,
                                   fuel_name as FuelName,
                                   transmission_id as TransmissionId,
                                   transmission_name as TransmissionName,
                                   required_license_class as RequiredLicenseClass
                               FROM vehicle_read_flat
                               WHERE {whereClause}
                               {orderByClause}
                               OFFSET @Offset ROWS
                               FETCH NEXT @PageSize ROWS ONLY
                """;

            var vehicles = await dapperRepository.QueryAsync<GetVehicleDto>(dataSql, parameters, cancellationToken: cancellationToken);

            logger.LogInformation("Hybrid search returned {Count}/{Total} results for '{Keyword}'",
                vehicles.Count, totalCount, query.SearchKeyword);

            return new PagedList<GetVehicleDto>(
                vehicles.ToList(),
                totalCount,
                query.PageNumber,
                query.PageSize);
        }
        catch (Exception ex)
        {
            logger.LogWarning(ex, "Hybrid search failed, will fallback to SQL LIKE");
            return null;
        }
    }
    
    private async Task<PagedList<GetVehicleDto>> SearchWithSqlServerAsync(
        GetVehiclesPagedQueryParams query,
        CancellationToken cancellationToken)
    {
        var parameters = new Dictionary<string, object>();
        var whereConditions = new List<string> { "is_deleted = 0" };
        
        if (!string.IsNullOrWhiteSpace(query.SearchKeyword))
        {
            var keyword = $"%{query.SearchKeyword.Trim()}%";
            
            whereConditions.Add(@"(
                manufacturer LIKE @Keyword OR 
                model LIKE @Keyword OR 
                title LIKE @Keyword OR
                color LIKE @Keyword OR
                description LIKE @Keyword OR
                category_name LIKE @Keyword OR
                fuel_name LIKE @Keyword OR
                transmission_name LIKE @Keyword
            )");
            
            parameters["Keyword"] = keyword;
        }

        AddCommonFilters(query, whereConditions, parameters);

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
                               vehicle_id as VehicleId,
                               manufacturer as Manufacturer,
                               model as Model,
                               title as Title,
                               color as Color,
                               price_per_hour as PricePerHour,
                               thumbnail as Thumbnail,
                               rating as Rating,
                               available_count as AvailableCount,
                               vehicle_category_id as VehicleCategoryId,
                               category_name as VehicleCategoryCode,
                               fuel_id as FuelId,
                               fuel_name as FuelName,
                               transmission_id as TransmissionId,
                               transmission_name as TransmissionName,
                               required_license_class as RequiredLicenseClass
                           FROM vehicle_read_flat
                           WHERE {whereClause}
                           {orderByClause}
                           OFFSET @Offset ROWS
                           FETCH NEXT @PageSize ROWS ONLY
                """;

        var vehicles = await dapperRepository.QueryAsync<GetVehicleDto>(dataSql, parameters, cancellationToken: cancellationToken);

        logger.LogInformation("SQL search returned {Count} results", vehicles.Count);

        return new PagedList<GetVehicleDto>(
            vehicles.ToList(),
            totalCount,
            query.PageNumber,
            query.PageSize);
    }

    /// <summary>
    /// Add shared SQL filter conditions (price, category, fuel, location, attributes, status).
    /// </summary>
    private static void AddCommonFilters(
        GetVehiclesPagedQueryParams query,
        List<string> whereConditions,
        Dictionary<string, object> parameters)
    {
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
            whereConditions.Add(@"EXISTS (
                SELECT 1 FROM vehicle_models vm 
                WHERE vm.vehicle_id = vehicle_read_flat.vehicle_id 
                AND vm.location_id = @LocationId
            )");
            parameters["LocationId"] = query.LocationId.Value;
        }
        
        if (query.AttributeKeywords is { Count: > 0 })
        {
            for (var i = 0; i < query.AttributeKeywords.Count; i++)
            {
                var attrParamName = $"@Attr{i}";
                whereConditions.Add($"attributes_json LIKE {attrParamName}");
                parameters[$"Attr{i}"] = $"%{query.AttributeKeywords[i]}%";
            }
        }

        if (!string.IsNullOrWhiteSpace(query.Status))
        {
            whereConditions.Add("status = @Status");
            parameters["Status"] = query.Status;
        }
    }
}
