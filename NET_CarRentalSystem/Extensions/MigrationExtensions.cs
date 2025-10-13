using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Infrastructure.Persistence.Contexts;

namespace NET_CarRentalSystem.WebAPI.Extensions;

public static class MigrationExtensions
{
    public static void ApplyMigrations(this IHost app)
    {
        using var scope = app.Services.CreateScope();
        var services = scope.ServiceProvider;

        var logger = services.GetRequiredService<ILogger<Program>>();

        try
        {
            logger.LogInformation("Applying database migrations...");

            var writeDbContext = services.GetRequiredService<RenticarWriteDbContext>();
            writeDbContext.Database.Migrate();

            var readDbContext = services.GetRequiredService<RenticarReadDbContext>();
            readDbContext.Database.Migrate();

            logger.LogInformation("Database migrations applied successfully.");
        }
        catch (Exception ex)
        {
            logger.LogError("An error occurred during database migration. Error: {ex}", ex);
        }
    }
}

