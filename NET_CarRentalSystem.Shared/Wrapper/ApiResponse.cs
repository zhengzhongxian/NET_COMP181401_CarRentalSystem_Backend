using NET_CarRentalSystem.Shared.Pagination;
using System.Net;
using System.Text.Json.Serialization;

namespace NET_CarRentalSystem.Shared.Wrapper;

public class ApiResponse<T>
{
    [JsonPropertyName("statusCode")]
    public int StatusCode { get; set; }

    [JsonPropertyName("isSuccess")]
    public bool IsSuccess { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("data")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public T? Data { get; set; }

    [JsonPropertyName("metadata")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public object? Metadata { get; set; }

    [JsonPropertyName("errors")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IEnumerable<string>? Errors { get; set; }

    public static ApiResponse<T> Success(T data, string message = "Request successful.")
    {
        return new ApiResponse<T>
        {
            IsSuccess = true,
            StatusCode = (int)HttpStatusCode.OK,
            Message = message,
            Data = data
        };
    }

    public static ApiResponse<IEnumerable<T>> Success(PagedList<T> pagedData, string message = "Request successful.")
    {
        var metadata = new
        {
            pagedData.TotalCount,
            pagedData.PageSize,
            pagedData.CurrentPage,
            pagedData.TotalPages,
            pagedData.HasNext,
            pagedData.HasPrevious
        };

        return new ApiResponse<IEnumerable<T>>
        {
            IsSuccess = true,
            StatusCode = (int)HttpStatusCode.OK,
            Message = message,
            Data = pagedData.Items,
            Metadata = metadata
        };
    }

    public static ApiResponse<T> Fail(string message, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
    {
        return new ApiResponse<T>
        {
            IsSuccess = false,
            StatusCode = (int)statusCode,
            Message = message
        };
    }

    public static ApiResponse<T> Error(string errorMessage, HttpStatusCode statusCode = HttpStatusCode.InternalServerError, IEnumerable<string>? errors = null)
    {
        return new ApiResponse<T>
        {
            IsSuccess = false,
            StatusCode = (int)statusCode,
            Message = errorMessage,
            Errors = errors
        };
    }
}

