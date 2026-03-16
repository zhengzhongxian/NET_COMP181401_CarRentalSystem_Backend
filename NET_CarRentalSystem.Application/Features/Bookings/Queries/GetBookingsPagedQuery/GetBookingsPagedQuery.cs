using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Application.Models.DTOs.BookingDTOs.Get;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.Application.Features.Bookings.Queries.GetBookingsPagedQuery;

public class GetBookingsPagedQuery : IQuery<PagedList<GetBookingDto>>
{
    public required GetBookingsPagedQueryParams RequestParams { get; set; }
}

public class GetBookingsPagedQueryHandler(
    IDapperRepository dapperRepository,
    ICryptographyService cryptographyService) : IRequestHandler<GetBookingsPagedQuery, PagedList<GetBookingDto>>
{
    public async Task<PagedList<GetBookingDto>> Handle(GetBookingsPagedQuery request, CancellationToken cancellationToken)
    {
        var parameters = new Dictionary<string, object>();
        var query = request.RequestParams;
        
        var whereConditions = new List<string> { "is_deleted = 0" };
        
        if (!string.IsNullOrWhiteSpace(query.SearchKeyword))
        {
            var keyword = $"%{query.SearchKeyword.Trim()}%";
            
            whereConditions.Add("""
                (
                    customer_name LIKE @Keyword OR 
                    customer_email LIKE @Keyword OR 
                    customer_phone LIKE @Keyword OR
                    number_plate LIKE @Keyword
                )
            """);
            
            parameters["Keyword"] = keyword;
        }
        
        if (!string.IsNullOrWhiteSpace(query.Status))
        {
            whereConditions.Add("status = @Status");
            parameters["Status"] = query.Status;
        }
        
        if (query.CustomerId.HasValue)
        {
            whereConditions.Add("customer_id = @CustomerId");
            parameters["CustomerId"] = query.CustomerId.Value;
        }

        // optional filters: pickupLocationId, returnLocationId, hasViolation
        {
            // If caller provided PickupLocationId property on params (we extend params if needed)
            var pickupProp = query.GetType().GetProperty("PickupLocationId");
            if (pickupProp != null)
            {
                if (pickupProp.GetValue(query) is Guid val && val != Guid.Empty)
                {
                    whereConditions.Add("pickup_location_id = @PickupLocationId");
                    parameters["PickupLocationId"] = val;
                }
            }

            var returnProp = query.GetType().GetProperty("ReturnLocationId");
            if (returnProp != null)
            {
                var val = returnProp.GetValue(query) as Guid?;
                if (val.HasValue && val.Value != Guid.Empty)
                {
                    whereConditions.Add("return_location_id = @ReturnLocationId");
                    parameters["ReturnLocationId"] = val.Value;
                }
            }

            var hasViolationProp = query.GetType().GetProperty("HasViolation");
            if (hasViolationProp != null)
            {
                var hasViolation = hasViolationProp.GetValue(query) as bool?;
                if (hasViolation.HasValue)
                {
                    whereConditions.Add(hasViolation.Value
                        ? "(booking_violations_json IS NOT NULL AND booking_violations_json <> '')"
                        : "(booking_violations_json IS NULL OR booking_violations_json = '')");
                }
            }
        }

        var whereClause = string.Join(" AND ", whereConditions);
        
        var allowedSortColumns = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "StartDate", "start_date" },
            { "EndDate", "end_date" },
            { "TotalPrice", "total_price" },
            { "Created", "created_at" },
            { "Updated", "updated_at" },
            { "CustomerName", "customer_name" },
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

        // Decrypt phone numbers
        var bookingsList = bookings.ToList();
        foreach (var booking in bookingsList)
        {
            if (!string.IsNullOrEmpty(booking.CustomerPhone))
            {
                try
                {
                    booking.CustomerPhone = cryptographyService.DecryptAes(booking.CustomerPhone);
                }
                catch
                {
                    // If decryption fails, keep original value or set to null
                    booking.CustomerPhone = null;
                }
            }
        }

        return new PagedList<GetBookingDto>(
            bookingsList,
            totalCount,
            query.PageNumber,
            query.PageSize);
    }
}
