namespace NET_CarRentalSystem.Application.Interfaces.Services;

public interface ICurrentUserService
{
    Guid? GetUserId();
}

