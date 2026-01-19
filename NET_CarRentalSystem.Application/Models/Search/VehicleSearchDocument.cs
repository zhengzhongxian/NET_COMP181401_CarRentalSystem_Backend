using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.Application.Models.Search;

public class VehicleSearchDocument
{
    public Guid VehicleId { get; set; }

    public string Manufacturer { get; set; } = string.Empty;

    public string Model { get; set; } = string.Empty;

    public string? Color { get; set; }

    public decimal PricePerHour { get; set; }

    public string? Thumbnail { get; set; }

    public string? Description { get; set; }

    public float Rating { get; set; }

    public int AvailableCount { get; set; }

    public Guid? VehicleCategoryId { get; set; }

    public string? CategoryName { get; set; }

    public Guid? FuelId { get; set; }

    public string? FuelName { get; set; }

    public Guid? TransmissionId { get; set; }

    public string? TransmissionName { get; set; }

    public string? VehicleModelsJson { get; set; }
    
    public string? AttributesJson { get; set; }

    public string? Metadata { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime CreatedAt { get; set; }
    
    public List<Guid> LocationIds { get; set; } = [];
    
    public List<string> AttributeValues { get; set; } = [];
    
    public string? ImagesJson { get; set; }
}

public class VehicleSearchResult
{
    public List<VehicleSearchDocument> Items { get; set; } = [];
    
    public int TotalCount { get; set; }
}

public class VehicleSearchParams : PagedRequest
{
    public Guid? CategoryId { get; set; }
    
    public Guid? FuelId { get; set; }
    
    public Guid? LocationId { get; set; }
    
    public decimal? MinPrice { get; set; }
    
    public decimal? MaxPrice { get; set; }
    
    public string? Status { get; set; }
    
    public List<string>? AttributeKeywords { get; set; }
    
    public List<string>? ExcludeAttributeKeywords { get; set; }

    public bool UseVectorSearch { get; set; } = false;
    
    public bool UseTwoStageSearch { get; set; } = false;
}