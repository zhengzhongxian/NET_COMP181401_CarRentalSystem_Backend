using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Interfaces.Services.AI;
using NET_CarRentalSystem.Application.Interfaces.Services.Search;
using NET_CarRentalSystem.Application.Models.Search;
using NET_CarRentalSystem.Shared.CoreHelpers;
using NRedisStack;
using NRedisStack.RedisStackCommands;
using NRedisStack.Search;
using NRedisStack.Search.Literals.Enums;
using StackExchange.Redis;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Infrastructure.Services.Search;

public partial class VehicleSearchService : IVehicleSearchService
{
    private readonly ILogger<VehicleSearchService> _logger;
    private readonly IDatabase _db;
    private readonly SearchCommands _ft;
    private readonly IEmbeddingService _embeddingService;
    private readonly EmbeddingSettings _embeddingSettings;

    public VehicleSearchService(
        IConnectionMultiplexer redis, 
        ILogger<VehicleSearchService> logger,
        IEmbeddingService embeddingService,
        IOptions<EmbeddingSettings> embeddingSettings)
    {
        _logger = logger;
        _db = redis.GetDatabase();
        _ft = _db.FT();
        _embeddingService = embeddingService;
        _embeddingSettings = embeddingSettings.Value;
    }

    public async Task<bool> IsAvailableAsync(CancellationToken ct = default)
    {
        try
        {
            await _ft.InfoAsync(CacheKeyHelper.VehicleSearchIndexName);
            return true;
        }
        catch (RedisServerException ex) when (ex.Message.Contains("Unknown index name"))
        {
            return true;
        }
        catch (RedisServerException ex) when (ex.Message.Contains("unknown command"))
        {
            _logger.LogWarning("RediSearch module not available: {Message}", ex.Message);
            return false;
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Failed to check RediSearch availability");
            return false;
        }
    }

    public async Task CreateIndexIfNotExistsAsync(CancellationToken ct = default)
    {
        try
        {
            try
            {
                await _ft.InfoAsync(CacheKeyHelper.VehicleSearchIndexName);
                _logger.LogInformation("RediSearch index {IndexName} already exists", CacheKeyHelper.VehicleSearchIndexName);
                return;
            }
            catch (RedisServerException ex) when (ex.Message.Contains("Unknown index name"))
            {
                
            }
            
            var schema = new Schema()
                .AddTextField(new FieldName("manufacturer", "manufacturer"), weight: 2.0)
                .AddTextField(new FieldName("model", "model"), weight: 2.0)
                .AddTextField(new FieldName("color", "color"))
                .AddTextField(new FieldName("description", "description"))
                .AddTextField(new FieldName("categoryName", "categoryName"), weight: 1.5)
                .AddTextField(new FieldName("fuelName", "fuelName"))
                .AddTextField(new FieldName("transmissionName", "transmissionName"))
                .AddTextField(new FieldName("attributesJson", "attributesJson"))
                .AddNumericField(new FieldName("pricePerHour", "pricePerHour"), sortable: true)
                .AddNumericField(new FieldName("rating", "rating"), sortable: true)
                .AddNumericField(new FieldName("availableCount", "availableCount"), sortable: true)
                .AddNumericField(new FieldName("updatedAt", "updatedAt"), sortable: true)
                .AddNumericField(new FieldName("createdAt", "createdAt"), sortable: true)
                .AddNumericField(new FieldName("isDeleted", "isDeleted"))
                .AddTagField(new FieldName("vehicleCategoryId", "vehicleCategoryId"))
                .AddTagField(new FieldName("fuelId", "fuelId"))
                .AddTagField(new FieldName("transmissionId", "transmissionId"))
                .AddTagField(new FieldName("locationIds", "locationIds"))
                .AddTagField(new FieldName("attributeValues", "attributeValues"));

            var createParams = FTCreateParams.CreateParams()
                .On(IndexDataType.HASH)
                .Prefix(CacheKeyHelper.VehicleSearchKeyPrefix);

            await _ft.CreateAsync(CacheKeyHelper.VehicleSearchIndexName, createParams, schema);
            _logger.LogInformation("Created RediSearch index {IndexName}", CacheKeyHelper.VehicleSearchIndexName);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to create RediSearch index");
            throw;
        }
    }

    public async Task CreateVectorIndexIfNotExistsAsync(CancellationToken ct = default)
    {
        if (!_embeddingSettings.Enabled || !_embeddingService.IsAvailable())
        {
            _logger.LogInformation("Embedding service is disabled or unavailable. Skipping vector index creation.");
            return;
        }

        try
        {
            try
            {
                await _ft.InfoAsync(CacheKeyHelper.VehicleVectorIndexName);
                _logger.LogInformation("Vector index {IndexName} already exists", CacheKeyHelper.VehicleVectorIndexName);
                return;
            }
            catch (RedisServerException ex) when (ex.Message.Contains("Unknown index name"))
            {
                
            }

            // Create HNSW vector index schema
            var schema = new Schema()
                .AddTagField(new FieldName("vehicleId", "vehicleId"))
                .AddVectorField(
                    new FieldName("embedding", "embedding"),
                    Schema.VectorField.VectorAlgo.HNSW,
                    new Dictionary<string, object>
                    {
                        ["TYPE"] = "FLOAT32",
                        ["DIM"] = _embeddingSettings.Dimension,
                        ["DISTANCE_METRIC"] = "COSINE",
                        ["M"] = 16,        // HNSW: max edges per layer
                        ["EF_CONSTRUCTION"] = 200  // Construction time accuracy
                    });

            var createParams = FTCreateParams.CreateParams()
                .On(IndexDataType.HASH)
                .Prefix(CacheKeyHelper.VehicleVectorKeyPrefix);

            await _ft.CreateAsync(CacheKeyHelper.VehicleVectorIndexName, createParams, schema);
            _logger.LogInformation("Created vector index {IndexName} with dimension {Dimension}",
                CacheKeyHelper.VehicleVectorIndexName, _embeddingSettings.Dimension);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to create vector index");
        }
    }

    public async Task<bool> IsVectorSearchAvailableAsync(CancellationToken ct = default)
    {
        if (!_embeddingSettings.Enabled || !_embeddingService.IsAvailable())
            return false;

        try
        {
            await _ft.InfoAsync(CacheKeyHelper.VehicleVectorIndexName);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task IndexVehicleAsync(VehicleSearchDocument document, CancellationToken ct = default)
    {
        try
        {
            var key = CacheKeyHelper.GetVehicleSearchKey(document.VehicleId);
            
            var locationIds = document.LocationIds.Count > 0 
                ? document.LocationIds 
                : ExtractLocationIds(document.VehicleModelsJson);
            var locationIdsStr = string.Join(",", locationIds);
            
            var attributeValues = document.AttributeValues.Count > 0
                ? document.AttributeValues
                : ExtractAttributeValues(document.AttributesJson);
            var attributeValuesStr = string.Join(",", attributeValues);

            var hashEntries = new HashEntry[]
            {
                new("vehicleId", document.VehicleId.ToString()),
                new("manufacturer", document.Manufacturer),
                new("model", document.Model),
                new("color", document.Color ?? string.Empty),
                new("description", document.Description ?? string.Empty),
                new("categoryName", document.CategoryName ?? string.Empty),
                new("fuelName", document.FuelName ?? string.Empty),
                new("transmissionName", document.TransmissionName ?? string.Empty),
                new("attributesJson", document.AttributesJson ?? string.Empty),
                new("attributeValues", attributeValuesStr),
                new("pricePerHour", (double)document.PricePerHour),
                new("rating", document.Rating),
                new("availableCount", document.AvailableCount),
                new("thumbnail", document.Thumbnail ?? string.Empty),
                new("vehicleCategoryId", document.VehicleCategoryId?.ToString() ?? string.Empty),
                new("fuelId", document.FuelId?.ToString() ?? string.Empty),
                new("transmissionId", document.TransmissionId?.ToString() ?? string.Empty),
                new("locationIds", locationIdsStr),
                new("vehicleModelsJson", document.VehicleModelsJson ?? string.Empty),
                new("imagesJson", document.ImagesJson ?? string.Empty),
                new("metadata", document.Metadata ?? string.Empty),
                new("isDeleted", document.IsDeleted ? 1 : 0),
                new("updatedAt", document.UpdatedAt.Ticks),
                new("createdAt", document.CreatedAt.Ticks)
            };

            await _db.HashSetAsync(key, hashEntries);
            _logger.LogDebug("Indexed vehicle {VehicleId} to keyword search", document.VehicleId);
            await IndexVehicleToVectorAsync(document, ct);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to index vehicle {VehicleId} to Redis", document.VehicleId);
            throw;
        }
    }
    
    private async Task IndexVehicleToVectorAsync(VehicleSearchDocument document, CancellationToken ct)
    {
        if (!_embeddingSettings.Enabled || !_embeddingService.IsAvailable())
            return;

        try
        {
            var description = GenerateSearchableDescription(document);
            
            var embedding = await _embeddingService.GetEmbeddingAsync(description, ct);
            
            var key = CacheKeyHelper.GetVehicleVectorKey(document.VehicleId);
            await _db.HashSetAsync(key, [
                new HashEntry("vehicleId", document.VehicleId.ToString()),
                new HashEntry("embedding", SerializeVector(embedding))
            ]);
            
            _logger.LogDebug("Indexed vehicle {VehicleId} to vector search", document.VehicleId);
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Failed to index vehicle {VehicleId} to vector search. Keyword search still works.", document.VehicleId);
        }
    }

    public async Task RemoveVehicleAsync(Guid vehicleId, CancellationToken ct = default)
    {
        try
        {
            var key = CacheKeyHelper.GetVehicleSearchKey(vehicleId);
            await _db.KeyDeleteAsync(key);
            
            var vectorKey = CacheKeyHelper.GetVehicleVectorKey(vehicleId);
            await _db.KeyDeleteAsync(vectorKey);
            
            _logger.LogDebug("Removed vehicle {VehicleId} from Redis (keyword + vector)", vehicleId);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to remove vehicle {VehicleId} from Redis", vehicleId);
            throw;
        }
    }

    
    private const int CacheTtlMinutes = 5;
    
    public async Task<VehicleSearchResult> SearchAsync(VehicleSearchParams searchParams, CancellationToken ct = default)
    {
        try
        {
            var cacheKey = GetSearchCacheKey(searchParams);
            var cached = await _db.StringGetAsync(cacheKey);
            if (!cached.IsNullOrEmpty)
            {
                _logger.LogDebug("Cache hit for search: {CacheKey}", cacheKey);
                return cached.ToString().FromJson<VehicleSearchResult>()!;
            }

            var queryParts = new List<string> {
                "@isDeleted:[0 0]" };

            if (!string.IsNullOrWhiteSpace(searchParams.SearchKeyword))
            {
                // Phase 4.2: Expand search terms with synonyms
                var expandedTerms = SynonymHelper.ExpandPhraseWithSynonyms(searchParams.SearchKeyword);
                
                var words = expandedTerms
                    .Where(w => w.Length >= 2)
                    .Select(EscapeSearchTerm)
                    .ToList();

                if (words.Count == 0)
                {
                    words.Add(EscapeSearchTerm(searchParams.SearchKeyword.Trim()));
                }

                var searchTerms = string.Join(" | ", words.Select(w => $"{w}*"));
                queryParts.Add($"({searchTerms})");
            }
            
            if (searchParams.CategoryId.HasValue)
            {
                queryParts.Add($"@vehicleCategoryId:{{{searchParams.CategoryId.Value}}}");
            }
            
            if (searchParams.FuelId.HasValue)
            {
                queryParts.Add($"@fuelId:{{{searchParams.FuelId.Value}}}");
            }
            
            if (searchParams.MinPrice.HasValue || searchParams.MaxPrice.HasValue)
            {
                var min = searchParams.MinPrice.HasValue ? searchParams.MinPrice.Value.ToString("F2") : "-inf";
                var max = searchParams.MaxPrice.HasValue ? searchParams.MaxPrice.Value.ToString("F2") : "+inf";
                queryParts.Add($"@pricePerHour:[{min} {max}]");
            }
            
            if (searchParams.LocationId.HasValue)
            {
                queryParts.Add($"@locationIds:{{{searchParams.LocationId.Value}}}");
            }
            
            if (searchParams.AttributeKeywords is { Count: > 0 })
            {
                queryParts.AddRange(searchParams.AttributeKeywords.Select(attr => $"@attributeValues:{{{attr}}}"));
            }
            
            if (searchParams.ExcludeAttributeKeywords is { Count: > 0 })
            {
                queryParts.AddRange(searchParams.ExcludeAttributeKeywords.Select(attr => $"-@attributeValues:{{{attr}}}"));
            }

            var queryString = queryParts.Count > 0 ? string.Join(" ", queryParts) : "*";
            
            var query = new Query(queryString);
            
            var sortField = searchParams.SortBy != null 
                ? GetSortField(searchParams.SortBy) 
                : "rating";
            var sortAsc = searchParams.SortDirection?.ToLower() == "asc";
            query.SetSortBy(sortField, sortAsc);
            
            var offset = (searchParams.PageNumber - 1) * searchParams.PageSize;
            query.Limit(offset, searchParams.PageSize);
            
            var result = await _ft.SearchAsync(CacheKeyHelper.VehicleSearchIndexName, query);

            var items = result.Documents.Select(MapToDocument).ToList();
            
            if (searchParams.UseVectorSearch && 
                !string.IsNullOrWhiteSpace(searchParams.SearchKeyword) &&
                _embeddingSettings.Enabled && 
                _embeddingService.IsAvailable())
            {
                try
                {
                    var vectorResults = await VectorSearchAsync(searchParams.SearchKeyword, 50, ct);
                    items = MergeSearchResults(items, vectorResults, searchParams.PageSize);
                    _logger.LogDebug("Hybrid search merged {VectorCount} vector results with keyword results", vectorResults.Count);
                }
                catch (Exception ex)
                {
                    _logger.LogWarning(ex, "Vector search failed, using keyword-only results");
                }
            }
            
            if (string.IsNullOrEmpty(searchParams.SortBy))
            {
                items = ApplyBusinessScoring(items);
            }

            var searchResult = new VehicleSearchResult
            {
                Items = items,
                TotalCount = (int)result.TotalResults
            };
            
            await _db.StringSetAsync(
                cacheKey, 
                searchResult.ToJson(), 
                TimeSpan.FromMinutes(CacheTtlMinutes));
            
            _logger.LogDebug("Cached search result: {CacheKey}, {Count} items", cacheKey, items.Count);

            return searchResult;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "RediSearch query failed");
            throw;
        }
    }
    
    public async Task<VehicleSearchResult> TwoStageSearchAsync(VehicleSearchParams searchParams, CancellationToken ct = default)
    {
        try
        {
            var queryParts = new List<string> { "@isDeleted:[0 0]" };
            
            if (!string.IsNullOrWhiteSpace(searchParams.SearchKeyword))
            {
                var expandedTerms = SynonymHelper.ExpandPhraseWithSynonyms(searchParams.SearchKeyword);
                
                var words = expandedTerms
                    .Where(w => w.Length >= 2)
                    .Select(EscapeSearchTerm)
                    .ToList();
                if (words.Count == 0)
                    words.Add(EscapeSearchTerm(searchParams.SearchKeyword.Trim()));
                queryParts.Add($"({string.Join(" | ", words.Select(w => $"{w}*"))})");
            }
            
            if (searchParams.CategoryId.HasValue)
                queryParts.Add($"@vehicleCategoryId:{{{searchParams.CategoryId.Value}}}");
            if (searchParams.FuelId.HasValue)
                queryParts.Add($"@fuelId:{{{searchParams.FuelId.Value}}}");
            if (searchParams.MinPrice.HasValue || searchParams.MaxPrice.HasValue)
            {
                var min = searchParams.MinPrice?.ToString("F2") ?? "-inf";
                var max = searchParams.MaxPrice?.ToString("F2") ?? "+inf";
                queryParts.Add($"@pricePerHour:[{min} {max}]");
            }
            if (searchParams.LocationId.HasValue)
                queryParts.Add($"@locationIds:{{{searchParams.LocationId.Value}}}");
            if (searchParams.AttributeKeywords is { Count: > 0 })
                queryParts.AddRange(searchParams.AttributeKeywords.Select(a => $"@attributeValues:{{{a}}}"));
            if (searchParams.ExcludeAttributeKeywords is { Count: > 0 })
                queryParts.AddRange(searchParams.ExcludeAttributeKeywords.Select(a => $"-@attributeValues:{{{a}}}"));

            var queryString = string.Join(" ", queryParts);
            
            const int recallSize = 500;
            var recallQuery = new Query(queryString)
                .SetSortBy("rating", ascending: false)
                .Limit(0, recallSize);
            
            var recallResult = await _ft.SearchAsync(CacheKeyHelper.VehicleSearchIndexName, recallQuery);
            var candidates = recallResult.Documents.Select(MapToDocument).ToList();
            
            _logger.LogDebug("Stage 1 Recall: {Count} candidates", candidates.Count);
            
            if (searchParams.UseVectorSearch && 
                !string.IsNullOrWhiteSpace(searchParams.SearchKeyword) &&
                _embeddingSettings.Enabled && _embeddingService.IsAvailable())
            {
                try
                {
                    var vectorResults = await VectorSearchAsync(searchParams.SearchKeyword, 100, ct);
                    candidates = MergeSearchResults(candidates, vectorResults, candidates.Count);
                }
                catch (Exception ex)
                {
                    _logger.LogWarning(ex, "Vector ranking failed");
                }
            }
            
            candidates = string.IsNullOrEmpty(searchParams.SortBy) ? ApplyBusinessScoring(candidates) : ApplyUserSort(candidates, searchParams.SortBy, searchParams.SortDirection);
            
            var offset = (searchParams.PageNumber - 1) * searchParams.PageSize;
            var items = candidates.Skip(offset).Take(searchParams.PageSize).ToList();
            
            _logger.LogDebug("Stage 2 Rank: returning page {Page} with {Count} items", searchParams.PageNumber, items.Count);
            
            return new VehicleSearchResult { Items = items, TotalCount = (int)recallResult.TotalResults };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Two-stage search failed");
            throw;
        }
    }
}
