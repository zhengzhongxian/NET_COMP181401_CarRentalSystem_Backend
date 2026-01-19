using System.Text.Json;
using System.Text.Json.Serialization;

namespace NET_CarRentalSystem.Shared.Utilities;

public static class JsonHelper
{
    /// <summary>
    /// Cấu hình các tùy chọn serialize/deserialize một cách nhất quán trong toàn bộ ứng dụng.
    /// </summary>
    private static readonly JsonSerializerOptions Options = new()
    {
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
    };

    /// <summary>
    /// Chuyển một đối tượng sang chuỗi JSON (Serialize).
    /// </summary>
    /// <typeparam name="T">Kiểu của đối tượng.</typeparam>
    /// <param name="value">Đối tượng cần chuyển đổi.</param>
    /// <returns>Chuỗi JSON tương ứng.</returns>
    public static string ToJson<T>(this T value) => JsonSerializer.Serialize(value, Options);

    /// <summary>
    /// Chuyển một chuỗi JSON sang một đối tượng (Deserialize).
    /// </summary>
    /// <typeparam name="T">Kiểu của đối tượng cần chuyển đến.</typeparam>
    /// <param name="json">Chuỗi JSON cần chuyển đổi.</param>
    /// <returns>Một đối tượng kiểu T hoặc null nếu chuỗi không hợp lệ.</returns>
    public static T? FromJson<T>(this string json) => JsonSerializer.Deserialize<T>(json, Options);
    
    /// <summary>
    /// Safely parse a JSON array and extract values using a callback.
    /// Returns empty list if JSON is null, empty, or invalid.
    /// Use extractor that returns (true, value) for valid values, (false, default) for invalid.
    /// </summary>
    /// <typeparam name="T">Type of extracted value</typeparam>
    /// <param name="json">JSON array string</param>
    /// <param name="extractor">Function that returns (success, value) tuple</param>
    /// <returns>List of extracted values</returns>
    public static List<T> ParseJsonArray<T>(this string? json, Func<JsonElement, (bool Success, T Value)> extractor)
    {
        if (string.IsNullOrWhiteSpace(json))
            return [];

        try
        {
            using var doc = JsonDocument.Parse(json);
            var results = new List<T>();
            
            foreach (var element in doc.RootElement.EnumerateArray())
            {
                var (success, value) = extractor(element);
                if (success)
                {
                    results.Add(value);
                }
            }
            
            return results.Distinct().ToList();
        }
        catch
        {
            return [];
        }
    }
    
    /// <summary>
    /// Try to get a string property value from a JsonElement.
    /// Supports both PascalCase and camelCase property names.
    /// </summary>
    public static string? GetStringProperty(this JsonElement element, string propertyName)
    {
        if (element.TryGetProperty(propertyName, out var prop) ||
            element.TryGetProperty(char.ToLowerInvariant(propertyName[0]) + propertyName[1..], out prop))
        {
            return prop.GetString();
        }
        return null;
    }
}