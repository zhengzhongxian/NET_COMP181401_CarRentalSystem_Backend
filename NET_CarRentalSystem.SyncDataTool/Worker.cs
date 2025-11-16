using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Shared.Constants;
using NET_CarRentalSystem.SyncDataTool.Configurations;
using NET_CarRentalSystem.SyncDataTool.Services;

namespace NET_CarRentalSystem.SyncDataTool;

public class Worker(
    ILogger<Worker> logger,
    IConfiguration config,
    IOptions<SyncDataToolSettings> settings,
    SyncTableMetadataCache metadataCache) : BackgroundService
{
    private readonly SyncDataToolSettings _settings = settings.Value;
    private readonly string _writeDbConnection = 
        config.GetConnectionString(KeyConstants.ConnectionStrings.RenticarWriteDbContext)!;
    private readonly string _readDbConnection = 
        config.GetConnectionString(KeyConstants.ConnectionStrings.RenticarReadDbContext)!;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {        
        logger.LogInformation("Sync Service is starting...");
        logger.LogInformation("Waiting for database (Renticar_WriteDB) to be ready...");

        var dbIsReady = false;
        while (!dbIsReady && !stoppingToken.IsCancellationRequested)
        {
            try
            {
                await using var connection = new SqlConnection(_writeDbConnection);
                await connection.OpenAsync(stoppingToken);
                await connection.CloseAsync();
                dbIsReady = true;
                logger.LogInformation("Database is ready. Starting main sync loop.");
            }
            catch (SqlException ex)
            {
                logger.LogWarning("Database is not ready yet. Retrying in {delay} seconds... Error: {ex}", _settings.DbRetryDelayInSeconds, ex.Message);
                await Task.Delay(TimeSpan.FromSeconds(_settings.DbRetryDelayInSeconds), stoppingToken);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Fatal error during database connection check. Stopping service.");
                return;
            }
        }

        logger.LogInformation("Waiting for database (Renticar_ReadDB) to be ready...");

        dbIsReady = false;
        while (!dbIsReady && !stoppingToken.IsCancellationRequested)
        {
            try
            {
                await using var connection = new SqlConnection(_readDbConnection);
                await connection.OpenAsync(stoppingToken);
                await connection.CloseAsync();
                dbIsReady = true;
                logger.LogInformation("Read Database is ready. Starting main sync loop.");
            }
            catch (SqlException ex)
            {
                logger.LogWarning("Read Database is not ready yet. Retrying in {delay} seconds... Error: {ex}", _settings.DbRetryDelayInSeconds, ex.Message);
                await Task.Delay(TimeSpan.FromSeconds(_settings.DbRetryDelayInSeconds), stoppingToken);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Fatal error during read database connection check. Stopping service.");
                return;
            }
        }

        logger.LogInformation("1:1 Sync Service is running.");

        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                var syncTasks = _settings.TablesToSync.Select(tableConfig => SyncTableAsync(tableConfig, stoppingToken));
                await Task.WhenAll(syncTasks);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Fatal error in main sync loop.");
            }
            
            await Task.Delay(TimeSpan.FromSeconds(_settings.SyncIntervalInSeconds), stoppingToken);
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

            logger.LogInformation("{TableName} Detected {ChangeCount} changes. Processing...", config.TableName, changes.Count);

            var deleteIds = changes.Where(c => c.Operation == "D").Select(c => (object)c.Id).ToList();
            if (deleteIds.Count > 0)
            {
                var deleteSql = $"DELETE FROM dbo.[{config.TableName}] WHERE [{config.PrimaryKeyColumn}] IN @Ids";
                await readConnection.ExecuteAsync(new CommandDefinition(deleteSql, new { Ids = deleteIds }, cancellationToken: token));
                logger.LogInformation("Deleted {DeleteCount} records from {TableName}", deleteIds.Count, config.TableName);
            }

            var upsertIds = changes.Where(c => c.Operation != "D").Select(c => (object)c.Id).ToList();
            if (upsertIds.Count > 0)
            {
                var mergeSql = await metadataCache.GetMergeStatementAsync(config.TableName, config.PrimaryKeyColumn, token);
                var sourceDataQuery = $"SELECT * FROM dbo.[{config.TableName}] WHERE [{config.PrimaryKeyColumn}] IN @Ids";
                var sourceData = (await writeConnection.QueryAsync(new CommandDefinition(sourceDataQuery, new { Ids = upsertIds }, cancellationToken: token))).ToList();

                if (sourceData.Count > 0)
                {
                    var validSqlDateTimeMinValue = new DateTime(1753, 1, 1);
                    foreach (var dict in sourceData.Select(row => (IDictionary<string, object>)row))
                    {
                        if (dict.TryGetValue("CreatedAt", out var createdAtObj) && createdAtObj is DateTime createdAt && createdAt < validSqlDateTimeMinValue)
                        {
                            dict["CreatedAt"] = DateTime.UtcNow;
                        }
                        if (dict.TryGetValue("UpdatedAt", out var updatedAtObj))
                        {
                            switch (updatedAtObj)
                            {
                                case DateTime updatedAt when updatedAt < validSqlDateTimeMinValue:
                                case null:
                                    dict["UpdatedAt"] = DateTime.UtcNow;
                                    break;
                            }
                        }
                    }

                    await readConnection.ExecuteAsync(new CommandDefinition(mergeSql, sourceData, cancellationToken: token));
                    logger.LogInformation("Upserted {UpsertCount} records to {TableName}", sourceData.Count, config.TableName);
                }
            }
            await UpdateSyncVersion(writeConnection, config.TableName, currentSyncVersion, token);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error while synchronizing table: {TableName}.", config.TableName);
        }
    }

    private static async Task UpdateSyncVersion(SqlConnection connection, string tableName, long version, CancellationToken token)
    {
        const string sql = "UPDATE dbo.SyncControl SET LastSyncVersion = @Version WHERE TableName = @TableName";
        await connection.ExecuteAsync(new CommandDefinition(sql, new { Version = version, TableName = tableName }, cancellationToken: token));
    }
}
