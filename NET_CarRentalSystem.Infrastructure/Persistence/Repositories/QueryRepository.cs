using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Infrastructure.Persistence.Contexts;
using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Repositories;

public class QueryRepository(RenticarReadDbContext readDbContext) : IQueryRepository
{
    public async Task<List<TResult>> FromSqlInterpolatedAsync<TResult>(
        FormattableString sql,
        CancellationToken cancellationToken = default) where TResult : class
    {
        return await readDbContext.Set<TResult>()
            .FromSqlInterpolated(sql)
            .ToListAsync(cancellationToken);
    }

    public async Task<PagedList<TResult>> GetPagedAsync<TResult>(
        int pageNumber,
        int pageSize,
        IQueryable<TResult> query,
        CancellationToken cancellationToken = default) where TResult : class
    {
        var totalCount = await query.CountAsync(cancellationToken);
        
        var items = await query
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);
        
        return new PagedList<TResult>(items, totalCount, pageNumber, pageSize);
    }
    
    public async Task<List<TResult>> ToListAsync<TResult>(
        IQueryable<TResult> query, 
        CancellationToken cancellationToken = default)
        => await query.ToListAsync(cancellationToken);
    
    public async Task<bool> AnyAsync<TResult>(
        IQueryable<TResult> query, 
        CancellationToken cancellationToken = default)
        => await query.AnyAsync(cancellationToken);
}
