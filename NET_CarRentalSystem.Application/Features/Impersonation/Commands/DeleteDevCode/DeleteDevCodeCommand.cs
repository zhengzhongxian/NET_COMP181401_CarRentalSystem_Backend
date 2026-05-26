using MediatR;

namespace NET_CarRentalSystem.Application.Features.Impersonation.Commands.DeleteDevCode;

public record DeleteDevCodeCommand : IRequest<(string Message, bool Success)>;
