using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Repositories;

public class QueryExecutor : IQueryExecutor
{
    public async Task<PagedList<TResult>> ToPagedListAsync<TResult>(
        IQueryable<TResult> query,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        var totalCount = await query.CountAsync(cancellationToken);
        
        var items = await query
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);
        
        return new PagedList<TResult>(items, totalCount, pageNumber, pageSize);
    }
}

