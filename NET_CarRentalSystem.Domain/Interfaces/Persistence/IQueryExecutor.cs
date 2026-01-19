using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.Domain.Interfaces.Persistence;

/// <summary>
/// Interface cho các utility methods để execute IQueryable queries
/// </summary>
public interface IQueryExecutor
{
    /// <summary>
    /// Execute một IQueryable và trả về PagedList (dùng cho complex queries với joins)
    /// </summary>
    /// <param name="query">IQueryable đã được build sẵn</param>
    /// <param name="pageNumber">Số trang</param>
    /// <param name="pageSize">Kích thước trang</param>
    /// <param name="cancellationToken">Token để hủy bỏ thao tác</param>
    /// <returns>PagedList với dữ liệu đã phân trang</returns>
    Task<PagedList<TResult>> ToPagedListAsync<TResult>(
        IQueryable<TResult> query,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken = default);
}

