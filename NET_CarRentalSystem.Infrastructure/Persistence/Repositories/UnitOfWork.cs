using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Infrastructure.Persistence.Contexts;
using System.Collections;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Repositories;

public class UnitOfWork(RenticarWriteDbContext writeDbContext, RenticarReadDbContext readDbContext) : IUnitOfWork
{
    private readonly RenticarWriteDbContext _writeDbContext = writeDbContext;
    private readonly RenticarReadDbContext _readDbContext = readDbContext;
    private Hashtable? _repositories;

    public IGenericRepository<T> GetRepository<T>() where T : class
    {
        _repositories ??= [];
        var type = typeof(T).Name;

        if (!_repositories.ContainsKey(type))
        {
            var repositoryType = typeof(GenericRepository<>);
            var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _writeDbContext, _readDbContext);

            _repositories.Add(type, repositoryInstance);
        }

        return (IGenericRepository<T>)_repositories[type]!;
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await _writeDbContext.SaveChangesAsync(cancellationToken);
    }

    public void Dispose()
    {
        _writeDbContext.Dispose();
        _readDbContext.Dispose();
        GC.SuppressFinalize(this);
    }
}

