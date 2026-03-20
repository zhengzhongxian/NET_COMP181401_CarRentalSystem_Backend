namespace NET_CarRentalSystem.API.Models.Response.Dashboard;

public class BranchVehicleStatusResponse
{
    public string BranchName { get; set; } = string.Empty;
    public int TotalVehicles { get; set; }
    public List<VehicleStatusCountResponse> Statuses { get; set; } = [];
}

public class VehicleStatusCountResponse
{
    public string Name { get; set; } = string.Empty;
    public int Count { get; set; }
    public double Percentage { get; set; }
}
