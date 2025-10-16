using NET_CarRentalSystem.Domain.Interfaces;
using NET_CarRentalSystem.Infrastructure.Persistence.Contexts;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Repositories;

public class GenericRepository<T>(RenticarWriteDbContext writeDbContext, RenticarReadDbContext readDbContext) : IGenericRepository<T> where T : class
{
    private readonly RenticarWriteDbContext _writeDbContext = writeDbContext;
    private readonly RenticarReadDbContext _readDbContext = readDbContext;

    public IQueryable<T> GetQueryable()
    {
        return _readDbContext.Set<T>().AsQueryable();
    }

    public async Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _readDbContext.Set<T>().FindAsync([id], cancellationToken: cancellationToken);
    }

    public async Task AddAsync(T entity, CancellationToken cancellationToken = default)
    {
        await _writeDbContext.Set<T>().AddAsync(entity, cancellationToken);
    }

    public void Update(T entity)
    {
        _writeDbContext.Set<T>().Update(entity);
    }

    public void Remove(T entity)
    {
        _writeDbContext.Set<T>().Remove(entity);
    }
}

