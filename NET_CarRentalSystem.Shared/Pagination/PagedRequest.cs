using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Shared.Pagination;

public class PagedRequest
{
    private int _pageSize = AppConstants.Pagination.MinPageSize;

    public int PageNumber { get; set; } = 1;

    public int PageSize
    {
        get => _pageSize;
        set => _pageSize = value switch
        {
            > AppConstants.Pagination.MaxPageSize => AppConstants.Pagination.MaxPageSize,
            < AppConstants.Pagination.MinPageSize => AppConstants.Pagination.MinPageSize,
            _ => value
        };
    }

    public string? SearchKeyword { get; set; }

    public string? SortBy { get; set; }

    public string? SortDirection { get; set; } = "asc";
}