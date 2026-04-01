using Microsoft.Extensions.Logging;
using NRedisStack;
using NRedisStack.RedisStackCommands;
using NRedisStack.Search;
using StackExchange.Redis;
using NET_CarRentalSystem.Application.Interfaces.Services.Search;

namespace NET_CarRentalSystem.Infrastructure.Services.Search;

public class VehicleSearchService : IVehicleSearchService
{
    private const string IndexName = "idx:vehicles";
    private const string KeyPrefix = "vehicle:search:";

    private readonly IDatabase _db;
    private readonly SearchCommands _searchCommands;
    private readonly ILogger<VehicleSearchService> _logger;

    public VehicleSearchService(
        IConnectionMultiplexer redis,
        ILogger<VehicleSearchService> logger)
    {
        _db = redis.GetDatabase();
        _searchCommands = _db.FT();
        _logger = logger;
    }

    public async Task IndexVehicleAsync(
        Guid vehicleId,
        string searchText,
        byte[] embedding,
        string? manufacturer,
        string? model,
        string? title,
        string? category,
        CancellationToken cancellationToken = default)
    {
        try
        {
            var key = $"{KeyPrefix}{vehicleId}";
            var hashEntries = new HashEntry[]
            {
                new("vehicle_id", vehicleId.ToString()),
                new("manufacturer", manufacturer ?? ""),
                new("model", model ?? ""),
                new("title", title ?? ""),
                new("category", category ?? ""),
                new("search_text", searchText),
                new("embedding", embedding)
            };

            await _db.HashSetAsync(key, hashEntries);
            _logger.LogDebug("Indexed vehicle {VehicleId} for search", vehicleId);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to index vehicle {VehicleId}", vehicleId);
        }
    }

    public async Task RemoveVehicleAsync(Guid vehicleId, CancellationToken cancellationToken = default)
    {
        try
        {
            var key = $"{KeyPrefix}{vehicleId}";
            await _db.KeyDeleteAsync(key);
            _logger.LogDebug("Removed vehicle {VehicleId} from search index", vehicleId);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to remove vehicle {VehicleId} from search index", vehicleId);
        }
    }

    public async Task<List<(Guid VehicleId, double Score)>> HybridSearchAsync(
        byte[] queryVector,
        string? keyword,
        int topK = 20,
        CancellationToken cancellationToken = default)
    {
        try
        {
            // Pure vector KNN search — semantic understanding via embedding
            // No text pre-filter, so "xe du lịch" can match "SEDAN Gasoline" by meaning
            var queryStr = $"*=>[KNN {topK} @embedding $query_vec AS score]";

            var query = new Query(queryStr)
                .AddParam("query_vec", queryVector)
                .SetSortBy("score")
                .ReturnFields("vehicle_id", "score")
                .Limit(0, topK)
                .Dialect(2);

            var result = await _searchCommands.SearchAsync(IndexName, query);

            var results = new List<(Guid VehicleId, double Score)>();
            foreach (var doc in result.Documents)
            {
                var vehicleIdStr = doc["vehicle_id"].ToString();
                var scoreStr = doc["score"].ToString();

                if (Guid.TryParse(vehicleIdStr, out var vehicleId) &&
                    double.TryParse(scoreStr, out var score))
                {
                    // Filter by cosine similarity threshold (lower = more similar)
                    if (score < 0.8)
                        results.Add((vehicleId, score));
                }
            }

            _logger.LogDebug("Hybrid search returned {Count} results for keyword: {Keyword}",
                results.Count, keyword ?? "(none)");

            return results;
        }
        catch (RedisException ex) when (ex.Message.Contains("no such index"))
        {
            _logger.LogWarning("Vehicle search index not found. Returning empty results.");
            return [];
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Hybrid search failed for keyword: {Keyword}", keyword);
            return [];
        }
    }

    private static string EscapeRedisSearchQuery(string query)
    {
        var special = new[] { '.', '-', '@', '!', '{', '}', '(', ')', '|', '>', '<', '=', '~', '*', '[', ']', '^', '"', '\'' };
        return special.Aggregate(query, (current, c) => current.Replace(c.ToString(), $"\\{c}"));
    }
}
