using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Auth.Queries.PhoneNumberExists;

public class PhoneNumberExistsCommand : ICommand<(bool, string)>
{
    public required string PhoneNumber { get; init; }
}

public class PhoneNumberExistsCommandHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<PhoneNumberExistsCommand, (bool, string)>
{
    public async Task<(bool, string)> Handle(PhoneNumberExistsCommand request, CancellationToken cancellationToken)
    {
        var customerReadRepository = unitOfWork.GetReadRepository<Customer>();
        var existingCustomerByPhone = await customerReadRepository.ExistsAsync(
            c => c.PhoneNumber == request.PhoneNumber, 
            cancellationToken: cancellationToken);
        
        return existingCustomerByPhone ? (true, AuthMessage.CheckEmailExists.Existed) : (false, AuthMessage.CheckPhoneNumberExists.NotExisted);
    }
}