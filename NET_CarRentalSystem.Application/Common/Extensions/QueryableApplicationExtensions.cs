using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.Application.Common.Extensions;

/// <summary>
/// Extension methods cho IQueryable trong Application layer (không dùng EF Core trực tiếp)
/// </summary>
public static class QueryableApplicationExtensions
{
    private static IQueryExecutor? _queryExecutor;
    
    /// <summary>
    /// Khởi tạo QueryExecutor để sử dụng trong extension methods
    /// </summary>
    public static void Initialize(IQueryExecutor queryExecutor)
    {
        _queryExecutor = queryExecutor;
    }
    
    public static Task<PagedList<T>> ToPagedListAsync<T>(
        this IQueryable<T> query,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        if (_queryExecutor == null)
            throw new InvalidOperationException("QueryExecutor chưa được khởi tạo. Hãy gọi QueryableApplicationExtensions.Initialize() trong DI setup.");
        
        return _queryExecutor.ToPagedListAsync(query, pageNumber, pageSize, cancellationToken);
    }
    
    public static Task<PagedList<T>> ToPagedListAsync<T>(
        this IQueryable<T> query,
        PagedParams pagedParams,
        CancellationToken cancellationToken = default)
    {
        return query.ToPagedListAsync(pagedParams.PageNumber, pagedParams.PageSize, cancellationToken);
    }
}

