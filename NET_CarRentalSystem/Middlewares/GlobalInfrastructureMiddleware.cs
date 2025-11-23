using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Domain.Exceptions.Common;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Infrastructure;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Middlewares;

public class GlobalInfrastructureMiddleware(ILogger<GlobalInfrastructureMiddleware> logger) : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (OperationCanceledException)
        {
            logger.LogWarning("Client request was cancelled.");
            await WriteErrorAsync(context, StatusCodes.Status499ClientClosedRequest, SystemErrorMessage.Request.Cancelled);
        }
        catch (TimeoutException)
        {
            logger.LogError("Database connection timed out.");
            await WriteErrorAsync(context, StatusCodes.Status504GatewayTimeout, DatabaseErrorMessage.Timeout);
        }
        catch (DbUpdateConcurrencyException)
        {
            logger.LogWarning("Database concurrency conflict.");
            await WriteErrorAsync(context, StatusCodes.Status409Conflict, DatabaseErrorMessage.ConcurrencyConflict);
        }
        catch (DbUpdateException dbEx)
        {
            await HandleDatabaseExceptionAsync(context, dbEx);
        }
        catch (DomainException domainEx)
        {
            logger.LogWarning("Business Rule Violation: {Message}", domainEx.Message);
            await WriteErrorAsync(context, domainEx.StatusCode, domainEx.Message);
        }
        catch (ExternalServiceException extEx)
        {
            logger.LogError("External Service Failure [{Service}]: {Message}", extEx.ServiceName, extEx.Message);
            var msg = string.Format(SystemErrorMessage.External.ServiceUnavailable, extEx.ServiceName);
            await WriteErrorAsync(context, extEx.StatusCode, msg);
        }
    }

    private async Task HandleDatabaseExceptionAsync(HttpContext context, DbUpdateException dbEx)
    {
        if (dbEx.InnerException is not SqlException sqlEx)
        {
            logger.LogError("Generic Database Update Error: {Message}", dbEx.Message);
            await WriteErrorAsync(context, StatusCodes.Status400BadRequest, DatabaseErrorMessage.UpdateError, [dbEx.Message]);
            return;
        }

        logger.LogError("SQL Error Code: {Code} - {Message}", sqlEx.Number, sqlEx.Message);

        var (statusCode, message) = sqlEx.Number switch
        {
            2601 or 2627 => (StatusCodes.Status409Conflict, DatabaseErrorMessage.Duplicate),
            547 => (StatusCodes.Status400BadRequest, DatabaseErrorMessage.ForeignKeyViolation),
            2628 or 8152 => (StatusCodes.Status400BadRequest, DatabaseErrorMessage.DataTooLong),
            515 => (StatusCodes.Status400BadRequest, DatabaseErrorMessage.NotNullViolation),
            245 or 8114 => (StatusCodes.Status400BadRequest, DatabaseErrorMessage.DataTypeConversion),
            1205 or 1222 => (StatusCodes.Status409Conflict, DatabaseErrorMessage.Deadlock),
            3960 => (StatusCodes.Status409Conflict, DatabaseErrorMessage.SnapshotConflict),
            2714 => (StatusCodes.Status409Conflict, DatabaseErrorMessage.ObjectAlreadyExists),
            1204 or 40501 or 40197 or 40613 => (StatusCodes.Status503ServiceUnavailable, DatabaseErrorMessage.ServiceBusy),
            49918 or 49919 or 49920 => (StatusCodes.Status429TooManyRequests, DatabaseErrorMessage.Throttled),
            -2 => (StatusCodes.Status504GatewayTimeout, DatabaseErrorMessage.Timeout),
            53 or 4060 => (StatusCodes.Status500InternalServerError, DatabaseErrorMessage.ConnectionFailed),
            18456 => (StatusCodes.Status500InternalServerError, DatabaseErrorMessage.LoginFailed),
            1105 => (StatusCodes.Status507InsufficientStorage, DatabaseErrorMessage.InsufficientStorage),
            207 or 208 => (StatusCodes.Status500InternalServerError, DatabaseErrorMessage.SchemaInvalidName),
            50000 => (StatusCodes.Status400BadRequest, DatabaseErrorMessage.BusinessRuleViolation),
            _ => (StatusCodes.Status400BadRequest, DatabaseErrorMessage.General)
        };

        await WriteErrorAsync(context, statusCode, message, [sqlEx.Message]);
    }

    private static async Task WriteErrorAsync(HttpContext context, int statusCode, string message, List<string>? errors = null)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = statusCode;
        await context.Response.WriteAsJsonAsync(ApiResponse.ErrorResult(message, statusCode, errors));
    }
}