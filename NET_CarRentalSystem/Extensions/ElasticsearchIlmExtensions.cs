using NET_CarRentalSystem.Application.Interfaces.Http;

namespace NET_CarRentalSystem.API.Extensions;

public static class ElasticsearchIlmExtensions
{
    public static async Task ApplyElasticsearchIlmPolicyAsync(this IHost app)
    {
        using var scope = app.Services.CreateScope();
        var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
        var config = scope.ServiceProvider.GetRequiredService<IConfiguration>();

        var nodeUri    = config["Serilog:WriteTo:2:Args:nodeUris"] ?? "http://elasticsearch:9200";
        var policyName = config["ElasticsearchIlm:PolicyName"]     ?? "renticar-logs-30d-policy";
        var hotMaxAge  = config["ElasticsearchIlm:HotMaxAge"]      ?? "1d";
        var deleteAge  = config["ElasticsearchIlm:DeleteAfterDays"] ?? "30d";

        var policyUrl = $"{nodeUri.TrimEnd('/')}/_ilm/policy/{policyName}";

        var policy = new
        {
            policy = new
            {
                phases = new
                {
                    hot = new
                    {
                        min_age = "0ms",
                        actions = new
                        {
                            rollover = new { max_age = hotMaxAge }
                        }
                    },
                    delete = new
                    {
                        min_age = deleteAge,
                        actions = new
                        {
                            delete = new { }
                        }
                    }
                }
            }
        };

        try
        {
            var apiClient = scope.ServiceProvider.GetRequiredService<IApiClient>();
            await apiClient.PutAsync<object, object>(policyUrl, policy);

            logger.LogInformation("[ILM] Policy '{PolicyName}' applied — logs deleted after {DeleteAge}.", policyName, deleteAge);
        }
        catch (Exception ex)
        {
            logger.LogWarning(ex, "[ILM] Could not apply policy '{PolicyName}'.", policyName);
        }
    }
}
