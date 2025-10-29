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

    public void Dispose()
    {
        writeDbContext.Dispose();
        readDbContext.Dispose();
        GC.SuppressFinalize(this);
    }
}