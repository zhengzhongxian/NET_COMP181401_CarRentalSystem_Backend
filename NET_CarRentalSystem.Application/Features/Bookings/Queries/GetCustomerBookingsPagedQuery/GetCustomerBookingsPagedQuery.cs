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
        
        var whereConditions = new List<string> { "is_deleted = 0", "customer_id = @CustomerId", "LOWER(status) <> 'pending'" };
        parameters["CustomerId"] = customer.CustomerId;
        
        if (!string.IsNullOrWhiteSpace(query.SearchKeyword))
        {
            var keyword = $"%{query.SearchKeyword.Trim()}%";
            
            whereConditions.Add("""
                (
                    number_plate LIKE @Keyword OR
                    pickup_location_name LIKE @Keyword
                )
            """);
            
            parameters["Keyword"] = keyword;
        }
        
        if (!string.IsNullOrWhiteSpace(query.Status))
        {
            whereConditions.Add("status = @Status");
            parameters["Status"] = query.Status;
        }
        
        if (query.StartDateFrom.HasValue)
        {
            whereConditions.Add("start_date >= @StartDateFrom");
            parameters["StartDateFrom"] = query.StartDateFrom.Value;
        }
        
        if (query.StartDateTo.HasValue)
        {
            whereConditions.Add("start_date <= @StartDateTo");
            parameters["StartDateTo"] = query.StartDateTo.Value;
        }
        
        var whereClause = string.Join(" AND ", whereConditions);
        
        var allowedSortColumns = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "StartDate", "start_date" },
            { "EndDate", "end_date" },
            { "TotalPrice", "total_price" },
            { "Created", "created_at" },
            { "Updated", "updated_at" },
            { "Status", "status" }
        };

        var sortBy = "created_at"; 
        
        if (!string.IsNullOrEmpty(query.SortBy) && allowedSortColumns.TryGetValue(query.SortBy, out var column))
        {
            sortBy = column;
        }
        
        var sortDirection = query.SortDirection?.ToLower() == "asc" ? "ASC" : "DESC";
        var orderByClause = $"ORDER BY {sortBy} {sortDirection}";
        
        var offset = (query.PageNumber - 1) * query.PageSize;
        parameters["Offset"] = offset;
        parameters["PageSize"] = query.PageSize;
        
        var countSql = $"SELECT COUNT(*) FROM booking_read_flat WHERE {whereClause}";
        var totalCount = await dapperRepository.ExecuteScalarAsync<int>(countSql, parameters, cancellationToken: cancellationToken);
        
        var dataSql = $"""
            SELECT
                booking_id_src AS BookingId,
                customer_id AS CustomerId,
                customer_name AS CustomerName,
                customer_email AS CustomerEmail,
                customer_phone AS CustomerPhone,
                vehicle_id AS VehicleId,
                vehicle_price_per_hour AS VehiclePricePerHour,
                vehicle_model_id AS VehicleModelId,
                number_plate AS NumberPlate,
                pickup_location_name AS PickupLocationName,
                return_location_name AS ReturnLocationName,
                file_name AS FileName,
                status AS Status,
                start_date AS StartDate,
                end_date AS EndDate,
                total_price AS TotalPrice,
                deposit_ratio AS DepositRatio,
                discount_rate AS DiscountRate,
                created_at AS CreatedAt
            FROM booking_read_flat
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
