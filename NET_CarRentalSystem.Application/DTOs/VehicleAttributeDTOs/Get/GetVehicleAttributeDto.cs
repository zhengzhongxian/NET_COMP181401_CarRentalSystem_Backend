﻿namespace NET_CarRentalSystem.Application.DTOs.VehicleAttributeDTOs.Get;

public class GetVehicleAttributeDto
{
    public Guid AttributeId { get; set; }

    public string? AttributeKey { get; set; }

    public string? AttributeValue { get; set; }
}