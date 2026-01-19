using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Models.Search;
using NET_CarRentalSystem.Shared.CoreHelpers;
using NET_CarRentalSystem.Shared.Utilities;
using NRedisStack.Search;
using NRedisStack.Search.Aggregation;

namespace NET_CarRentalSystem.Infrastructure.Services.Search;

public partial class VehicleSearchService
{
    public async Task<SearchFacets> GetSearchFacetsAsync(VehicleSearchParams? searchParams = null, CancellationToken ct = default)
    {
        try
        {
            var baseQuery = "@isDeleted:[0 0]";
            
            if (searchParams != null)
            {
                if (!string.IsNullOrWhiteSpace(searchParams.SearchKeyword))
                {
                    var expandedTerms = SynonymHelper.ExpandPhraseWithSynonyms(searchParams.SearchKeyword);
                    var words = expandedTerms.Where(w => w.Length >= 2).Select(EscapeSearchTerm).ToList();
                    if (words.Count > 0)
                    {
                        var searchTerms = string.Join(" | ", words.Select(w => $"{w}*"));
                        baseQuery += $" ({searchTerms})";
                    }
                }
            }

            var facets = new SearchFacets
            {
                Categories = await AggregateByFieldAsync("categoryName", "vehicleCategoryId", baseQuery),
                FuelTypes = await AggregateByFieldAsync("fuelName", "fuelId", baseQuery),
                Transmissions = await AggregateByFieldAsync("transmissionName", "transmissionId", baseQuery),
                Stats = await GetSearchStatsAsync(baseQuery)
            };
            
            facets.PriceRanges = CalculatePriceRanges(facets.Stats.MinPrice, facets.Stats.MaxPrice);
            
            _logger.LogDebug("Generated facets: {Categories} categories, {Fuels} fuels, {Trans} transmissions", 
                facets.Categories.Count, facets.FuelTypes.Count, facets.Transmissions.Count);
            
            return facets;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to get search facets");
            return new SearchFacets();
        }
    }
    
    private async Task<List<FacetItem>> AggregateByFieldAsync(string nameField, string idField, string query)
    {
        try
        {
            var aggregation = new AggregationRequest(query)
                .GroupBy($"@{nameField}", Reducers.Count().As("count"), Reducers.FirstValue($"@{idField}").As("id"))
                .SortBy(new SortedField("@count", SortedField.SortOrder.DESC))
                .Limit(0, 20);

            var result = await _ft.AggregateAsync(CacheKeyHelper.VehicleSearchIndexName, aggregation);
            
            var facets = new List<FacetItem>();
            
            for (var i = 0; i < result.TotalResults && i < 20; i++)
            {
                var row = result.GetRow(i);
                
                var name = row[nameField].ToString();
                if (string.IsNullOrEmpty(name)) continue;
                
                int.TryParse(row["count"].ToString(), out var count);
                
                Guid? id = null;
                var idStr = row["id"].ToString();
                if (Guid.TryParse(idStr, out var parsedId))
                    id = parsedId;
                    
                facets.Add(new FacetItem { Name = name, Id = id, Count = count });
            }
            
            return facets;
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Aggregation failed for field {Field}", nameField);
            return [];
        }
    }
    
    private async Task<SearchStats> GetSearchStatsAsync(string query)
    {
        try
        {
            var aggregation = new AggregationRequest(query)
                .Load(new FieldName("@availableCount"), new FieldName("@pricePerHour"), new FieldName("@rating"));

            var result = await _ft.AggregateAsync(CacheKeyHelper.VehicleSearchIndexName, aggregation);
            
            var stats = new SearchStats();
            var totalCount = 0;
            var totalAvailable = 0;
            var minPriceVal = decimal.MaxValue;
            var maxPriceVal = decimal.MinValue;
            var priceSum = 0m;
            var ratingSum = 0f;
            
            for (var i = 0; i < result.TotalResults; i++)
            {
                var row = result.GetRow(i);
                totalCount++;
                
                if (int.TryParse(row["availableCount"].ToString(), out var avail))
                    totalAvailable += avail;
                
                if (decimal.TryParse(row["pricePerHour"].ToString(), out var price))
                {
                    if (price < minPriceVal) minPriceVal = price;
                    if (price > maxPriceVal) maxPriceVal = price;
                    priceSum += price;
                }
                
                if (float.TryParse(row["rating"].ToString(), out var rating))
                    ratingSum += rating;
            }
            
            stats.TotalVehicles = totalCount;
            stats.AvailableVehicles = totalAvailable;
            stats.MinPrice = minPriceVal == decimal.MaxValue ? 0 : minPriceVal;
            stats.MaxPrice = maxPriceVal == decimal.MinValue ? 0 : maxPriceVal;
            stats.AvgPrice = totalCount > 0 ? priceSum / totalCount : 0;
            stats.AvgRating = totalCount > 0 ? ratingSum / totalCount : 0;
            
            return stats;
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Stats aggregation failed");
            return new SearchStats();
        }
    }
    
    private static List<PriceRangeFacet> CalculatePriceRanges(decimal minPrice, decimal maxPrice)
    {
        if (maxPrice <= 0) return [];
        
        var ranges = new List<PriceRangeFacet>();
        
        var breakpoints = new[] { 0m, 100000m, 300000m, 500000m, 1000000m, 2000000m, decimal.MaxValue };
        var labels = new[] { "0 - 100k", "100k - 300k", "300k - 500k", "500k - 1M", "1M - 2M", "Trên 2M" };
        
        for (var i = 0; i < breakpoints.Length - 1; i++)
        {
            if (breakpoints[i + 1] <= minPrice) continue;
            if (breakpoints[i] >= maxPrice) break;
            
            ranges.Add(new PriceRangeFacet
            {
                Label = labels[i],
                MinPrice = breakpoints[i],
                MaxPrice = breakpoints[i + 1] == decimal.MaxValue ? maxPrice : breakpoints[i + 1],
                Count = 0
            });
        }
        
        return ranges;
    }
}