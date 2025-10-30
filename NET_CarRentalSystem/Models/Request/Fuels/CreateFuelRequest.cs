﻿using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.API.Models.Request.Fuels;

public class CreateFuelRequest
{
    [Required]
    public string Name { get; set; }
    public string? Description { get; set; }
}