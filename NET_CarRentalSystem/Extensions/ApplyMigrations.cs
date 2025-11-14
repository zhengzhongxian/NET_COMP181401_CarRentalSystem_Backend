using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Infrastructure.Persistence.Contexts;
using NET_CarRentalSystem.Infrastructure.Persistence.Setup;
using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.API.Extensions;

public static class ApplyMigrations 
{
    public static async Task ApplyMigrationsAsync(this IHost app) 
    {
        using var scope = app.Services.CreateScope();
        var services = scope.ServiceProvider;
        var logger = services.GetRequiredService<ILogger<Program>>();
        var configuration = services.GetRequiredService<IConfiguration>();
        
        var retryCount = 0;
        var maxRetries = configuration.GetValue<int>(KeyConstants.DatabaseInitializationSettings.MaxRetries);
        var retryDelayTime = configuration.GetValue<int>(KeyConstants.DatabaseInitializationSettings.RetryInterval) * 1000;

        while (retryCount < maxRetries)
        {
            try
            {
                logger.LogInformation("Applying database migrations... (Attempt {RetryCount}/{MaxRetries})", retryCount + 1, maxRetries);

                var writeDbContext = services.GetRequiredService<RenticarWriteDbContext>();
                await writeDbContext.Database.MigrateAsync();
                logger.LogInformation("API: WriteDB Migrations applied.");

                await ChangeTrackingSetup.EnableChangeTrackingAsync(writeDbContext, logger);
                logger.LogInformation("API: Change Tracking enabled.");

                var readDbContext = services.GetRequiredService<RenticarReadDbContext>();
                await readDbContext.Database.MigrateAsync();
                logger.LogInformation("API: ReadDB Migrations applied.");

                logger.LogInformation("[Migration Progress: 100%] Database migrations applied successfully.");
                break;
            }
            catch (Exception ex)
            {
                retryCount++;
                logger.LogWarning("API: Database migration failed on attempt {RetryCount}/{MaxRetries}. Retrying in {Delay} seconds... Error: {ErrorMessage}", retryCount, maxRetries, retryDelayTime / 1000, ex.Message);
                if (retryCount >= maxRetries)
                {
                    logger.LogError("API: Database migration failed after {MaxRetries} retries. Aborting.", maxRetries);
                    throw;
                }
                await Task.Delay(retryDelayTime);
            }
        }

    }
}