using MediatR;
using NET_CarRentalSystem.Application.Features.Impersonation.Commands.GenerateDevCode;

namespace NET_CarRentalSystem.Application.Features.Impersonation.Queries;

public record GetDevCodeQuery : IRequest<DevCodeSessionData?>;
