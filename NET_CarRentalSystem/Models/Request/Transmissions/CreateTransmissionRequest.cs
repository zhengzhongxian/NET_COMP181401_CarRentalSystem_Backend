using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.API.Models.Request.Transmissions;

public class CreateTransmissionRequest
{
    [Required]
    public required string Name { get; set; } = default!;

    [Required] public required string Code { get; set; } = default!;

    public string? Description { get; set; } = default!;
}

