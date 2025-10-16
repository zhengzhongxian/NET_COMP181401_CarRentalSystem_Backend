namespace NET_CarRentalSystem.Application.Features.Fuels.Queries.GetAllFuelsQuery;

public class FuelDto
{
    public Guid FuelId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
}
