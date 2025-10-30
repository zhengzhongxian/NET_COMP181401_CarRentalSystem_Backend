﻿using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.API.Models.Request.Fuels;

public class UpdateFuelRequest
{
    [Required]
    public string Name { get; set; }
    public string? Description { get; set; }
}