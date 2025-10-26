namespace NET_CarRentalSystem.Infrastructure.Interfaces;

public interface IApiClient
{
    /// <summary>
    /// Gửi GET request và trả về kết quả dạng T
    /// </summary>
    /// <typeparam name="T">Kiểu dữ liệu trả về</typeparam>
    /// <param name="endpoint">Đường dẫn API</param>
    /// <param name="headers">Headers tùy chọn</param>
    /// <param name="cancellationToken">Token hủy bỏ</param>
    /// <returns>Kết quả dạng T</returns>
    Task<T?> GetAsync<T>(string endpoint, Dictionary<string, string>? headers = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gửi GET request và trả về string
    /// </summary>
    /// <param name="endpoint">Đường dẫn API</param>
    /// <param name="headers">Headers tùy chọn</param>
    /// <param name="cancellationToken">Token hủy bỏ</param>
    /// <returns>Kết quả dạng string</returns>
    Task<string> GetStringAsync(string endpoint, Dictionary<string, string>? headers = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gửi POST request với JSON body
    /// </summary>
    /// <typeparam name="TRequest">Kiểu dữ liệu request</typeparam>
    /// <typeparam name="TResponse">Kiểu dữ liệu response</typeparam>
    /// <param name="endpoint">Đường dẫn API</param>
    /// <param name="data">Dữ liệu gửi đi</param>
    /// <param name="headers">Headers tùy chọn</param>
    /// <param name="cancellationToken">Token hủy bỏ</param>
    /// <returns>Kết quả dạng TResponse</returns>
    Task<TResponse?> PostAsync<TRequest, TResponse>(string endpoint, TRequest data, Dictionary<string, string>? headers = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gửi POST request với form-data
    /// </summary>
    /// <typeparam name="T">Kiểu dữ liệu response</typeparam>
    /// <param name="endpoint">Đường dẫn API</param>
    /// <param name="formData">Dữ liệu form-data</param>
    /// <param name="headers">Headers tùy chọn</param>
    /// <param name="cancellationToken">Token hủy bỏ</param>
    /// <returns>Kết quả dạng T</returns>
    Task<T?> PostFormDataAsync<T>(string endpoint, Dictionary<string, object> formData, Dictionary<string, string>? headers = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gửi POST request với MultipartFormDataContent (hỗ trợ file upload)
    /// </summary>
    /// <typeparam name="T">Kiểu dữ liệu response</typeparam>
    /// <param name="endpoint">Đường dẫn API</param>
    /// <param name="content">MultipartFormDataContent</param>
    /// <param name="headers">Headers tùy chọn</param>
    /// <param name="cancellationToken">Token hủy bỏ</param>
    /// <returns>Kết quả dạng T</returns>
    Task<T?> PostMultipartAsync<T>(string endpoint, MultipartFormDataContent content, Dictionary<string, string>? headers = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gửi PUT request với JSON body
    /// </summary>
    /// <typeparam name="TRequest">Kiểu dữ liệu request</typeparam>
    /// <typeparam name="TResponse">Kiểu dữ liệu response</typeparam>
    /// <param name="endpoint">Đường dẫn API</param>
    /// <param name="data">Dữ liệu gửi đi</param>
    /// <param name="headers">Headers tùy chọn</param>
    /// <param name="cancellationToken">Token hủy bỏ</param>
    /// <returns>Kết quả dạng TResponse</returns>
    Task<TResponse?> PutAsync<TRequest, TResponse>(string endpoint, TRequest data, Dictionary<string, string>? headers = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gửi PUT request với form-data
    /// </summary>
    /// <typeparam name="T">Kiểu dữ liệu response</typeparam>
    /// <param name="endpoint">Đường dẫn API</param>
    /// <param name="formData">Dữ liệu form-data</param>
    /// <param name="headers">Headers tùy chọn</param>
    /// <param name="cancellationToken">Token hủy bỏ</param>
    /// <returns>Kết quả dạng T</returns>
    Task<T?> PutFormDataAsync<T>(string endpoint, Dictionary<string, object> formData, Dictionary<string, string>? headers = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gửi PUT request với MultipartFormDataContent
    /// </summary>
    /// <typeparam name="T">Kiểu dữ liệu response</typeparam>
    /// <param name="endpoint">Đường dẫn API</param>
    /// <param name="content">MultipartFormDataContent</param>
    /// <param name="headers">Headers tùy chọn</param>
    /// <param name="cancellationToken">Token hủy bỏ</param>
    /// <returns>Kết quả dạng T</returns>
    Task<T?> PutMultipartAsync<T>(string endpoint, MultipartFormDataContent content, Dictionary<string, string>? headers = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gửi PATCH request với JSON body
    /// </summary>
    /// <typeparam name="TRequest">Kiểu dữ liệu request</typeparam>
    /// <typeparam name="TResponse">Kiểu dữ liệu response</typeparam>
    /// <param name="endpoint">Đường dẫn API</param>
    /// <param name="data">Dữ liệu gửi đi</param>
    /// <param name="headers">Headers tùy chọn</param>
    /// <param name="cancellationToken">Token hủy bỏ</param>
    /// <returns>Kết quả dạng TResponse</returns>
    Task<TResponse?> PatchAsync<TRequest, TResponse>(string endpoint, TRequest data, Dictionary<string, string>? headers = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gửi DELETE request
    /// </summary>
    /// <param name="endpoint">Đường dẫn API</param>
    /// <param name="headers">Headers tùy chọn</param>
    /// <param name="cancellationToken">Token hủy bỏ</param>
    /// <returns>True nếu thành công</returns>
    Task<bool> DeleteAsync(string endpoint, Dictionary<string, string>? headers = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gửi DELETE request và trả về kết quả
    /// </summary>
    /// <typeparam name="T">Kiểu dữ liệu response</typeparam>
    /// <param name="endpoint">Đường dẫn API</param>
    /// <param name="headers">Headers tùy chọn</param>
    /// <param name="cancellationToken">Token hủy bỏ</param>
    /// <returns>Kết quả dạng T</returns>
    Task<T?> DeleteAsync<T>(string endpoint, Dictionary<string, string>? headers = null, CancellationToken cancellationToken = default);
}
