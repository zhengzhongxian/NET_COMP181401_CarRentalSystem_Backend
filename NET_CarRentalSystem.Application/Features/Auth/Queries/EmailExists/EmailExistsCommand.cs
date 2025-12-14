using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Auth.Queries.EmailExists;

public class EmailExistsCommand : ICommand<(bool, string)>
{
    public required string Email { get; init; }
}

public class EmailExistsCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<EmailExistsCommand, (bool, string)>
{
    public async Task<(bool, string)> Handle(EmailExistsCommand request, CancellationToken cancellationToken)
    {
        var userReadRepository = unitOfWork.GetReadRepository<User>();
        var existingUser = await userReadRepository.ExistsAsync(
            u => u.Email == request.Email, 
            cancellationToken: cancellationToken);

        return existingUser ? (true, AuthMessage.CheckEmailExists.Existed) : (false, AuthMessage.CheckEmailExists.NotExisted);
    }
}