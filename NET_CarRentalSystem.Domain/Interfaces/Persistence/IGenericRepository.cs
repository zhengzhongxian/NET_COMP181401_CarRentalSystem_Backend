using NET_CarRentalSystem.Shared.Enums;
using NET_CarRentalSystem.Shared.Pagination;
using System.Linq.Expressions;

namespace NET_CarRentalSystem.Domain.Interfaces.Persistence;

public interface IGenericRepository<T> where T : class
{
    /// <summary>
    /// Trả về một IQueryable&lt;T&gt; để xây dựng các truy vấn phức tạp và linh hoạt.
    /// Lưu ý: Việc thực thi truy vấn (ví dụ: ToListAsync()) nên được thực hiện ở tầng Persistence.
    /// </summary>
    IQueryable<T> GetQueryable();

    /// <summary>
    /// Lấy một entity theo ID duy nhất.
    /// </summary>
    /// <param name="id">ID của entity.</param>
    /// <param name="cancellationToken">Token để hủy bỏ thao tác.</param>
    /// <param name="useWriteConnection">Nếu là true, sử dụng kết nối ghi (write connection) thay vì kết nối đọc (read connection).</param>
    /// <returns>Entity tìm thấy hoặc null nếu không tìm thấy.</returns>
    Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default, bool useWriteConnection = false);

    /// <summary>
    /// Lấy tất cả các entity và trả về dưới dạng một List.
    /// </summary>
    /// <param name="cancellationToken">Token để hủy bỏ thao tác.</param>
    /// <returns>Danh sách tất cả các entity.</returns>
    Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Tìm kiếm các entity dựa trên một điều kiện lọc và trả về dưới dạng một List.
    /// Phương thức này không đảm bảo thứ tự sắp xếp mặc định.
    /// </summary>
    /// <param name="predicate">Biểu thức điều kiện để lọc các entity.</param>
    /// <param name="cancellationToken">Token để hủy bỏ thao tác.</param>
    /// <returns>Danh sách các entity thỏa mãn điều kiện.</returns>
    Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

    /// <summary>
    /// Thêm một entity mới vào cơ sở dữ liệu.
    /// </summary>
    /// <param name="entity">Entity cần thêm.</param>
    /// <param name="cancellationToken">Token để hủy bỏ thao tác.</param>
    /// <returns>Một Task đại diện cho thao tác bất đồng bộ.</returns>
    Task AddAsync(T entity, CancellationToken cancellationToken = default);

    /// <summary>
    /// Cập nhật một entity hiện có trong cơ sở dữ liệu.
    /// </summary>
    /// <param name="entity">Entity cần cập nhật.</param>
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
    /// <param name="filter">Biểu thức điều kiện để lọc.</param>
    /// <param name="includeProperties">Chuỗi các thuộc tính liên quan cần tải (comma-separated).</param>
    /// <param name="cancellationToken">Token để hủy bỏ thao tác.</param>
    /// <param name="useWriteConnection">Nếu là true, sử dụng kết nối ghi.</param>
    /// <returns>Entity đầu tiên thỏa mãn điều kiện hoặc null.</returns>
    Task<T?> GetFirstOrDefaultAsync(
        Expression<Func<T, bool>> filter,
        string includeProperties = "",
        CancellationToken cancellationToken = default,
        bool useWriteConnection = false);

    /// <summary>
    /// Lấy ra entity duy nhất khớp với điều kiện. Ném ra exception nếu có nhiều hơn một kết quả.
    /// </summary>
    /// <param name="filter">Biểu thức điều kiện để lọc.</param>
    /// <param name="includeProperties">Chuỗi các thuộc tính liên quan cần tải (comma-separated).</param>
    /// <param name="cancellationToken">Token để hủy bỏ thao tác.</param>
    /// <param name="useWriteConnection">Nếu là true, sử dụng kết nối ghi.</param>
    /// <returns>Entity duy nhất thỏa mãn điều kiện hoặc null.</returns>
    Task<T?> GetSingleOrDefaultAsync(
        Expression<Func<T, bool>> filter,
        string includeProperties = "",
        CancellationToken cancellationToken = default,
        bool useWriteConnection = false);

    /// <summary>
    /// Lấy danh sách các entity một cách linh hoạt với các tùy chọn lọc, sắp xếp động và include.
    /// </summary>
    /// <param name="filter">Biểu thức điều kiện để lọc (có thể là null để lấy tất cả).</param>
    /// <param name="sortBy">Tên thuộc tính để sắp xếp (ví dụ: "CreatedDate", "Name").</param>
    /// <param name="sortDirection">Hướng sắp xếp ("asc" cho tăng dần, "desc" cho giảm dần).</param>
    /// <param name="includeProperties">Chuỗi các thuộc tính liên quan cần tải (comma-separated).</param>
    /// <returns>Danh sách các entity đã được lọc, sắp xếp và tải các thuộc tính liên quan.</returns>
    Task<List<T>> GetAsync(
        Expression<Func<T, bool>>? filter = null,
        string? sortBy = null,
        string? sortDirection = "asc",
        string includeProperties = "");


    /// <summary>
    /// Lấy danh sách các entity và trả về dưới dạng một danh sách đã phân trang.
    /// </summary>
    /// <param name="pagingParams">Các tham số phân trang (số trang, kích thước trang).</param>
    /// <param name="filter">Biểu thức điều kiện để lọc (có thể là null để lấy tất cả).</param>
    /// <param name="includeProperties">Chuỗi các thuộc tính liên quan cần tải (comma-separated).</param>
    /// <returns>Một đối tượng PagedList&lt;T&gt; chứa danh sách các entity và thông tin phân trang.</returns>
    Task<PagedList<T>> GetPagedAsync(
        PagingParams pagingParams,
        Expression<Func<T, bool>>? filter = null,
        string includeProperties = "");

    /// <summary>
    /// Kiểm tra xem có bất kỳ entity nào thỏa mãn điều kiện không.
    /// </summary>
    /// <param name="predicate">Biểu thức điều kiện để kiểm tra.</param>
    /// <param name="cancellationToken">Token để hủy bỏ thao tác.</param>
    /// <returns>True nếu có ít nhất một entity thỏa mãn, ngược lại là False.</returns>
    Task<bool> ExistsAsync(
        Expression<Func<T, bool>> predicate, 
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Đếm số lượng entity, có thể kèm theo điều kiện lọc.
    /// </summary>
    /// <param name="predicate">Biểu thức điều kiện để lọc (có thể là null để đếm tất cả).</param>
    /// <param name="cancellationToken">Token để hủy bỏ thao tác.</param>
    /// <returns>Tổng số lượng entity thỏa mãn điều kiện.</returns>
    Task<int> CountAsync(
        Expression<Func<T, bool>>? predicate = null, 
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Lấy giá trị tổng hợp (Min hoặc Max) của một thuộc tính được chỉ định.
    /// </summary>
    /// <typeparam name="TResult">Kiểu dữ liệu của giá trị tổng hợp.</typeparam>
    /// <param name="selector">Biểu thức chọn thuộc tính để tính tổng hợp.</param>
    /// <param name="aggregateType">Loại tổng hợp cần thực hiện (Min hoặc Max).</param>
    /// <param name="filter">Biểu thức điều kiện để lọc (có thể là null).</param>
    /// <param name="cancellationToken">Token để hủy bỏ thao tác.</param>
    /// <returns>Giá trị tổng hợp (Min hoặc Max).</returns>
    Task<TResult> GetAggregateValueAsync<TResult>(
        Expression<Func<T, TResult>> selector,
        AggregateType aggregateType,
        Expression<Func<T, bool>>? filter = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Lấy entity đầu tiên thỏa mãn điều kiện. Ném ra exception nếu không tìm thấy.
    /// </summary>
    /// <param name="predicate">Biểu thức điều kiện để lọc.</param>
    /// <param name="cancellationToken">Token để hủy bỏ thao tác.</param>
    /// <returns>Entity đầu tiên thỏa mãn điều kiện.</returns>
    Task<T> FirstAsync(
        Expression<Func<T, bool>> predicate,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Thực thi một câu lệnh SQL nội suy (interpolated SQL) và trả về số hàng bị ảnh hưởng.
    /// Thích hợp cho các thao tác INSERT, UPDATE, DELETE hoặc các lệnh DDL.
    /// </summary>
    /// <param name="sql">Câu lệnh SQL nội suy.</param>
    /// <param name="cancellationToken">Token để hủy bỏ thao tác.</param>
    /// <returns>Số hàng bị ảnh hưởng bởi câu lệnh SQL.</returns>
    Task<int> ExecuteSqlInterpolatedAsync(
        FormattableString sql, 
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Thực thi một câu lệnh SQL nội suy và trả về danh sách các entity của kiểu T.
    /// </summary>
    /// <param name="sql">Câu lệnh SQL nội suy.</param>
    /// <param name="cancellationToken">Token để hủy bỏ thao tác.</param>
    /// <returns>Danh sách các entity kiểu T được ánh xạ từ kết quả SQL.</returns>
    Task<List<T>> FromSqlInterpolatedAsync(
        FormattableString sql,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Lấy entity với các include properties bị soft-delete.
    /// Entity chính vẫn áp dụng query filters (như soft-delete),
    /// nhưng các include properties sẽ bỏ qua query filters.
    /// </summary>
    /// <param name="filter">Biểu thức điều kiện để lọc entity chính.</param>
    /// <param name="includeProperties">Chuỗi các thuộc tính liên quan cần tải (comma-separated).</param>
    /// <param name="cancellationToken">Token để hủy bỏ thao tác.</param>
    /// <param name="useWriteConnection">Nếu là true, sử dụng kết nối ghi.</param>
    /// <returns>Entity đầu tiên thỏa mãn điều kiện hoặc null.</returns>
    Task<T?> GetFirstOrDefaultWithDeletedIncludesAsync(
        Expression<Func<T, bool>> filter,
        string includeProperties = "",
        CancellationToken cancellationToken = default,
        bool useWriteConnection = false);

    IQueryable<T> GetQueryable(
        Expression<Func<T, bool>>? filter,
        string includeProperties = "");
}
