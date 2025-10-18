namespace NET_CarRentalSystem.Shared.Pagination;

public class PagedResponse<T>
{
    public int CurrentPage { get; set; }

    public int TotalPages { get; set; }

    public int PageSize { get; set; }

    public int TotalCount { get; set; }

    public bool HasPrevious { get; set; }

    public bool HasNext { get; set; }


    public List<T> Items { get; set; } = [];

    public static PagedResponse<T> FromPagedList(PagedList<T> pagedList)
    {
        return new PagedResponse<T>
        {
            CurrentPage = pagedList.CurrentPage,
            TotalPages = pagedList.TotalPages,
            PageSize = pagedList.PageSize,
            TotalCount = pagedList.TotalCount,
            HasPrevious = pagedList.HasPrevious,
            HasNext = pagedList.HasNext,
            Items = pagedList.Items
        };
    }
}
