using NET_CarRentalSystem.Application.Interfaces.Services.Search;
using Serilog;

namespace NET_CarRentalSystem.API.Extensions;

public static class RediSearchExtensions
{
    public static void InitializeRediSearchIndex(this IHost app)
    {
        _ = Task.Run(async () =>
        {
            try
            {
                using var scope = app.Services.CreateScope();
                var vehicleSearchService = scope.ServiceProvider.GetRequiredService<IVehicleSearchService>();
                await vehicleSearchService.CreateIndexIfNotExistsAsync();
                Log.Information("RediSearch index initialized successfully");
            }
            catch (Exception ex)
            {
                Log.Warning(ex, "Failed to initialize RediSearch index - vehicle search will fallback to SQL Server");
            }
        });
    }
}
