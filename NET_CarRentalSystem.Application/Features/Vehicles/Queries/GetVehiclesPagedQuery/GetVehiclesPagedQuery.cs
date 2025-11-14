using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleAttributeDTOs.Get;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleDTOs.Get;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Pagination;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehiclesPagedQuery;

public class GetVehiclesPagedQuery : IQuery<PagedList<GetVehicleDto>>
{
    public required GetVehiclesPagedQueryParams QueryParams { get; set; }
}

public class GetVehiclesPagedQueryHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<GetVehiclesPagedQuery, PagedList<GetVehicleDto>>
{
    public async Task<PagedList<GetVehicleDto>> Handle(GetVehiclesPagedQuery request, CancellationToken cancellationToken)
    {
        var queryParam = request.QueryParams;
        var predicate = PredicateBuilder.True<Vehicle>();

        if (!string.IsNullOrWhiteSpace(queryParam.SearchKeyword))
        {
            var keyword = queryParam.SearchKeyword.ToLower();
            predicate = predicate.And(v =>
                v.NumberPlate.ToLower().Contains(keyword) ||
                v.Manufacturer.ToLower().Contains(keyword) ||
                v.Model.ToLower().Contains(keyword));
        }

        if (queryParam.Filters is { Count: > 0 })
        {
            var detailedFilter = ExpressionBuilder.BuildPredicate<Vehicle>(queryParam.Filters);
            predicate = predicate.And(detailedFilter);
        }

        var includeBuilder = new IncludeBuilder<Vehicle>()
            .Include(v => v.VehicleCategory)
            .Include(v => v.Fuel)
            .Include(v => v.Transmission)
            .Include(v => v.VehicleAttributes);
        
        var includeProperties = includeBuilder.Build();

        var pagedList = await unitOfWork.GetRepository<Vehicle>()
            .GetPagedAsync(queryParam, predicate, includeProperties);

        var vehicleDtos = pagedList.Items.Select(v => new GetVehicleDto
        {
            VehicleId = v.Id,
            NumberPlate = v.NumberPlate,
            Manufacturer = v.Manufacturer,
            Model = v.Model,
            Color = v.Color,
            Mileage = v.Mileage,
            PricePerHour = v.PricePerHour,
            Thumbnail = v.Thumbnail,
            LastCheckoutAt = v.LastCheckoutAt,
            Rating = v.Rating,
            Status = v.Status,
            ConditionNotes = v.ConditionNotes,
            RealTimeLocation = v.RealTimeLocation,
            LocationId = v.LocationId,
            LocationName = v.Location?.Name,
            VehicleCategoryId = v.VehicleCategoryId,
            FuelId = v.FuelId,
            TransmissionId = v.TransmissionId,
            VehicleCategoryCode = v.VehicleCategory?.CategoryCode,
            FuelName = v.Fuel?.Name,
            TransmissionName = v.Transmission?.Name,
            AttributeDtos = [.. v.VehicleAttributes.Select(va => new GetVehicleAttributeDto
            {
                AttributeId = va.AttributeId,
                AttributeKey = va.AttributeKey,
                AttributeValue = va.AttributeValue
            })],
        }).ToList();

        return new PagedList<GetVehicleDto>(
            vehicleDtos,
            pagedList.TotalCount,
            pagedList.CurrentPage,
            pagedList.PageSize);
    }
}

