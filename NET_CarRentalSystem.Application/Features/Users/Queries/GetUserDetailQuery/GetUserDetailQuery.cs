using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Application.Models.DTOs.UserDTOs.Get;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Users.Queries.GetUserDetailQuery;

public class GetUserDetailQuery : IQuery<GetUserDetailDto?>
{
    public Guid UserId { get; set; }
}

public class GetUserDetailQueryHandler(
    IDapperRepository dapperRepository,
    ICryptographyService cryptographyService)
    : IRequestHandler<GetUserDetailQuery, GetUserDetailDto?>
{
    public async Task<GetUserDetailDto?> Handle(GetUserDetailQuery request, CancellationToken cancellationToken)
    {
        // Get user basic info
        var userSql = """
            SELECT 
                u.user_id AS UserId,
                u.user_name AS UserName,
                u.email AS Email,
                u.status AS Status,
                u.is_verified AS IsVerified,
                u.created_at AS CreatedAt,
                u.updated_at AS UpdatedAt
            FROM users u
            WHERE u.user_id = @UserId AND u.is_deleted = 0
        """;

        var user = await dapperRepository.QueryFirstOrDefaultAsync<GetUserDetailDto>(
            userSql,
            new { request.UserId },
            cancellationToken: cancellationToken);

        if (user == null) return null;

        // Get customer info
        var customerSql = """
            SELECT 
                customer_id AS CustomerId,
                first_name AS FirstName,
                last_name AS LastName,
                dob AS Dob,
                phone_number AS PhoneNumber,
                address AS Address,
                cccd_number AS CccdNumber,
                cccd_issue_date AS CccdIssueDate,
                cccd_issue_place AS CccdIssuePlace,
                cccd_front_url AS CccdFrontUrl,
                cccd_back_url AS CccdBackUrl,
                driver_license_id AS DriverLicenseId,
                driver_license_expiry AS DriverLicenseExpiry,
                driver_license_class AS DriverLicenseClass,
                driver_license_front_url AS DriverLicenseFrontUrl,
                driver_license_back_url AS DriverLicenseBackUrl,
                avatar_url AS AvatarUrl,
                loyalty_points AS LoyaltyPoints,
                is_renting AS IsRenting,
                has_active_violation AS HasActiveViolation,
                is_identity_verified AS IsIdentityVerified,
                is_phone_verified AS IsPhoneVerified,
                is_driver_license_verified AS IsDriverLicenseVerified
            FROM customers
            WHERE user_id = @UserId
        """;

        var customer = await dapperRepository.QueryFirstOrDefaultAsync<GetCustomerInfoDto>(
            customerSql,
            new { request.UserId },
            cancellationToken: cancellationToken);

        if (customer != null)
        {
            customer.PhoneNumber = cryptographyService.SafeDecryptAes(customer.PhoneNumber);
            customer.CccdNumber = cryptographyService.SafeDecryptAes(customer.CccdNumber);
            customer.DriverLicenseId = cryptographyService.SafeDecryptAes(customer.DriverLicenseId);
        }

        user.Customer = customer;
        
        var loginsSql = """
            SELECT 
                login_provider AS LoginProvider,
                provider_display_name AS ProviderDisplayName
            FROM user_logins
            WHERE user_id = @UserId
        """;

        var logins = await dapperRepository.QueryAsync<GetUserLoginInfoDto>(
            loginsSql,
            new { request.UserId },
            cancellationToken: cancellationToken);

        user.UserLogins = logins.ToList();
        
        var userClaimsSql = """
            SELECT DISTINCT claim_value
            FROM user_claims
            WHERE user_id = @UserId
        """;

        var userClaims = await dapperRepository.QueryAsync<string>(
            userClaimsSql,
            new { request.UserId },
            cancellationToken: cancellationToken);

        user.UserClaims = userClaims.ToList();

        // Get roles (distinct)
        var rolesSql = """
            SELECT DISTINCT r.name
            FROM user_roles ur
            INNER JOIN roles r ON ur.role_id = r.role_id
            WHERE ur.user_id = @UserId AND r.is_deleted = 0
        """;

        var roles = await dapperRepository.QueryAsync<string>(
            rolesSql,
            new { request.UserId },
            cancellationToken: cancellationToken);

        user.Roles = roles.ToList();

        // Get role claims (distinct)
        var roleClaimsSql = """
            SELECT DISTINCT rc.claim_value
            FROM user_roles ur
            INNER JOIN role_claims rc ON ur.role_id = rc.role_id
            WHERE ur.user_id = @UserId
        """;

        var roleClaims = await dapperRepository.QueryAsync<string>(
            roleClaimsSql,
            new { request.UserId },
            cancellationToken: cancellationToken);

        user.RoleClaims = roleClaims.ToList();

        return user;
    }
}

