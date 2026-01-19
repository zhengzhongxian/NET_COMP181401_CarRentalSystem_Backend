using NET_CarRentalSystem.Application.Models.Search;
using NET_CarRentalSystem.Shared.CoreHelpers;
using NRedisStack.Search;

namespace NET_CarRentalSystem.Infrastructure.Services.Search;

public partial class VehicleSearchService
{
    private static string GenerateSearchableDescription(VehicleSearchDocument doc)
    {
        var parts = new[]
        {
            doc.Manufacturer,
            doc.Model,
            doc.CategoryName,
            doc.Color,
            doc.FuelName,
            doc.TransmissionName,
            doc.Description,
            string.Join(" ", doc.AttributeValues)
        };
        return string.Join(" ", parts.Where(p => !string.IsNullOrEmpty(p)));
    }
    
    private static byte[] SerializeVector(float[] vector)
    {
        var bytes = new byte[vector.Length * sizeof(float)];
        Buffer.BlockCopy(vector, 0, bytes, 0, bytes.Length);
        return bytes;
    }
    
    private async Task<List<(Guid VehicleId, float Score)>> VectorSearchAsync(
        string queryText, 
        int topK, 
        CancellationToken ct)
    {
        var queryEmbedding = await _embeddingService.GetEmbeddingAsync(queryText, ct);
        var queryVector = SerializeVector(queryEmbedding);
        
        var knnQuery = $"*=>[KNN {topK} @embedding $vec AS __score]";
        var query = new Query(knnQuery)
            .AddParam("vec", queryVector)
            .SetSortBy("__score")
            .Limit(0, topK)
            .Dialect(2);
        
        var result = await _ft.SearchAsync(CacheKeyHelper.VehicleVectorIndexName, query);
        
        var scores = new List<(Guid VehicleId, float Score)>();
        foreach (var doc in result.Documents)
        {
            var vehicleIdStr = doc["vehicleId"].ToString();
            if (!Guid.TryParse(vehicleIdStr, out var vehicleId)) continue;
            var scoreVal = doc["__score"];
            var score = !scoreVal.IsNull && float.TryParse(scoreVal.ToString(), out var s) ? s : 0f;
            scores.Add((vehicleId, 1 - score));
        }
        
        return scores;
    }
    
    private static List<VehicleSearchDocument> MergeSearchResults(
        List<VehicleSearchDocument> keywordResults,
        List<(Guid VehicleId, float Score)> vectorScores,
        int pageSize)
    {
        const float keywordWeight = 0.7f;
        const float vectorWeight = 0.3f;
        
        var vectorScoreDict = vectorScores.ToDictionary(x => x.VehicleId, x => x.Score);
        
        var scoredResults = keywordResults.Select((item, index) =>
        {
            var keywordScore = 1f - (float)index / Math.Max(keywordResults.Count, 1);
            
            var vectorScore = vectorScoreDict.GetValueOrDefault(item.VehicleId, 0f);
            
            var totalScore = (keywordScore * keywordWeight) + (vectorScore * vectorWeight);
            
            return new { Item = item, Score = totalScore };
        })
        .OrderByDescending(x => x.Score)
        .Select(x => x.Item)
        .Take(pageSize)
        .ToList();

        return scoredResults;
    }
}
