using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.InsuranceDTOs;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Insurances.Queries.GetActiveInsurancePackages;

public class GetActiveInsurancePackagesQuery : IQuery<List<InsurancePackageDto>>;

public class GetActiveInsurancePackagesQueryHandler(IUnitOfWork unitOfWork) 
    : IRequestHandler<GetActiveInsurancePackagesQuery, List<InsurancePackageDto>>
{
    public async Task<List<InsurancePackageDto>> Handle(GetActiveInsurancePackagesQuery request, CancellationToken cancellationToken)
    {
        var insurances = await unitOfWork.GetWriteRepository<InsurancePackage>()
            .GetAsync(
                filter: i => i.IsActive,
                sortBy: nameof(InsurancePackage.DisplayOrder),
                sortDirection: "asc",
                cancellationToken: cancellationToken
            );

        return insurances.Select(i => new InsurancePackageDto
        {
            Id = i.Id,
            Name = i.Name,
            Description = i.Description,
            Price = i.Price,
            CoverageAmount = i.CoverageAmount,
            CoverageDetails = i.CoverageDetails
        }).ToList();
    }
}

