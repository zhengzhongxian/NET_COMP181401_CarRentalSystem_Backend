using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants;
using IDbTransaction = NET_CarRentalSystem.Domain.Interfaces.Persistence.IDbTransaction;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Repositories;

public class DapperRepository(IConfiguration configuration) : IDapperRepository
{
    private readonly string _connectionString =
        configuration.GetConnectionString(KeyConstants.ConnectionStrings.RenticarReadDbContext)!;
    
    private static System.Data.IDbTransaction? TryGetRealTransaction(IDbTransaction? transaction)
    {
        if (transaction is DbTransactionAdapter adapter)
        {
            return adapter.GetDbTransaction();
        }
        return null;
    }

    public async Task<IReadOnlyList<T>> QueryAsync<T>(string sql, object? param = null, IDbTransaction? transaction = null, CancellationToken cancellationToken = default)
    {
        var realTx = TryGetRealTransaction(transaction);

        var connection = realTx?.Connection ?? new SqlConnection(_connectionString);
        if (realTx == null) await ((SqlConnection)connection).OpenAsync(cancellationToken);

        try
        {
            var def = new CommandDefinition(sql, param, realTx, cancellationToken: cancellationToken);
            var result = await connection.QueryAsync<T>(def);
            return result.AsList();
        }
        finally
        {
            if (realTx == null) await ((SqlConnection)connection).DisposeAsync();
        }
    }

    public async Task<T?> QueryFirstOrDefaultAsync<T>(string sql, object? param = null, IDbTransaction? transaction = null, CancellationToken cancellationToken = default)
    {
        var realTx = TryGetRealTransaction(transaction);
        var connection = realTx?.Connection ?? new SqlConnection(_connectionString);

        if (realTx == null) await ((SqlConnection)connection).OpenAsync(cancellationToken);

        try
        {
            var def = new CommandDefinition(sql, param, realTx, cancellationToken: cancellationToken);
            return await connection.QueryFirstOrDefaultAsync<T>(def);
        }
        finally
        {
            if (realTx == null) await ((SqlConnection)connection).DisposeAsync();
        }
    }

    public async Task<T> QuerySingleAsync<T>(string sql, object? param = null, IDbTransaction? transaction = null, CancellationToken cancellationToken = default)
    {
        var realTx = TryGetRealTransaction(transaction);
        var connection = realTx?.Connection ?? new SqlConnection(_connectionString);

        if (realTx == null) await ((SqlConnection)connection).OpenAsync(cancellationToken);

        try
        {
            var def = new CommandDefinition(sql, param, realTx, cancellationToken: cancellationToken);
            return await connection.QuerySingleAsync<T>(def);
        }
        finally
        {
            if (realTx == null) await ((SqlConnection)connection).DisposeAsync();
        }
    }

    public async Task<int> ExecuteAsync(string sql, object? param = null, IDbTransaction? transaction = null, CancellationToken cancellationToken = default)
    {
        var realTx = TryGetRealTransaction(transaction);
        var connection = realTx?.Connection ?? new SqlConnection(_connectionString);

        if (realTx == null) await ((SqlConnection)connection).OpenAsync(cancellationToken);

        try
        {
            var def = new CommandDefinition(sql, param, realTx, cancellationToken: cancellationToken);
            return await connection.ExecuteAsync(def);
        }
        finally
        {
            if (realTx == null) await ((SqlConnection)connection).DisposeAsync();
        }
    }

    public async Task<T> ExecuteScalarAsync<T>(string sql, object? param = null, IDbTransaction? transaction = null, CancellationToken cancellationToken = default)
    {
        var realTx = TryGetRealTransaction(transaction);
        var connection = realTx?.Connection ?? new SqlConnection(_connectionString);

        if (realTx == null) await ((SqlConnection)connection).OpenAsync(cancellationToken);

        try
        {
            var def = new CommandDefinition(sql, param, realTx, cancellationToken: cancellationToken);
            return (await connection.ExecuteScalarAsync<T>(def))!;
        }
        finally
        {
            if (realTx == null) await ((SqlConnection)connection).DisposeAsync();
        }
    }
}