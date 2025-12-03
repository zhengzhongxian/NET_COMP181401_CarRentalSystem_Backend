using NET_CarRentalSystem.Shared.Pagination;
using System.Linq.Expressions;

namespace NET_CarRentalSystem.Domain.Interfaces.Persistence;

public interface IReadRepository<T> where T : class
{
    /// <summary>
    /// Trả về một IQueryable&lt;T&gt; để xây dựng các truy vấn phức tạp và linh hoạt.
    /// Lưu ý: Việc thực thi truy vấn (ví dụ: ToListAsync()) nên được thực hiện ở tầng Persistence.
    /// </summary>
    IQueryable<T> GetQueryable();
    
    /// <summary>
    /// Overload trả về IQueryable với filter và include.
    /// </summary>
    IQueryable<T> GetQueryable(Expression<Func<T, bool>>? filter, string includeProperties = "");

    /// <summary>
    /// Lấy một entity theo ID duy nhất.
    /// </summary>
    /// <param name="id">ID của entity.</param>
    /// <param name="cancellationToken">Token để hủy bỏ thao tác.</param>
    /// <returns>Entity tìm thấy hoặc null nếu không tìm thấy.</returns>
    Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Tìm kiếm các entity dựa trên một điều kiện lọc và trả về dưới dạng một List.
    /// Phương thức này không đảm bảo thứ tự sắp xếp mặc định.
    /// </summary>
    /// <param name="predicate">Biểu thức điều kiện để lọc các entity.</param>
    /// <param name="cancellationToken">Token để hủy bỏ thao tác.</param>
    /// <returns>Danh sách các entity thỏa mãn điều kiện.</returns>
    Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

    /// <summary>
    /// Lấy ra entity đầu tiên khớp với điều kiện. Trả về null nếu không tìm thấy.
    /// </summary>
    /// <param name="filter">Biểu thức điều kiện để lọc.</param>
    /// <param name="includeProperties">Chuỗi các thuộc tính liên quan cần tải (comma-separated).</param>
    /// <param name="cancellationToken">Token để hủy bỏ thao tác.</param>
    /// <returns>Entity đầu tiên thỏa mãn điều kiện hoặc null.</returns>
    Task<T?> GetFirstOrDefaultAsync(
        Expression<Func<T, bool>> filter,
        string includeProperties = "",
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Lấy ra entity đầu tiên khớp với điều kiện. Ném ra exception nếu không tìm thấy.
    /// </summary>
    /// <param name="filter">Biểu thức điều kiện để lọc.</param>
    /// <param name="includeProperties">Chuỗi các thuộc tính liên quan cần tải (comma-separated).</param>
    /// <param name="cancellationToken">Token để hủy bỏ thao tác.</param>
    /// <returns>Entity đầu tiên thỏa mãn điều kiện.</returns>
    Task<T> GetFirstAsync(
        Expression<Func<T, bool>> filter,
        string includeProperties = "",
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Lấy danh sách các entity một cách linh hoạt với các tùy chọn lọc, sắp xếp động và include.
    /// </summary>
    /// <param name="filter">Biểu thức điều kiện để lọc (có thể là null để lấy tất cả).</param>
    /// <param name="sortBy">Tên thuộc tính để sắp xếp (ví dụ: "CreatedDate", "Name").</param>
    /// <param name="sortDirection">Hướng sắp xếp ("asc" cho tăng dần, "desc" cho giảm dần).</param>
    /// <param name="includeProperties">Chuỗi các thuộc tính liên quan cần tải (comma-separated).</param>
    /// <param name="cancellationToken"></param>
    /// <returns>Danh sách các entity đã được lọc, sắp xếp và tải các thuộc tính liên quan.</returns>
    Task<List<T>> GetAsync(
        Expression<Func<T, bool>>? filter = null,
        string? sortBy = null,
        string? sortDirection = "asc",
        string includeProperties = "",
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Lấy danh sách các entity và trả về dưới dạng một danh sách đã phân trang.
    /// </summary>
    /// <param name="pagedParams">Các tham số phân trang (số trang, kích thước trang).</param>
    /// <param name="filter">Biểu thức điều kiện để lọc (có thể là null để lấy tất cả).</param>
    /// <param name="includeProperties">Chuỗi các thuộc tính liên quan cần tải (comma-separated).</param>
    /// <param name="cancellationToken"></param>
    /// <returns>Một đối tượng PagedList&lt;T&gt; chứa danh sách các entity và thông tin phân trang.</returns>
    Task<PagedList<T>> GetPagedAsync(
        PagedParams pagedParams,
        Expression<Func<T, bool>>? filter = null,
        string includeProperties = "",
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Kiểm tra xem có bất kỳ entity nào thỏa mãn điều kiện không.
    /// </summary>
    /// <param name="predicate">Biểu thức điều kiện để kiểm tra.</param>
    /// <param name="cancellationToken">Token để hủy bỏ thao tác.</param>
    /// <returns>True nếu có ít nhất một entity thỏa mãn, ngược lại là False.</returns>
    Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

    /// <summary>
    /// Đếm số lượng entity, có thể kèm theo điều kiện lọc.
    /// </summary>
    /// <param name="predicate">Biểu thức điều kiện để lọc (có thể là null để đếm tất cả).</param>
    /// <param name="cancellationToken">Token để hủy bỏ thao tác.</param>
    /// <returns>Tổng số lượng entity thỏa mãn điều kiện.</returns>
    Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null, CancellationToken cancellationToken = default);
}