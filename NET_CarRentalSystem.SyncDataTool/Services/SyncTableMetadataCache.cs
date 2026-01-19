using System.Collections.Concurrent;
using System.Text;
using Dapper;
using Microsoft.Data.SqlClient;
using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.SyncDataTool.Services;

public class SyncTableMetadataCache(IConfiguration config, ILogger<SyncTableMetadataCache> logger)
{
    private readonly string _writeDbConnection = config.GetConnectionString(KeyConstants.ConnectionStrings.RenticarWriteDbContext)
            ?? throw new InvalidOperationException("Connection string 'RenticarWriteDbContext' not found");
    
    private static readonly ConcurrentDictionary<string, string> MergeStatementCache = new();

    private static readonly ConcurrentDictionary<string, List<string>> ColumnCache = new();

    public async Task<string> GetMergeStatementAsync(string tableName, string pkColumn, CancellationToken token)
    {
        if (MergeStatementCache.TryGetValue(tableName, out var cachedStatement))
        {
            return cachedStatement;
        }

        logger.LogInformation("First run for table {TableName}. Generating MERGE statement...", tableName);

        var columns = await GetTableColumnsAsync(tableName, token);
        var statement = BuildMergeStatement(tableName, pkColumn, columns);

        MergeStatementCache[tableName] = statement;

        logger.LogInformation("Successfully generated and cached MERGE statement for table {TableName}.", tableName);
        return statement;
    }

    private async Task<List<string>> GetTableColumnsAsync(string tableName, CancellationToken token)
    {
        if (ColumnCache.TryGetValue(tableName, out var cachedCols))
        {
            return cachedCols;
        }

        await using var connection = new SqlConnection(_writeDbConnection);
        await connection.OpenAsync(token);

        // Exclude timestamp/rowversion columns and computed columns
        const string query = @"
            SELECT c.COLUMN_NAME 
            FROM INFORMATION_SCHEMA.COLUMNS c
            WHERE c.TABLE_SCHEMA = 'dbo' 
              AND c.TABLE_NAME = @TableName
              AND c.DATA_TYPE != 'timestamp'
              AND COLUMNPROPERTY(OBJECT_ID(c.TABLE_SCHEMA + '.' + c.TABLE_NAME), c.COLUMN_NAME, 'IsComputed') = 0
            ORDER BY c.ORDINAL_POSITION";
            
        var columns = (await connection.QueryAsync<string>(new CommandDefinition(query, new { TableName = tableName }, cancellationToken: token))).AsList();

        if (columns.Count == 0)
        {
            throw new InvalidOperationException($"No columns found for table: {tableName}. Please check if the table exists in the Write DB.");
        }

        ColumnCache[tableName] = columns;
        return columns;
    }

    private static string BuildMergeStatement(string tableName, string pkColumn, List<string> columns)
    {
        var sb = new StringBuilder();

        sb.AppendLine($"MERGE INTO dbo.[{tableName}] AS T");
        sb.AppendLine("USING (SELECT");
        sb.AppendLine(string.Join("," + Environment.NewLine, columns.Select(c => $"    @{c} AS [{c}]")));
        sb.AppendLine($") AS S ON (T.[{pkColumn}] = S.[{pkColumn}])");

        sb.AppendLine("WHEN MATCHED THEN");
        sb.AppendLine("    UPDATE SET");

        var updateSetClauses = columns
            .Where(c => !c.Equals(pkColumn, StringComparison.OrdinalIgnoreCase))
            .Select(col => $"        T.[{col}] = S.[{col}]");

        sb.AppendLine(string.Join("," + Environment.NewLine, updateSetClauses));
        sb.AppendLine("WHEN NOT MATCHED BY TARGET THEN");

        var columnNames = string.Join(", ", columns.Select(c => $"[{c}]"));
        var sourceValues = string.Join(", ", columns.Select(c => $"S.[{c}]"));

        sb.AppendLine($"    INSERT ({columnNames})");
        sb.AppendLine($"    VALUES ({sourceValues});");

        return sb.ToString();
    }
}