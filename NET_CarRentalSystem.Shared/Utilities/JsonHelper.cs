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
}