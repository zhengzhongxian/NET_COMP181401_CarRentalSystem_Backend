namespace NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;

public class BranchVehicleStatusDto
{
    public string BranchName { get; set; } = string.Empty;
    public int TotalVehicles { get; set; }
    public List<VehicleStatusCountDto> Statuses { get; set; } = [];
}

public class VehicleStatusCountDto
{
    public string Name { get; set; } = string.Empty;
    public int Count { get; set; }
    public double Percentage { get; set; }
}
