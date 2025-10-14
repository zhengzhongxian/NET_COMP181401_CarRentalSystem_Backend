using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Infrastructure.Persistence.Contexts;

namespace NET_CarRentalSystem.API.Extensions;

public static class MigrationExtensions
{
    public static async Task ApplyMigrationsAsync(this IHost app)
    {
        using var scope = app.Services.CreateScope();
        var services = scope.ServiceProvider;
        var logger = services.GetRequiredService<ILogger<Program>>();
        var configuration = services.GetRequiredService<IConfiguration>();

        try
        {
            logger.LogInformation("Applying database migrations...");

            var writeConnectionString = configuration.GetConnectionString("RenticarWriteDbContext");
            if (string.IsNullOrEmpty(writeConnectionString))
            {
                logger.LogCritical("Connection string 'WriteDatabase' not found: {writeConnectionString} . Migration aborted.", writeConnectionString);
                return;
            }

            var writeDbContext = services.GetRequiredService<RenticarWriteDbContext>();
            await writeDbContext.Database.MigrateAsync();

            var readConnectionString = configuration.GetConnectionString("RenticarReadDbContext");
            if (string.IsNullOrEmpty(readConnectionString))
            {
                logger.LogCritical("Connection string 'ReadDatabase' not found: {readConnectionString}. Migration aborted.", readConnectionString);
                return;
            }

            var readDbContext = services.GetRequiredService<RenticarReadDbContext>();
            await readDbContext.Database.MigrateAsync();
            logger.LogInformation("[Migration Progress: 100%] Read Database migrations applied successfully.");
        }
        catch (Exception ex)
        {
            logger.LogError("An unexpected error occurred during database migration. Please check the logs for details. Error {ex}", ex);
        }
    }
}

