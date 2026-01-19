using MediatR;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Storage;
using NET_CarRentalSystem.Domain.Exceptions.Minio;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Bookings.Commands.ExportBookingContractCommand;

public class ExportBookingContractCommand : ICommand<(bool Success, string Message, Stream? FileStream, string? ContentType)>
{
    public required string FileName { get; init; }
}

public class ExportBookingContractCommandHandler(
    IMinioService minioService,
    ILogger<ExportBookingContractCommandHandler> logger) 
    : IRequestHandler<ExportBookingContractCommand, (bool Success, string Message, Stream? FileStream, string? ContentType)>
{
    public async Task<(bool Success, string Message, Stream? FileStream, string? ContentType)> Handle(
        ExportBookingContractCommand request, 
        CancellationToken cancellationToken)
    {
        try
        {
            // Validate FileName is not empty
            if (string.IsNullOrWhiteSpace(request.FileName))
            {
                logger.LogWarning("Export contract failed: FileName is empty");
                return (false, BookingMessage.ExportContract.InvalidFileName, null, null);
            }

            // Download file from MinIO using FULL object key
            var fileStream = await minioService.DownloadFileAsync(
                request.FileName,
                cancellationToken: cancellationToken);

            logger.LogInformation(
                "Successfully exported contract: {FileName}", 
                request.FileName);

            return (true, BookingMessage.ExportContract.Success, fileStream, "application/pdf");
        }
        catch (MinioBusinessException ex) when (ex.ErrorCode == "FILE_NOT_FOUND")
        {
            logger.LogWarning(
                "Export contract failed: File not found - {FileName}", 
                request.FileName);
            return (false, BookingMessage.ExportContract.FileNotFound, null, null);
        }
        catch (MinioBusinessException ex)
        {
            logger.LogError(
                ex, 
                "MinIO business error while exporting contract: {FileName}", 
                request.FileName);
            return (false, $"{BookingMessage.ExportContract.Error} {ex.Message}", null, null);
        }
        catch (Exception ex)
        {
            logger.LogError(
                ex, 
                "Unexpected error while exporting contract: {FileName}", 
                request.FileName);
            return (false, $"{BookingMessage.ExportContract.Error} {ex.Message}", null, null);
        }
    }
}

