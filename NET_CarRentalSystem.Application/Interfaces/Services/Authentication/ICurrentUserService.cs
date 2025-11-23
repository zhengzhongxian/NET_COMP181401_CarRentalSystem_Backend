namespace NET_CarRentalSystem.Application.Interfaces.Services.Authentication;

public interface ICurrentUserService
{
    Guid? GetUserId();
}

