using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Infrastructure.Persistence.Contexts;
using System.Text;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Setup
{
    public static class ChangeTrackingSetup
    {
        private static List<string> GetTrackableTables(DbContext context)
        {
            return [.. context.Model.GetEntityTypes()
                .Where(e => !e.IsOwned())
                .Select(e => e.GetTableName()!)
                .Where(name => name != null && (!name.StartsWith("user_") || name.StartsWith("role_")))
                .Distinct()];
        }

        public static async Task EnableChangeTrackingAsync(RenticarWriteDbContext context, ILogger logger)
        {
            try
            {
                var connection = context.Database.GetDbConnection();
                await connection.OpenAsync();

                //kích hoạt Theo dõi Thay đổi cho toàn bộ db
                logger.LogInformation("Checking and enabling Change Tracking for the database...");
                var enableDbCtSql = "IF NOT EXISTS (SELECT 1 FROM sys.change_tracking_databases WHERE database_id = DB_ID()) " +
                                    "BEGIN ALTER DATABASE CURRENT SET CHANGE_TRACKING = ON (CHANGE_RETENTION = 2 DAYS, AUTO_CLEANUP = ON); END";
                await context.Database.ExecuteSqlRawAsync(enableDbCtSql);

                logger.LogInformation("{0}", "Change Tracking enabled for the database.") ;

                // bật Theo dõi thay đổi cho từng bảng
                var trackableTables = GetTrackableTables(context);
                logger.LogInformation("Found {0} tables to enable Change Tracking for: {1}", trackableTables.Count, string.Join(", ", trackableTables));

                var sbTableCt = new StringBuilder();
                foreach (var tableName in trackableTables)
                {
                    sbTableCt.AppendLine($"IF NOT EXISTS (SELECT 1 FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID('dbo.{tableName}')) " +
                                         $"BEGIN ALTER TABLE dbo.[{tableName}] ENABLE CHANGE_TRACKING WITH (TRACK_COLUMNS_UPDATED = OFF); END");
                }
                await context.Database.ExecuteSqlRawAsync(sbTableCt.ToString());

                logger.LogInformation("{0}", "Change Tracking enabled for tables.");

                // tạo bảng track nếu không tồn tại
                var createControlTableSql = @"
                    IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SyncControl]') AND type in (N'U'))
                    BEGIN
                        CREATE TABLE [dbo].[SyncControl](
	                        [TableName] [nvarchar](128) NOT NULL PRIMARY KEY,
	                        [LastSyncVersion] [bigint] NOT NULL
                        )
                    END";
                await context.Database.ExecuteSqlRawAsync(createControlTableSql);

                // chèn bản ghi kiểm soát ban đầu nếu không tồn tại
                logger.LogInformation("Initializing SyncControl table...");
                var sbControlInsert = new StringBuilder();
                foreach (var tableName in trackableTables)
                {
                    sbControlInsert.AppendLine($"IF NOT EXISTS (SELECT 1 FROM dbo.SyncControl WHERE TableName = '{tableName}') " +
                                               $"BEGIN INSERT INTO dbo.SyncControl (TableName, LastSyncVersion) VALUES ('{tableName}', 0); END");
                }
                await context.Database.ExecuteSqlRawAsync(sbControlInsert.ToString());

                logger.LogInformation("{0}", "Change Tracking setup completed successfully.");
            }
            catch (Exception ex)
            {
                logger.LogError("A critical error occurred while setting up Change Tracking. Error: {ex}", ex);
                throw;
            }
        }
    }
}