﻿namespace NET_CarRentalSystem.Domain.Entities;

public class UserToken
{
    public Guid UserId { get; set; }

    public string LoginProvider { get; set; }

    public string Name { get; set; }

    public string Value { get; set; }

    public virtual User User { get; set; }
}