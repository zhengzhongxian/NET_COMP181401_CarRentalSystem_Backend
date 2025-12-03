namespace NET_CarRentalSystem.Domain.Interfaces.Persistence;

public interface IRawSqlRepository
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
}
