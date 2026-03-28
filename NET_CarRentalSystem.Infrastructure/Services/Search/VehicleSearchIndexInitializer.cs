using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NRedisStack;
using NRedisStack.RedisStackCommands;
using NRedisStack.Search;
using NRedisStack.Search.Literals.Enums;
using StackExchange.Redis;

namespace NET_CarRentalSystem.Infrastructure.Services.Search;

public class VehicleSearchIndexInitializer(
    IConnectionMultiplexer redis,
    ILogger<VehicleSearchIndexInitializer> logger) : IHostedService
{
    private const string IndexName = "idx:vehicles";
    private const string KeyPrefix = "vehicle:search:";
    private const int VectorDimension = 1024;

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        try
        {
            var db = redis.GetDatabase();
            var ft = db.FT();
            
            if (await IndexExistsAsync(ft))
            {
                logger.LogInformation("Vehicle search index '{IndexName}' already exists, skipping creation", IndexName);
                return;
            }
            
            var schema = new Schema()
                .AddTextField("manufacturer")
                .AddTextField("model")
                .AddTextField("title", 1.5)
                .AddTagField("category")
                .AddTextField("search_text")
                .AddVectorField("embedding",
                    Schema.VectorField.VectorAlgo.FLAT,
                    new Dictionary<string, object>
                    {
                        { "TYPE", "FLOAT32" },
                        { "DIM", VectorDimension },
                        { "DISTANCE_METRIC", "COSINE" }
                    });

            var parameters = FTCreateParams.CreateParams()
                .On(IndexDataType.HASH)
                .AddPrefix(KeyPrefix);

            await ft.CreateAsync(IndexName, parameters, schema);

            logger.LogInformation(
                "Created vehicle search index '{IndexName}' with prefix '{Prefix}', dim={Dim}",
                IndexName, KeyPrefix, VectorDimension);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Failed to create vehicle search index. Vector search will be unavailable.");
        }
    }

    public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;

    private static async Task<bool> IndexExistsAsync(SearchCommands ft)
    {
        try
        {
            await ft.InfoAsync(IndexName);
            return true;
        }
        catch (RedisServerException)
        {
            return false;
        }
    }
}
