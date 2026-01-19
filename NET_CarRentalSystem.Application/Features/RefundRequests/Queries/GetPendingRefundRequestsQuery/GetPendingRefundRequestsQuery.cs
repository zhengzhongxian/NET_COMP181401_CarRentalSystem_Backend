using MediatR;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.RefundRequestDTOs;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.Application.Features.RefundRequests.Queries.GetPendingRefundRequestsQuery;

public class GetPendingRefundRequestsQuery : IQuery<PagedList<RefundRequestDto>>
{
    public required GetPendingRefundRequestsQueryParams RequestParams { get; set; }
}

public class GetPendingRefundRequestsQueryHandler(
    IUnitOfWork unitOfWork) : IRequestHandler<GetPendingRefundRequestsQuery, PagedList<RefundRequestDto>>
{
    public async Task<PagedList<RefundRequestDto>> Handle(GetPendingRefundRequestsQuery request, CancellationToken cancellationToken)
    {
        var queryParams = request.RequestParams;
        
        var query = from refundRequest in unitOfWork.GetReadRepository<RefundRequest>().GetQueryable()
            join bookingFlat in unitOfWork.GetReadRepository<BookingReadFlat>().GetQueryable()
                on refundRequest.BookingId equals bookingFlat.BookingId into bookingGroup
            from booking in bookingGroup.DefaultIfEmpty()
            join customer in unitOfWork.GetReadRepository<Customer>().GetQueryable()
                on refundRequest.CustomerId equals customer.CustomerId into customerGroup
            from cust in customerGroup.DefaultIfEmpty()
            join user in unitOfWork.GetReadRepository<User>().GetQueryable()
                on cust.UserId equals user.Id into userGroup
            from usr in userGroup.DefaultIfEmpty()
            join vehicle in unitOfWork.GetReadRepository<VehicleReadFlat>().GetQueryable()
                on booking.VehicleId equals vehicle.Id into vehicleGroup
            from veh in vehicleGroup.DefaultIfEmpty()
            where refundRequest.Status == RefundStatus.Pending
            select new RefundRequestDto
            {
                Id = refundRequest.Id,
                BookingId = refundRequest.BookingId,
                CustomerId = refundRequest.CustomerId,
                CustomerName = cust != null ? cust.FirstName + " " + cust.LastName : "Unknown",
                CustomerEmail = usr != null ? usr.Email : null,
                CustomerPhone = cust != null ? cust.PhoneNumber : null,
                VehicleName = veh != null ? veh.Manufacturer + " " + veh.Model : "Unknown",
                Amount = refundRequest.Amount,
                Status = refundRequest.Status,
                Reason = refundRequest.Reason,
                AdminNotes = refundRequest.AdminNotes,
                CreatedAt = refundRequest.CreatedAt,
                ApprovedAt = refundRequest.ApprovedAt,
                ProcessedAt = refundRequest.ProcessedAt
            };
        
        if (!string.IsNullOrWhiteSpace(queryParams.SearchKeyword))
        {
            var keyword = queryParams.SearchKeyword.Trim().ToLower();
            query = query.Where(r =>
                (r.CustomerName != null && r.CustomerName.ToLower().Contains(keyword)) ||
                (r.CustomerEmail != null && r.CustomerEmail.ToLower().Contains(keyword)) ||
                (r.CustomerPhone != null && r.CustomerPhone.Contains(keyword)));
        }
        
        query = queryParams.SortDirection?.ToLower() == "asc"
            ? query.OrderBy(r => r.CreatedAt)
            : query.OrderByDescending(r => r.CreatedAt);
        
        return await query.ToPagedListAsync(queryParams.PageNumber, queryParams.PageSize, cancellationToken);
    }
}
