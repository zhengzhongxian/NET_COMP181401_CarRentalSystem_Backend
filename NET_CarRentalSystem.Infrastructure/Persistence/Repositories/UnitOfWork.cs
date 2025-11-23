using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Infrastructure.Persistence.Contexts;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Repositories;

public class UnitOfWork(RenticarWriteDbContext writeDbContext, RenticarReadDbContext readDbContext) : IUnitOfWork
{
    private Dictionary<string, object>? _repositories;
    private IQueryRepository? _queryRepository;

    public IGenericRepository<T> GetRepository<T>() where T : class
    {
        _repositories ??= new Dictionary<string, object>();
        var type = typeof(T).Name;

        if (_repositories.TryGetValue(type, out var repo))
        {
            return (IGenericRepository<T>)repo;
        }

        var repositoryType = typeof(GenericRepository<>);
        var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), writeDbContext, readDbContext);

        if (repositoryInstance == null)
            throw new InvalidOperationException($"Unable to create repository for type {type}");
        _repositories.Add(type, repositoryInstance);
        return (IGenericRepository<T>)repositoryInstance;
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await writeDbContext.SaveChangesAsync(cancellationToken);
    }

    public IQueryRepository GetQueryRepository()
    {
        _queryRepository ??= new QueryRepository(readDbContext);
        return _queryRepository;
    }

    public async Task<IDbTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
    {
        var efTransaction = await writeDbContext.Database.BeginTransactionAsync(cancellationToken);
        return new DbTransactionAdapter(efTransaction);
    }

    public async Task ExecuteStrategyAsync(Func<CancellationToken, Task> operation,
        CancellationToken cancellationToken = default)
    {
        var strategy = writeDbContext.Database.CreateExecutionStrategy();
        await strategy.ExecuteAsync(() => operation(cancellationToken));
    }

    public async Task<TResult> ExecuteStrategyAsync<TResult>(Func<CancellationToken, Task<TResult>> operation,
        CancellationToken cancellationToken = default)
    {
        var strategy = writeDbContext.Database.CreateExecutionStrategy();
        return await strategy.ExecuteAsync(() => operation(cancellationToken));
    }

    public async Task ExecuteInTransactionAsync(Func<CancellationToken, Task> operation,
        CancellationToken cancellationToken = default)
    {
        var strategy = writeDbContext.Database.CreateExecutionStrategy();
        await strategy.ExecuteAsync(async () =>
        {
            await using var tx = await writeDbContext.Database.BeginTransactionAsync(cancellationToken);
            try
            {
                await operation(cancellationToken);
                await tx.CommitAsync(cancellationToken);
            }
            catch
            {
                await tx.RollbackAsync(cancellationToken);
                throw;
            }
        });
    }

    public async Task<TResult> ExecuteInTransactionAsync<TResult>(Func<CancellationToken, Task<TResult>> operation,
        CancellationToken cancellationToken = default)
    {
        var strategy = writeDbContext.Database.CreateExecutionStrategy();
        return await strategy.ExecuteAsync(async () =>
        {
            await using var tx = await writeDbContext.Database.BeginTransactionAsync(cancellationToken);
            try
            {
                var result = await operation(cancellationToken);
                await tx.CommitAsync(cancellationToken);
                return result;
            }
            catch
            {
                await tx.RollbackAsync(cancellationToken);
                throw;
            }
        });
    }

    public void Dispose()
    {
        writeDbContext.Dispose();
        readDbContext.Dispose();
        GC.SuppressFinalize(this);
    }
}