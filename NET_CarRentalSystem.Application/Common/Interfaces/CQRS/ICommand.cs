using MediatR;

namespace NET_CarRentalSystem.Application.Common.Interfaces.CQRS;

public interface ICommand<out TResponse> : IRequest<TResponse>;

public interface ICommand : IRequest;

