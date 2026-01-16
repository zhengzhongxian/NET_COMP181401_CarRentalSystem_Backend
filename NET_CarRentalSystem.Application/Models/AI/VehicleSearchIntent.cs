namespace NET_CarRentalSystem.Application.Models.AI;

public class VehicleSearchIntent
{
    // New fields matching updated prompt
    public string? CategoryCode { get; set; }  // SEDAN, SUV, HATCHBACK, MINIVAN
    
    public string? FuelType { get; set; }  // Gasoline, Diesel, Electric
    
    public string? TransmissionCode { get; set; }  // AT, MT
    
    public string? LocationCity { get; set; }  // Hồ Chí Minh, Hà Nội, etc.
    
    public List<string>? AttributeKeywords { get; set; }  // GPS, túi khí, camera, etc.
    
    public List<string>? ExcludeAttributeKeywords { get; set; }  // Attributes to exclude (negation)
    
    // Legacy field for backward compatibility
    public string? CategoryKeyword { get; set; }
    
    public string? LocationName { get; set; }
    
    public decimal? MinPrice { get; set; }
    
    public decimal? MaxPrice { get; set; }
    
    public string? SortBy { get; set; }
    
    public string? SortDirection { get; set; }
    
    public string? ParsedIntent { get; set; }
    
    public string OriginalQuery { get; set; } = string.Empty;
}

public class AiEnhancedQueryParams
{
    public Guid? CategoryId { get; set; }

    public Guid? FuelId { get; set; }

    public Guid? LocationId { get; set; }

    public decimal? MinPrice { get; set; }

    public decimal? MaxPrice { get; set; }
    
    public string? SortBy { get; set; }          // "Price", "Rating", "Name", "Date"

    public string? SortDirection { get; set; }   // "ASC" or "DESC"
    public string? Status { get; set; }
    
    public string FallbackKeyword { get; set; } = string.Empty;
    
    // For debugging/transparency
    public string ParsedIntent { get; set; } = string.Empty;
    
    public List<string>? AttributeKeywords { get; set; }
    
    public List<string>? ExcludeAttributeKeywords { get; set; }  // Attributes to exclude (negation)
}
