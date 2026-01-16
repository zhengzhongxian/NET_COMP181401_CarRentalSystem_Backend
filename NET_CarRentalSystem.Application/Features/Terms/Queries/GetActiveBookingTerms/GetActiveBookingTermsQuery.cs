using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.TermsDTOs;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Terms.Queries.GetActiveBookingTerms;

public class GetActiveBookingTermsQuery : IQuery<TermsAndConditionsDto?>
{
}

public class GetActiveBookingTermsQueryHandler(IUnitOfWork unitOfWork) 
    : IRequestHandler<GetActiveBookingTermsQuery, TermsAndConditionsDto?>
{
    public async Task<TermsAndConditionsDto?> Handle(GetActiveBookingTermsQuery request, CancellationToken cancellationToken)
    {
        var termsList = await unitOfWork.GetReadRepository<TermsAndConditions>()
            .GetAsync(
                filter: t => t.Type == TermsType.Booking && t.IsActive && t.EffectiveDate <= DateTime.UtcNow,
                sortBy: nameof(TermsAndConditions.EffectiveDate),
                sortDirection: "desc",
                cancellationToken: cancellationToken
            );

        var terms = termsList.FirstOrDefault();
        
        if (terms == null)
            return null;

        return new TermsAndConditionsDto
        {
            Id = terms.Id,
            Title = terms.Title,
            Content = terms.Content,
            Version = terms.Version,
            EffectiveDate = terms.EffectiveDate,
            Type = terms.Type
        };
    }
}

