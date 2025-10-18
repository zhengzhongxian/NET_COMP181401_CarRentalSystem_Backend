using NET_CarRentalSystem.Shared;
using NET_CarRentalSystem.Shared.Pagination;
using System.Linq.Expressions;

namespace NET_CarRentalSystem.Domain.Interfaces.Persistence;

public interface IGenericRepository<T> where T : class
{
    IQueryable<T> GetQueryable();

    Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default, bool useWriteConnection = false);

    /// <summary>
    /// Lấy tất cả các entity và trả về dưới dạng một List.
    /// </summary>
    Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Tìm kiếm các entity dựa trên điều kiện và trả về dưới dạng một List.
    /// </summary>
    Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

    Task AddAsync(T entity, CancellationToken cancellationToken = default);

    void Update(T entity);

    /// <summary>
    /// Xóa một entity.
    /// </summary>
    /// <param name="entity">Entity cần xóa.</param>
    /// <param name="hardDelete">Nếu là true, entity sẽ bị xóa vĩnh viễn khỏi DB. Nếu là false (mặc định), sẽ áp dụng xóa mềm (nếu được hỗ trợ).</param>
    void Remove(T entity, bool hardDelete = false);

    /// <summary>
    /// Lấy ra entity đầu tiên khớp với điều kiện. Trả về null nếu không tìm thấy.
    /// </summary>
    Task<T?> GetFirstOrDefaultAsync(
        Expression<Func<T, bool>> filter,
        string includeProperties = "",
        CancellationToken cancellationToken = default,
        bool useWriteConnection = false);

    /// <summary>
    /// Lấy ra entity duy nhất khớp với điều kiện. Ném ra exception nếu có nhiều hơn một kết quả.
    /// </summary>
    Task<T?> GetSingleOrDefaultAsync(
        Expression<Func<T, bool>> filter,
        string includeProperties = "",
        CancellationToken cancellationToken = default,
        bool useWriteConnection = false);

    /// <summary>
    /// Lấy danh sách các entity một cách linh hoạt với các tùy chọn lọc, sắp xếp động và include.
    /// </summary>
    Task<List<T>> GetAsync(
        Expression<Func<T, bool>>? filter = null,
        string? sortBy = null,
        string? sortDirection = "asc",
        string includeProperties = "");


    /// <summary>
    /// Lấy danh sách các entity và trả về dưới dạng một danh sách đã phân trang.
    /// </summary>
    Task<PagedList<T>> GetPagedAsync(
        PagingParams pagingParams,
        Expression<Func<T, bool>>? filter = null,
        string includeProperties = "");

    /// <summary>
    /// Kiểm tra xem có bất kỳ entity nào thỏa mãn điều kiện không.
    /// </summary>
    Task<bool> ExistsAsync(
        Expression<Func<T, bool>> predicate, 
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Đếm số lượng entity, có thể kèm theo điều kiện lọc.
    /// </summary>
    Task<int> CountAsync(
        Expression<Func<T, bool>>? predicate = null, 
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Lấy giá trị tổng hợp (Min hoặc Max) của một thuộc tính được chỉ định.
    /// </summary>
    Task<TResult> GetAggregateValueAsync<TResult>(
        Expression<Func<T, TResult>> selector,
        AggregateType aggregateType,
        Expression<Func<T, bool>>? filter = null,
        CancellationToken cancellationToken = default);

    Task<T> FirstAsync(
        Expression<Func<T, bool>> predicate,
        CancellationToken cancellationToken = default);
}

