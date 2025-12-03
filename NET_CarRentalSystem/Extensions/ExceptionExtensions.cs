using FluentValidation;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Domain.Exceptions.Common;

namespace NET_CarRentalSystem.API.Extensions;

public static class ExceptionExtensions
{
    public static bool IsInfrastructureException(this Exception ex)
    {
        return ex switch
        {
                OperationCanceledException or 
                DbUpdateException or 
                SqlException or 
                DbUpdateConcurrencyException or 
                TimeoutException or
                DomainException or
                ExternalServiceException or
                ValidationException
                => true,
            _ => false
        };
    }
}