namespace NET_CarRentalSystem.API.Models.Response.Locations;

public class GetLocationsPagedResponse
{
    public required List<GetLocationResponse> Items { get; set; }
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
    public int PageSize { get; set; }
    public int TotalCount { get; set; }
    public bool HasPrevious { get; set; }
    public bool HasNext { get; set; }
}