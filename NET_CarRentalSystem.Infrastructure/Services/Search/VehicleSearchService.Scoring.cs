using NET_CarRentalSystem.Application.Models.Search;

namespace NET_CarRentalSystem.Infrastructure.Services.Search;

/// <summary>
/// Scoring and Caching related methods
/// </summary>
public partial class VehicleSearchService
{
    private static List<VehicleSearchDocument> ApplyBusinessScoring(List<VehicleSearchDocument> items)
    {
        if (items.Count == 0) return items;
        
        var maxAvailable = items.Max(x => x.AvailableCount);
        var maxRating = items.Max(x => x.Rating);
        
        const float availabilityWeight = 0.5f; 
        const float ratingWeight = 0.5f;     
        
        return items
            .Select(item =>
            {
                var availabilityScore = maxAvailable > 0 
                    ? (float)item.AvailableCount / maxAvailable 
                    : 0f;
                
                var ratingScore = maxRating > 0 
                    ? item.Rating / maxRating 
                    : 0f;
                
                var businessScore = (availabilityScore * availabilityWeight) + (ratingScore * ratingWeight);
                
                return new { Item = item, Score = businessScore };
            })
            .OrderByDescending(x => x.Score)
            .Select(x => x.Item)
            .ToList();
    }
    
    private static List<VehicleSearchDocument> ApplyUserSort(List<VehicleSearchDocument> items, string? sortBy, string? sortDirection)
    {
        if (string.IsNullOrEmpty(sortBy)) return items;
        
        var asc = sortDirection?.ToLower() == "asc";
        return sortBy.ToLower() switch
        {
            "price" => asc ? items.OrderBy(x => x.PricePerHour).ToList() : items.OrderByDescending(x => x.PricePerHour).ToList(),
            "rating" => asc ? items.OrderBy(x => x.Rating).ToList() : items.OrderByDescending(x => x.Rating).ToList(),
            "name" => asc ? items.OrderBy(x => x.Model).ToList() : items.OrderByDescending(x => x.Model).ToList(),
            _ => items
        };
    }
    
    private static string GetSearchCacheKey(VehicleSearchParams p)
    {
        var keyParts = new List<string>
        {
            p.SearchKeyword ?? "",
            p.CategoryId?.ToString() ?? "",
            p.FuelId?.ToString() ?? "",
            p.LocationId?.ToString() ?? "",
            p.MinPrice?.ToString("F0") ?? "",
            p.MaxPrice?.ToString("F0") ?? "",
            p.SortBy ?? "rating",
            p.SortDirection ?? "desc",
            p.PageNumber.ToString(),
            p.PageSize.ToString(),
            string.Join(",", p.AttributeKeywords ?? new List<string>())
        };
        var hash = string.Join("|", keyParts).GetHashCode();
        return $"search:cache:{hash}";
    }
}
