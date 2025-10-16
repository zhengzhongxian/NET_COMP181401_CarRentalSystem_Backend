using MediatR;

namespace NET_CarRentalSystem.Application.Common.Interfaces.CQRS;

public interface IQuery<out TResponse> : IRequest<TResponse>;
