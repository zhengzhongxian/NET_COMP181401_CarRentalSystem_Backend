using Dapper;
using Microsoft.Data.SqlClient;
using NET_CarRentalSystem.SyncService.Models;
using NET_CarRentalSystem.SyncService.Services;

namespace NET_CarRentalSystem.SyncService
{
    public class Worker(ILogger<Worker> logger, IConfiguration config, SyncTableMetadataCache metadataCache) : BackgroundService
    {
        private readonly ILogger<Worker> _logger = logger;
        private readonly string _writeDbConnection = config.GetConnectionString("RenticarWriteDbContext")!;
        private readonly string _readDbConnection = config.GetConnectionString("RenticarReadDbContext")!;
        private readonly SyncTableMetadataCache _metadataCache = metadataCache;

        private readonly List<SyncTableConfig> _tablesToSync =
        [
            new("bookings", "booking_id", typeof(Guid)),
            new("customers", "customer_id", typeof(Guid)),
            new("fuels", "fuel_id", typeof(Guid)),
            new("locations", "location_id", typeof(Guid)),
            new("transmissions", "transmission_id", typeof(Guid)),
            new("vehicle_attributes", "attribute_id", typeof(Guid)),
            new("vehicle_categories", "CategoryId", typeof(Guid)),
            new("vehicle_images", "image_id", typeof(Guid)),
            new("vehicles", "vehicle_id", typeof(Guid)),
            new("users", "user_id", typeof(Guid)),
            new("role_claims", "id", typeof(Guid)),
            new("roles", "role_id", typeof(Guid))
        ];

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("1:1 Sync Service is starting...");

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    foreach (var tableConfig in _tablesToSync)
                    {
                        if (stoppingToken.IsCancellationRequested) break;
                        await SyncTableAsync(tableConfig, stoppingToken);
                    }
                }
                catch (Exception ex) 
                { 
                    _logger.LogError("Fatal error in main sync loop. Error: {ex}", ex); 
                }

                await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
            }
        }

        private async Task SyncTableAsync(SyncTableConfig config, CancellationToken token)
        {
            using var writeConnection = new SqlConnection(_writeDbConnection);
            using var readConnection = new SqlConnection(_readDbConnection);
            try
            {
                await writeConnection.OpenAsync(token);
                await readConnection.OpenAsync(token);

                long lastSyncVersion = await writeConnection.QuerySingleOrDefaultAsync<long>("SELECT LastSyncVersion FROM dbo.SyncControl WHERE TableName = @TableName", new { config.TableName });
                long currentSyncVersion = await writeConnection.QuerySingleAsync<long>(new CommandDefinition("SELECT CHANGE_TRACKING_CURRENT_VERSION()", cancellationToken: token));
                if (lastSyncVersion >= currentSyncVersion) return;

                var changesQuery = $"SELECT ct.[{config.PrimaryKeyColumn}] AS Id, ct.SYS_CHANGE_OPERATION AS Operation FROM CHANGETABLE(CHANGES dbo.[{config.TableName}], @lastSyncVersion) AS ct";
                var changes = (await writeConnection.QueryAsync(changesQuery, new { lastSyncVersion })).AsList();
                if (!changes.Any())
                {
                    await UpdateSyncVersion(writeConnection, config.TableName, currentSyncVersion, token);
                    return;
                }

                _logger.LogInformation("{0} Detected {1} changes. Processing...", config.TableName, changes.Count);
                string mergeSql = await _metadataCache.GetMergeStatementAsync(config.TableName, config.PrimaryKeyColumn, token);

                foreach (var change in changes)
                {
                    if (token.IsCancellationRequested) break;

                    if (change.Operation == "D")
                    {
                        var deleteSql = $"DELETE FROM dbo.[{config.TableName}] WHERE [{config.PrimaryKeyColumn}] = @Id";
                        await readConnection.ExecuteAsync(new CommandDefinition(deleteSql, new { Id = change.Id }, cancellationToken: token));
                    }
                    else
                    {
                        var sourceData = await writeConnection.QuerySingleOrDefaultAsync(
                            new CommandDefinition($"SELECT * FROM dbo.[{config.TableName}] WHERE [{config.PrimaryKeyColumn}] = @Id", new { Id = change.Id }, cancellationToken: token));
                        if (sourceData != null)
                        {
                            await readConnection.ExecuteAsync(new CommandDefinition(mergeSql, sourceData, cancellationToken: token));
                        }
                    }
                }
                await UpdateSyncVersion(writeConnection, config.TableName, currentSyncVersion, token);
            }
            catch (Exception ex) 
            { 
                _logger.LogError("Error while synchronizing table: {0}. Error {1}", config.TableName, ex); 
            }
        }

        private async Task UpdateSyncVersion(SqlConnection connection, string tableName, long version, CancellationToken token)
        {
            var sql = "UPDATE dbo.SyncControl SET LastSyncVersion = @Version WHERE TableName = @TableName";
            await connection.ExecuteAsync(new CommandDefinition(sql, new { Version = version, TableName = tableName }, cancellationToken: token));
        }
    }
}

