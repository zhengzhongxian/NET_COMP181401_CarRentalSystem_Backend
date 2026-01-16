using MediatR;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.AI;
using NET_CarRentalSystem.Application.Interfaces.Services.Search;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleDTOs.Get;
using NET_CarRentalSystem.Application.Models.Search;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehiclesPagedQuery;

public class GetVehiclesPagedQuery : IQuery<PagedList<GetVehicleDto>>
{
    public required GetVehiclesPagedQueryParams RequestParams { get; set; }
}

public class GetVehiclesPagedQueryHandler(
    IDapperRepository dapperRepository,
    IGeminiService geminiService,
    IVehicleSearchService vehicleSearchService,
    ILogger<GetVehiclesPagedQueryHandler> logger) : IRequestHandler<GetVehiclesPagedQuery, PagedList<GetVehicleDto>>
{
    public async Task<PagedList<GetVehicleDto>> Handle(GetVehiclesPagedQuery request, CancellationToken cancellationToken)
    {
        var query = request.RequestParams;
        
        if (query.UseAi && !string.IsNullOrWhiteSpace(query.SearchKeyword))
        {
            try
            {
                using var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
                cts.CancelAfter(TimeSpan.FromSeconds(15));
                
                var aiParams = await geminiService.ParseAndEnhanceVehicleQueryAsync(
                    query.SearchKeyword,
                    dapperRepository,
                    cts.Token);
                
                query.CategoryId ??= aiParams.CategoryId;
                query.FuelId ??= aiParams.FuelId;
                query.LocationId ??= aiParams.LocationId;
                query.MinPrice ??= aiParams.MinPrice;
                query.MaxPrice ??= aiParams.MaxPrice;
                query.SortBy ??= aiParams.SortBy;
                query.SortDirection ??= aiParams.SortDirection;
                query.AttributeKeywords ??= aiParams.AttributeKeywords;
                
                if (!string.IsNullOrEmpty(aiParams.FallbackKeyword))
                {
                    query.SearchKeyword = aiParams.FallbackKeyword;
                }
            }
            catch (Exception)
            {
                // AI service failed - continue with normal keyword search
                // Logging already done in GeminiService
            }
        }
        
        try
        {
            if (await vehicleSearchService.IsAvailableAsync(cancellationToken))
            {
                return await SearchWithRedisAsync(query, cancellationToken);
            }
        }
        catch (Exception ex)
        {
            logger.LogWarning(ex, "RediSearch failed, falling back to SQL Server");
        }
        
        // Fallback to SQL Server
        return await SearchWithSqlServerAsync(query, cancellationToken);
    }
    
    private async Task<PagedList<GetVehicleDto>> SearchWithRedisAsync(
        GetVehiclesPagedQueryParams query,
        CancellationToken cancellationToken)
    {
        var searchParams = new VehicleSearchParams
        {
            SearchKeyword = query.SearchKeyword,
            CategoryId = query.CategoryId,
            FuelId = query.FuelId,
            LocationId = query.LocationId,
            MinPrice = query.MinPrice,
            MaxPrice = query.MaxPrice,
            Status = query.Status,
            AttributeKeywords = query.AttributeKeywords,
            SortBy = query.SortBy,
            SortDirection = query.SortDirection,
            PageNumber = query.PageNumber,
            PageSize = query.PageSize
        };

        var result = await vehicleSearchService.SearchAsync(searchParams, cancellationToken);

        var vehicles = result.Items.Select(doc => new GetVehicleDto
        {
            VehicleId = doc.VehicleId,
            Manufacturer = doc.Manufacturer,
            Model = doc.Model,
            Color = doc.Color,
            PricePerHour = doc.PricePerHour,
            Thumbnail = doc.Thumbnail,
            Rating = doc.Rating,
            AvailableCount = doc.AvailableCount,
            VehicleCategoryId = doc.VehicleCategoryId,
            VehicleCategoryCode = doc.CategoryName,
            FuelId = doc.FuelId,
            FuelName = doc.FuelName,
            TransmissionId = doc.TransmissionId,
            TransmissionName = doc.TransmissionName
        }).ToList();

        logger.LogDebug("RediSearch returned {Count} results from {Total} total", vehicles.Count, result.TotalCount);

        return new PagedList<GetVehicleDto>(
            vehicles,
            result.TotalCount,
            query.PageNumber,
            query.PageSize);
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
                color LIKE @Keyword OR
                description LIKE @Keyword
            )");
            
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

        // Fix: Use EXISTS subquery for LocationId since it exists in vehicle_models, not vehicle_read_flat
        if (query.LocationId.HasValue)
        {
            whereConditions.Add(@"EXISTS (
                SELECT 1 FROM vehicle_models vm 
                WHERE vm.vehicle_id = vehicle_read_flat.vehicle_id 
                AND vm.location_id = @LocationId
            )");
            parameters["LocationId"] = query.LocationId.Value;
        }
        
        // Add support for Attribute search (keywords in JSON)
        if (query.AttributeKeywords != null && query.AttributeKeywords.Count > 0)
        {
            for (int i = 0; i < query.AttributeKeywords.Count; i++)
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
                                       transmission_name as TransmissionName
                                   FROM vehicle_read_flat
                                   WHERE {whereClause}
                                   {orderByClause}
                                   OFFSET @Offset ROWS
                                   FETCH NEXT @PageSize ROWS ONLY
                       """;

        var vehicles = await dapperRepository.QueryAsync<GetVehicleDto>(dataSql, parameters, cancellationToken: cancellationToken);

        logger.LogDebug("SQL Server fallback returned {Count} results", vehicles.Count());

        return new PagedList<GetVehicleDto>(
            vehicles.ToList(),
            totalCount,
            query.PageNumber,
            query.PageSize);
    }
}