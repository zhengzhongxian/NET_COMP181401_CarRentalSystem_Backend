using MediatR;

namespace NET_CarRentalSystem.Application.Features.Impersonation.Commands.GenerateDevCode;

public record GenerateDevCodeCommand : IRequest<(string Message, string? Code)>;
