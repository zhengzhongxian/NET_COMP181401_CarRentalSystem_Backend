using NET_CarRentalSystem.Application.Models.Search;
using NET_CarRentalSystem.Shared.Utilities;
using NRedisStack.Search;

namespace NET_CarRentalSystem.Infrastructure.Services.Search;

/// <summary>
/// Static helper methods for VehicleSearchService
/// </summary>
public partial class VehicleSearchService
{
    private static string EscapeSearchTerm(string term)
    {
        var specialChars = new[] { '@', '!', '{', '}', '(', ')', '|', '-', '=', '>', '[', ']', ':', ';', '*', '"', '\'', '~', '&', '/', '\\', '%', '$', '#', '^' };
        return specialChars.Aggregate(term, (current, c) => current.Replace(c.ToString(), $"\\{c}"));
    }

    private static VehicleSearchDocument MapToDocument(Document doc)
    {
        return new VehicleSearchDocument
        {
            VehicleId = ParseGuid(doc, "vehicleId") ?? Guid.Empty,
            Manufacturer = GetString(doc, "manufacturer"),
            Model = GetString(doc, "model"),
            Color = GetString(doc, "color"),
            Description = GetString(doc, "description"),
            CategoryName = GetString(doc, "categoryName"),
            FuelName = GetString(doc, "fuelName"),
            TransmissionName = GetString(doc, "transmissionName"),
            AttributesJson = GetString(doc, "attributesJson"),
            PricePerHour = ParseDecimal(doc, "pricePerHour"),
            Rating = ParseFloat(doc, "rating"),
            AvailableCount = ParseInt(doc, "availableCount"),
            Thumbnail = GetString(doc, "thumbnail"),
            VehicleCategoryId = ParseGuid(doc, "vehicleCategoryId"),
            FuelId = ParseGuid(doc, "fuelId"),
            TransmissionId = ParseGuid(doc, "transmissionId"),
            VehicleModelsJson = GetString(doc, "vehicleModelsJson"),
            ImagesJson = GetString(doc, "imagesJson"),
            Metadata = GetString(doc, "metadata"),
            IsDeleted = GetString(doc, "isDeleted") == "1",
            UpdatedAt = ParseDateTime(doc, "updatedAt"),
            CreatedAt = ParseDateTime(doc, "createdAt")
        };
    }

    private static string GetString(Document doc, string key) 
        => doc[key].IsNull ? string.Empty : doc[key].ToString();
    
    private static Guid? ParseGuid(Document doc, string key)
    {
        var val = doc[key];
        return !val.IsNull && Guid.TryParse(val.ToString(), out var g) ? g : null;
    }
    
    private static decimal ParseDecimal(Document doc, string key)
    {
        var val = doc[key];
        return !val.IsNull && decimal.TryParse(val.ToString(), out var d) ? d : 0;
    }
    
    private static float ParseFloat(Document doc, string key)
    {
        var val = doc[key];
        return !val.IsNull && float.TryParse(val.ToString(), out var f) ? f : 0;
    }
    
    private static int ParseInt(Document doc, string key)
    {
        var val = doc[key];
        return !val.IsNull && int.TryParse(val.ToString(), out var i) ? i : 0;
    }
    
    private static DateTime ParseDateTime(Document doc, string key)
    {
        var val = doc[key];
        return !val.IsNull && long.TryParse(val.ToString(), out var ticks) ? new DateTime(ticks) : DateTime.MinValue;
    }
    
    private static List<Guid> ExtractLocationIds(string? vehicleModelsJson)
    {
        return vehicleModelsJson.ParseJsonArray(element =>
        {
            var locationIdStr = element.GetStringProperty("LocationId");
            var success = Guid.TryParse(locationIdStr, out var locationId);
            return (success, locationId);
        });
    }
    
    private static List<string> ExtractAttributeValues(string? attributesJson)
    {
        return attributesJson.ParseJsonArray(element =>
        {
            var value = element.GetStringProperty("AttributeValue");
            var success = !string.IsNullOrWhiteSpace(value);
            return (success, value ?? string.Empty);
        });
    }
    
    private static string GetSortField(string? sortBy)
    {
        return sortBy?.ToLower() switch
        {
            "price" => "pricePerHour",
            "name" => "model",
            "date" or "updated" => "updatedAt",
            "created" => "createdAt",
            "rating" => "rating",
            _ => "updatedAt"
        };
    }
}
