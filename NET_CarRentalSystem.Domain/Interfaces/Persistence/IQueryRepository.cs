using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.Domain.Interfaces.Persistence;

public interface IQueryRepository
{
    /// <summary>
    /// Thực thi một câu lệnh SQL nội suy và trả về danh sách các đối tượng của kiểu TResult.
    /// </summary>
    /// <typeparam name="TResult">Kiểu dữ liệu của đối tượng kết quả.</typeparam>
    /// <param name="sql">Câu lệnh SQL nội suy.</param>
    /// <param name="cancellationToken">Token để hủy bỏ thao tác.</param>
    /// <returns>Danh sách các đối tượng kiểu TResult được ánh xạ từ kết quả SQL.</returns>
    Task<List<TResult>> FromSqlInterpolatedAsync<TResult>(
        FormattableString sql,
        CancellationToken cancellationToken = default) where TResult : class;

    /// <summary>
    /// Lấy danh sách phân trang từ một IQueryable có sẵn.
    /// </summary>
    /// <typeparam name="TResult">Kiểu trả về.</typeparam>
    /// <param name="pageNumber">Số trang.</param>
    /// <param name="pageSize">Kích thước trang.</param>
    /// <param name="query">IQueryable (bản thiết kế) đã được xây dựng.</param>
    /// <param name="cancellationToken">Token để hủy bỏ thao tác.</param>
    /// <returns>Một PagedList&lt;TResult&gt;.</returns>
    Task<PagedList<TResult>> GetPagedAsync<TResult>(
        int pageNumber,
        int pageSize,
        IQueryable<TResult> query,
        CancellationToken cancellationToken = default) where TResult : class;
    
    /// <summary>
    /// Chuyển Queryable sang TolistAsync.
    /// </summary>
    Task<List<TResult>> ToListAsync<TResult>(
        IQueryable<TResult> query,
        CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Kiểm tra xem có bất kỳ phần tử nào trong IQueryable hay không.
    /// </summary>
    Task<bool> AnyAsync<TResult>(
        IQueryable<TResult> query,
        CancellationToken cancellationToken = default);
}
