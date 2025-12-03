using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Domain.Common;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Infrastructure.Persistence.Contexts;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Repositories;

public class WriteRepository<T>(RenticarWriteDbContext writeDbContext) : IWriteRepository<T> where T : class
{
    public async Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await writeDbContext.Set<T>().FindAsync([id], cancellationToken);
    }
    
    public async Task<T> GetFirstAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
    {
        return await writeDbContext.Set<T>().FirstAsync(predicate, cancellationToken);
    }
    
    public async Task AddAsync(T entity, CancellationToken cancellationToken = default)
    {
        await writeDbContext.Set<T>().AddAsync(entity, cancellationToken);
    }

    public void Update(T entity)
    {
        writeDbContext.Set<T>().Update(entity);
    }

    public void Remove(T entity, bool hardDelete = false)
    {
        if (hardDelete)
        {
            writeDbContext.Set<T>().Remove(entity);
            return;
        }

        if (entity is ISoftDelete softDelete)
        {
            softDelete.IsDeleted = true;
            writeDbContext.Entry(softDelete).State = EntityState.Modified;
        }
        else
        {
            writeDbContext.Set<T>().Remove(entity);
        }
    }

    public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
    {
        await writeDbContext.Set<T>().AddRangeAsync(entities, cancellationToken);
    }

    public async Task<List<T>> GetListAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
    {
        return await writeDbContext.Set<T>()
            .Where(predicate)
            .ToListAsync(cancellationToken);
    }
}