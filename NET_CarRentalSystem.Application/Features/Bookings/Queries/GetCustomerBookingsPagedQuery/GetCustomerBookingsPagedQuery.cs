using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Models.DTOs.BookingDTOs.Get;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.Application.Features.Bookings.Queries.GetCustomerBookingsPagedQuery;

public class GetCustomerBookingsPagedQuery : IQuery<PagedList<GetBookingDto>>
{
    public required GetCustomerBookingsPagedQueryParams RequestParams { get; set; }
}

public class GetCustomerBookingsPagedQueryHandler(
    IDapperRepository dapperRepository,
    ICurrentUserService currentUserService,
    IUnitOfWork unitOfWork) 
    : IRequestHandler<GetCustomerBookingsPagedQuery, PagedList<GetBookingDto>>
{
    public async Task<PagedList<GetBookingDto>> Handle(GetCustomerBookingsPagedQuery request, CancellationToken cancellationToken)
    {
        var userId = currentUserService.GetUserId();
        
        var customer = await unitOfWork.GetWriteRepository<Customer>()
            .GetFirstOrDefaultAsync(c => c.UserId == userId, cancellationToken);
        
        if (customer == null)
        {
            return new PagedList<GetBookingDto>([], 0, request.RequestParams.PageNumber, request.RequestParams.PageSize);
        }
        
        var parameters = new Dictionary<string, object>();
        var query = request.RequestParams;
        
        var whereConditions = new List<string> { "b.is_deleted = 0", "b.customer_id = @CustomerId", "LOWER(b.status) <> 'pending'" };
        parameters["CustomerId"] = customer.CustomerId;
        
        if (!string.IsNullOrWhiteSpace(query.SearchKeyword))
        {
            var keyword = $"%{query.SearchKeyword.Trim()}%";
            
            whereConditions.Add("""
                (
                    b.number_plate LIKE @Keyword OR
                    b.pickup_location_name LIKE @Keyword
                )
            """);
            
            parameters["Keyword"] = keyword;
        }
        
        if (!string.IsNullOrWhiteSpace(query.Status))
        {
            whereConditions.Add("b.status = @Status");
            parameters["Status"] = query.Status;
        }
        
        if (query.StartDateFrom.HasValue)
        {
            whereConditions.Add("b.start_date >= @StartDateFrom");
            parameters["StartDateFrom"] = query.StartDateFrom.Value;
        }
        
        if (query.StartDateTo.HasValue)
        {
            whereConditions.Add("b.start_date <= @StartDateTo");
            parameters["StartDateTo"] = query.StartDateTo.Value;
        }
        
        var whereClause = string.Join(" AND ", whereConditions);
        
        var allowedSortColumns = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "StartDate", "b.start_date" },
            { "EndDate", "b.end_date" },
            { "TotalPrice", "b.total_price" },
            { "Created", "b.created_at" },
            { "Updated", "b.updated_at" },
            { "Status", "b.status" }
        };

        var sortBy = "b.created_at"; 
        
        if (!string.IsNullOrEmpty(query.SortBy) && allowedSortColumns.TryGetValue(query.SortBy, out var column))
        {
            sortBy = column;
        }
        
        var sortDirection = query.SortDirection?.ToLower() == "asc" ? "ASC" : "DESC";
        var orderByClause = $"ORDER BY {sortBy} {sortDirection}";
        
        var offset = (query.PageNumber - 1) * query.PageSize;
        parameters["Offset"] = offset;
        parameters["PageSize"] = query.PageSize;
        
        var countSql = $"SELECT COUNT(*) FROM booking_read_flat b WHERE {whereClause}";
        var totalCount = await dapperRepository.ExecuteScalarAsync<int>(countSql, parameters, cancellationToken: cancellationToken);
        
        var dataSql = $"""
            SELECT
                b.booking_id_src AS BookingId,
                b.customer_id AS CustomerId,
                b.customer_name AS CustomerName,
                b.customer_email AS CustomerEmail,
                b.customer_phone AS CustomerPhone,
                b.vehicle_id AS VehicleId,
                CONCAT(v.manufacturer, ' ', v.model) AS VehicleName,
                b.vehicle_price_per_hour AS VehiclePricePerHour,
                b.vehicle_model_id AS VehicleModelId,
                b.number_plate AS NumberPlate,
                b.pickup_location_name AS PickupLocationName,
                b.return_location_name AS ReturnLocationName,
                b.file_name AS FileName,
                b.status AS Status,
                b.start_date AS StartDate,
                b.end_date AS EndDate,
                b.total_price AS TotalPrice,
                b.deposit_ratio AS DepositRatio,
                b.discount_rate AS DiscountRate,
                b.created_at AS CreatedAt
            FROM booking_read_flat b
            LEFT JOIN vehicle_read_flat v ON b.vehicle_id = v.vehicle_id
            WHERE {whereClause}
            {orderByClause}
            OFFSET @Offset ROWS
            FETCH NEXT @PageSize ROWS ONLY
        """;

        var bookings = await dapperRepository.QueryAsync<GetBookingDto>(dataSql, parameters, cancellationToken: cancellationToken);

        return new PagedList<GetBookingDto>(
            bookings.ToList(),
            totalCount,
            query.PageNumber,
            query.PageSize);
    }
}
