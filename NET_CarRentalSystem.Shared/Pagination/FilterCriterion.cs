namespace NET_CarRentalSystem.Shared.Pagination;

public class FilterCriterion
{
    public string? Field { get; set; } = default!;

    public string? Value { get; set; } = default!;
}