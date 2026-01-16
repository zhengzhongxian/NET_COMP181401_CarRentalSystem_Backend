﻿using NET_CarRentalSystem.Domain.Common;

namespace NET_CarRentalSystem.Domain.Entities;

public class Fuel : BaseEntity<Guid>, IRowVersion
{
    public string Name { get; set; }
    
    public string? Description { get; set; }

    public byte[] RowVersion { get; set; } = [];
    
    public virtual ICollection<Vehicle> Vehicles { get; set; } = [];
}
