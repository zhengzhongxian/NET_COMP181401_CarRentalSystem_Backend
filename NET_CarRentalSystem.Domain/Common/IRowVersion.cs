namespace NET_CarRentalSystem.Domain.Common;

public interface IRowVersion
{
    byte[] RowVersion { get; set; }
}

