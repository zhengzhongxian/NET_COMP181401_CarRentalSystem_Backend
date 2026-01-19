namespace NET_CarRentalSystem.Application.Models.Search;

/// <summary>
/// Phase 5.1: Faceted search aggregation results
/// Contains counts grouped by various attributes
/// </summary>
public class SearchFacets
{
    /// <summary>
    /// Category counts: { CategoryName: Count }
    /// </summary>
    public List<FacetItem> Categories { get; set; } = [];
    
    /// <summary>
    /// Fuel type counts: { FuelName: Count }
    /// </summary>
    public List<FacetItem> FuelTypes { get; set; } = [];
    
    /// <summary>
    /// Transmission counts: { TransmissionName: Count }
    /// </summary>
    public List<FacetItem> Transmissions { get; set; } = [];
    
    /// <summary>
    /// Price range distribution
    /// </summary>
    public List<PriceRangeFacet> PriceRanges { get; set; } = [];
    
    /// <summary>
    /// Statistics about the search results
    /// </summary>
    public SearchStats Stats { get; set; } = new();
}

public class FacetItem
{
    public string Name { get; set; } = string.Empty;
    public Guid? Id { get; set; }
    public int Count { get; set; }
}

public class PriceRangeFacet
{
    public string Label { get; set; } = string.Empty; // e.g., "0-500k", "500k-1M"
    public decimal MinPrice { get; set; }
    public decimal MaxPrice { get; set; }
    public int Count { get; set; }
}

public class SearchStats
{
    public int TotalVehicles { get; set; }
    public int AvailableVehicles { get; set; }
    public decimal MinPrice { get; set; }
    public decimal MaxPrice { get; set; }
    public decimal AvgPrice { get; set; }
    public float AvgRating { get; set; }
}
