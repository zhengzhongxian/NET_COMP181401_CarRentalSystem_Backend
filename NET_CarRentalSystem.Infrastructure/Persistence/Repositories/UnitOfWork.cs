using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Infrastructure.Persistence.Contexts;
using System.Collections;
using Microsoft.EntityFrameworkCore;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Repositories;

public class UnitOfWork(RenticarWriteDbContext writeDbContext, RenticarReadDbContext readDbContext) : IUnitOfWork
{
    private Hashtable? _repositories;
    private IQueryRepository? _queryRepository;
    public IGenericRepository<T> GetRepository<T>() where T : class
    {
        _repositories ??= [];
        var type = typeof(T).Name;

        if (!_repositories.ContainsKey(type))
        {
            var repositoryType = typeof(GenericRepository<>);
            var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), writeDbContext, readDbContext);

            _repositories.Add(type, repositoryInstance);
        }

        return (IGenericRepository<T>)_repositories[type]!;
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

    public void Dispose()
    {
        writeDbContext.Dispose();
        readDbContext.Dispose();
        GC.SuppressFinalize(this);
    }
}

