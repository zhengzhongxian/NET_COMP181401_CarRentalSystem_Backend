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
            _logger.LogInformation("Sync Service is starting...");
            _logger.LogInformation("Waiting for database (Renticar_WriteDB) to be ready...");
            
            var dbIsReady = false;
            while (!dbIsReady && !stoppingToken.IsCancellationRequested)
            {
                try
                {
                    await using var connection = new SqlConnection(_writeDbConnection);
                    await connection.OpenAsync(stoppingToken);
                    await connection.CloseAsync();
                    dbIsReady = true;
                    _logger.LogInformation("Database is ready. Starting main sync loop.");
                }
                catch (SqlException ex)
                {
                    _logger.LogWarning("Database is not ready yet. Retrying in 5 seconds... Error: {ex}", ex.Message);
                    await Task.Delay(5000, stoppingToken);
                }
                catch (Exception ex)
                {
                    _logger.LogError("Fatal error during database connection check. Stopping service. Error: {ex}", ex.Message);
                    return; 
                }
            }
            
            _logger.LogInformation("1:1 Sync Service is running.");
            
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    var syncTasks = _tablesToSync.Select(tableConfig => SyncTableAsync(tableConfig, stoppingToken));
                    await Task.WhenAll(syncTasks);
                }
                catch (Exception ex) 
                { 
                    _logger.LogError("Fatal error in main sync loop. Error: {ex}", ex); 
                }

                await Task.Delay(TimeSpan.FromSeconds(2), stoppingToken);
            }
        }

        private async Task SyncTableAsync(SyncTableConfig config, CancellationToken token)
        {
            await using var writeConnection = new SqlConnection(_writeDbConnection);
            await using var readConnection = new SqlConnection(_readDbConnection);
            try
            {
                await writeConnection.OpenAsync(token);
                await readConnection.OpenAsync(token);

                var lastSyncVersion = await writeConnection.QuerySingleOrDefaultAsync<long>("SELECT LastSyncVersion FROM dbo.SyncControl WHERE TableName = @TableName", new { config.TableName });
                var currentSyncVersion = await writeConnection.QuerySingleAsync<long>(new CommandDefinition("SELECT CHANGE_TRACKING_CURRENT_VERSION()", cancellationToken: token));
                if (lastSyncVersion >= currentSyncVersion) return;

                var changesQuery = $"SELECT ct.[{config.PrimaryKeyColumn}] AS Id, ct.SYS_CHANGE_OPERATION AS Operation FROM CHANGETABLE(CHANGES dbo.[{config.TableName}], @lastSyncVersion) AS ct";
                var changes = (await writeConnection.QueryAsync(changesQuery, new { lastSyncVersion })).AsList();
                if (changes.Count == 0)
                {
                    await UpdateSyncVersion(writeConnection, config.TableName, currentSyncVersion, token);
                    return;
                }

                _logger.LogInformation("{TableName} Detected {ChangeCount} changes. Processing...", config.TableName, changes.Count);

                var deleteIds = changes.Where(c => c.Operation == "D").Select(c => (object)c.Id).ToList();
                if (deleteIds.Count > 0)
                {
                    var deleteSql = $"DELETE FROM dbo.[{config.TableName}] WHERE [{config.PrimaryKeyColumn}] IN @Ids";
                    await readConnection.ExecuteAsync(new CommandDefinition(deleteSql, new { Ids = deleteIds }, cancellationToken: token));
                    _logger.LogInformation("Deleted {DeleteCount} records from {TableName}", deleteIds.Count, config.TableName);
                }

                var upsertIds = changes.Where(c => c.Operation != "D").Select(c => (object)c.Id).ToList();
                if (upsertIds.Count > 0)
                {
                    var mergeSql = await _metadataCache.GetMergeStatementAsync(config.TableName, config.PrimaryKeyColumn, token);
                    var sourceDataQuery = $"SELECT * FROM dbo.[{config.TableName}] WHERE [{config.PrimaryKeyColumn}] IN @Ids";
                    var sourceData = (await writeConnection.QueryAsync(new CommandDefinition(sourceDataQuery, new { Ids = upsertIds }, cancellationToken: token))).ToList();

                    if (sourceData.Count > 0)
                    {
                        await readConnection.ExecuteAsync(new CommandDefinition(mergeSql, sourceData, cancellationToken: token));
                        _logger.LogInformation("Upserted {UpsertCount} records to {TableName}", sourceData.Count, config.TableName);
                    }
                }
                await UpdateSyncVersion(writeConnection, config.TableName, currentSyncVersion, token);
            }
            catch (Exception ex) 
            { 
                _logger.LogError("Error while synchronizing table: {TableName}. Error {Exception}", config.TableName, ex);
            }
        }

        private static async Task UpdateSyncVersion(SqlConnection connection, string tableName, long version, CancellationToken token)
        {
            const string sql = "UPDATE dbo.SyncControl SET SyncControl.LastSyncVersion = @Version WHERE TableName = @TableName";
            await connection.ExecuteAsync(new CommandDefinition(sql, new { Version = version, TableName = tableName }, cancellationToken: token));
        }
    }
}

