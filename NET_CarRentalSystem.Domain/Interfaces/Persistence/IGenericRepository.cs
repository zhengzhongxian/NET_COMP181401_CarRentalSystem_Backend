using NET_CarRentalSystem.Shared.Pagination;
using System.Linq.Expressions;

namespace NET_CarRentalSystem.Domain.Interfaces.Persistence;

public interface IGenericRepository<T> where T : class
{
    IQueryable<T> GetQueryable();

    Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

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
    /// Lấy danh sách các entity một cách linh hoạt với các tùy chọn lọc, sắp xếp và include.
    /// </summary>
    /// <param name="filter">Biểu thức lọc (Where).</param>
    /// <param name="orderBy">Hàm để sắp xếp (OrderBy).</param>
    /// <param name="includeProperties">Các navigation property cần include, cách nhau bởi dấu phẩy.</param>
    Task<List<T>> GetAsync(
        Expression<Func<T, bool>>? filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
        string includeProperties = "");

    /// <summary>
    /// Lấy danh sách các entity và trả về dưới dạng một danh sách đã phân trang.
    /// </summary>
    Task<PagedList<T>> GetPagedAsync(
        PagingParams pagingParams,
        Expression<Func<T, bool>>? filter = null,
        string includeProperties = "");
}

