using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Infrastructure.Persistence.Contexts;
using NET_CarRentalSystem.Infrastructure.Persistence.Setup;
using Microsoft.Data.SqlClient;
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
        
        var writeConnectionString = configuration.GetConnectionString(KeyConstants.ConnectionStrings.RenticarWriteDbContext);
        
        if (string.IsNullOrEmpty(writeConnectionString))
        {
            logger.LogCritical("Connection string 'RenticarWriteDbContext' not found. Migration aborted.");
            return;
        }

        logger.LogInformation("API: Waiting for database (Renticar_WriteDB) to be ready...");
        var dbIsReady = false;
        var retryCount = 0;
        const int maxRetries = 12; 

        while (!dbIsReady && retryCount < maxRetries)
        {
            try
            {
                await using var connection = new SqlConnection(writeConnectionString);
                await connection.OpenAsync();
                await connection.CloseAsync();
                
                dbIsReady = true;
                logger.LogInformation("API: Database is ready. Applying migrations...");
            }
            catch (SqlException ex)
            {
                retryCount++;
                logger.LogWarning("API: Database is not ready yet (Attempt {RetryCount}/{MaxRetries}). Retrying in 5 seconds... Error: {ErrorMessage}", retryCount, maxRetries, ex.Message);
                await Task.Delay(5000);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "API: Fatal error during database connection check. Stopping startup.");
                throw;
            }
        }

        if (!dbIsReady)
        {
            logger.LogError("API: Database connection check failed after {MaxRetries} retries. Aborting.", maxRetries);
            return;
        }

        try
        {
            logger.LogInformation("Applying database migrations...");

            var writeDbContext = services.GetRequiredService<RenticarWriteDbContext>();
            await writeDbContext.Database.MigrateAsync();
            logger.LogInformation("API: WriteDB Migrations applied.");

            await ChangeTrackingSetup.EnableChangeTrackingAsync(writeDbContext, logger);
            logger.LogInformation("API: Change Tracking enabled.");

            var readConnectionString = configuration.GetConnectionString(KeyConstants.ConnectionStrings.RenticarReadDbContext);
            if (string.IsNullOrEmpty(readConnectionString))
            {
                logger.LogCritical(
                    "Connection string 'RenticarReadDbContext' : {readConnectionString} not found. Migration aborted.",
                    readConnectionString);
                return;
            }

            var readDbContext = services.GetRequiredService<RenticarReadDbContext>();
            await readDbContext.Database.MigrateAsync();
            
            logger.LogInformation("API: ReadDB Migrations applied.");
            logger.LogInformation("[Migration Progress: 100%] Database migrations applied successfully.");
        }
        catch (Exception ex)
        {
            logger.LogError("An unexpected error occurred during database migration. Please check the logs for details. Error {ex}", ex);
        }
    }
}