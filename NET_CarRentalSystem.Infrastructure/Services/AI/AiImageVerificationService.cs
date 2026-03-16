using Google.Protobuf;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Grpc.Core;
using NET_CarRentalSystem.Application.Interfaces.Services.Ai;
using NET_CarRentalSystem.Application.Models.Ai;
using NET_CarRentalSystem.Infrastructure.Configurations;
using NET_CarRentalSystem.Infrastructure.Grpc;
using NET_CarRentalSystem.Infrastructure.Grpc.ImageAnalysis;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Infrastructure.Services.Ai;

public class AiImageVerificationService : IAiImageVerificationService
{
    private readonly ImageVerificationService.ImageVerificationServiceClient _client;
    private readonly ILogger<AiImageVerificationService> _logger;
    private readonly GrpcServicesSettings _settings;

    public AiImageVerificationService(
        IOptions<GrpcServicesSettings> options,
        ILogger<AiImageVerificationService> logger)
    {
        _logger = logger;
        _settings = options.Value;
        
        _client = ((ImageVerificationService.ImageVerificationServiceClient)null!)
            .SetChannel(_settings.AiService.Address);
        
        _logger.LogInformation("AI Image Verification Service initialized. Enabled: {Enabled}", _settings.AiService.Enabled);
    }

    public async Task<AiImageVerificationResult> VerifyVehicleImageAsync(
        byte[] imageData,
        string filename,
        float minConfidence = 0.7f,
        string? expectedVehicleType = null,
        CancellationToken cancellationToken = default)
    {
        if (!_settings.AiService.Enabled)
        {
            _logger.LogWarning("AI verification is disabled, returning valid by default");
            return CreateSkippedResult(VehicleMessage.AiVerification.SkipDisabled);
        }

        try
        {
            var request = new VerifyImageRequest
            {
                ImageData = ByteString.CopyFrom(imageData),
                Filename = filename,
                MinConfidence = minConfidence,
                ExpectedVehicleType = expectedVehicleType ?? string.Empty
            };

            var deadline = DateTime.UtcNow.AddSeconds(_settings.TimeoutSeconds);
            var response = await _client.VerifyVehicleImageAsync(
                request,
                deadline: deadline,
                cancellationToken: cancellationToken);

            _logger.LogInformation(
                "AI verification completed for {Filename}: IsValid={IsValid}, Confidence={Confidence:P0}, Type={Type}",
                filename, response.IsValidVehicle, response.Confidence, response.DetectedVehicleType);

            return MapToResult(response);
        }
        catch (RpcException ex) when (ex.StatusCode == StatusCode.Unavailable)
        {
            _logger.LogWarning(ex, "AI Service is unavailable for image {Filename}, skipping verification", filename);
            return CreateSkippedResult(VehicleMessage.AiVerification.SkipUnavailable);
        }
        catch (RpcException ex) when (ex.StatusCode == StatusCode.DeadlineExceeded)
        {
            _logger.LogWarning(ex, "AI verification timeout for image {Filename}, skipping verification", filename);
            return CreateSkippedResult(VehicleMessage.AiVerification.SkipTimeout);
        }
        catch (RpcException ex)
        {
            _logger.LogWarning(ex, "gRPC error for image {Filename}: {Status}, skipping verification", filename, ex.Status);
            return CreateSkippedResult(string.Format(VehicleMessage.AiVerification.SkipError, ex.Status.StatusCode));
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Unexpected error during AI verification for {Filename}, skipping verification", filename);
            return CreateSkippedResult(VehicleMessage.AiVerification.SkipUnexpected);
        }
    }

    public async Task<AiImageVerificationBatchResult> VerifyVehicleImagesBatchAsync(
        List<(byte[] Data, string Filename)> images,
        float minConfidence = 0.7f,
        CancellationToken cancellationToken = default)
    {
        if (!_settings.AiService.Enabled)
        {
            _logger.LogWarning("AI verification is disabled, returning all valid by default");
            return CreateSkippedBatchResult(images.Count, VehicleMessage.AiVerification.SkipDisabled);
        }

        try
        {
            var request = new VerifyImagesBatchRequest();
            
            foreach (var (data, filename) in images)
            {
                request.Images.Add(new VerifyImageRequest
                {
                    ImageData = ByteString.CopyFrom(data),
                    Filename = filename,
                    MinConfidence = minConfidence
                });
            }

            var deadline = DateTime.UtcNow.AddSeconds(_settings.TimeoutSeconds * 2);
            var response = await _client.VerifyVehicleImagesBatchAsync(
                request,
                deadline: deadline,
                cancellationToken: cancellationToken);

            _logger.LogInformation(
                "AI batch verification completed: Total={Total}, Valid={Valid}, Invalid={Invalid}",
                response.Summary?.TotalImages ?? images.Count,
                response.Summary?.ValidCount ?? 0,
                response.Summary?.InvalidCount ?? 0);

            return MapToBatchResult(response);
        }
        catch (RpcException ex) when (ex.StatusCode == StatusCode.Unavailable)
        {
            _logger.LogWarning(ex, "AI Service is unavailable for batch verification, skipping");
            return CreateSkippedBatchResult(images.Count, VehicleMessage.AiVerification.SkipUnavailable);
        }
        catch (RpcException ex) when (ex.StatusCode == StatusCode.DeadlineExceeded)
        {
            _logger.LogWarning(ex, "AI batch verification timeout, skipping");
            return CreateSkippedBatchResult(images.Count, VehicleMessage.AiVerification.SkipTimeout);
        }
        catch (RpcException ex)
        {
            _logger.LogWarning(ex, "gRPC batch error: {Status}, skipping verification", ex.Status);
            return CreateSkippedBatchResult(images.Count, string.Format(VehicleMessage.AiVerification.SkipError, ex.Status.StatusCode));
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Unexpected error during AI batch verification, skipping");
            return CreateSkippedBatchResult(images.Count, VehicleMessage.AiVerification.SkipUnexpected);
        }
    }

    public async Task<bool> HealthCheckAsync(CancellationToken cancellationToken = default)
    {
        if (!_settings.AiService.Enabled)
        {
            return false;
        }

        try
        {
            var response = await _client.HealthCheckAsync(
                new HealthCheckRequest { ServiceName = "NET_CarRentalSystem" },
                deadline: DateTime.UtcNow.AddSeconds(5),
                cancellationToken: cancellationToken);
            
            _logger.LogInformation(
                "AI Health Check: Healthy={IsHealthy}, Status={Status}, Model={Model}", 
                response.IsHealthy, response.Status, response.ModelLoaded);
            
            return response.IsHealthy;
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "AI Health Check failed");
            return false;
        }
    }

    public async Task<AiLicensePlateResult> ExtractLicensePlateAsync(
        byte[] imageData,
        string expectedPlate,
        string? filename = null,
        CancellationToken cancellationToken = default)
    {
        if (!_settings.AiService.Enabled)
        {
            _logger.LogWarning("AI verification is disabled, skipping license plate extraction");
            return CreateSkippedPlateResult(VehicleMessage.AiVerification.SkipDisabled);
        }

        try
        {
            var request = new ExtractLicensePlateRequest
            {
                ImageData = ByteString.CopyFrom(imageData),
                ExpectedPlate = expectedPlate,
                Filename = filename ?? string.Empty
            };

            var deadline = DateTime.UtcNow.AddSeconds(_settings.TimeoutSeconds);
            var response = await _client.ExtractLicensePlateAsync(
                request,
                deadline: deadline,
                cancellationToken: cancellationToken);

            _logger.LogInformation(
                "AI license plate extraction for {Filename}: Detected={Detected}, Plate={Plate}, Matched={Matched}, Confidence={Confidence:P0}",
                filename, response.PlateDetected, response.DetectedPlate, response.IsMatched, response.Confidence);

            return MapToPlateResult(response, expectedPlate);
        }
        catch (RpcException ex) when (ex.StatusCode == StatusCode.Unavailable)
        {
            _logger.LogWarning(ex, "AI Service is unavailable for plate extraction, skipping");
            return CreateSkippedPlateResult(VehicleMessage.AiVerification.SkipUnavailable);
        }
        catch (RpcException ex) when (ex.StatusCode == StatusCode.DeadlineExceeded)
        {
            _logger.LogWarning(ex, "AI plate extraction timeout, skipping");
            return CreateSkippedPlateResult(VehicleMessage.AiVerification.SkipTimeout);
        }
        catch (RpcException ex)
        {
            _logger.LogWarning(ex, "gRPC error during plate extraction: {Status}, skipping", ex.Status);
            return CreateSkippedPlateResult(string.Format(VehicleMessage.AiVerification.SkipError, ex.Status.StatusCode));
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Unexpected error during plate extraction, skipping");
            return CreateSkippedPlateResult(VehicleMessage.AiVerification.SkipUnexpected);
        }
    }

    public async Task<AiDamageDetectionResult> DetectDamageAsync(
        List<byte[]> beforeImages,
        List<byte[]> afterImages,
        float minConfidence = 0.7f,
        CancellationToken cancellationToken = default)
    {
        if (!_settings.AiService.Enabled)
        {
            _logger.LogWarning("AI verification is disabled, skipping damage detection");
            return CreateSkippedDamageResult(VehicleMessage.AiVerification.SkipDisabled);
        }

        try
        {
            var request = new DetectDamageRequest
            {
                MinConfidence = minConfidence
            };
            
            foreach (var img in beforeImages)
            {
                request.BeforeImages.Add(ByteString.CopyFrom(img));
            }
            foreach (var img in afterImages)
            {
                request.AfterImages.Add(ByteString.CopyFrom(img));
            }

            var deadline = DateTime.UtcNow.AddSeconds(_settings.TimeoutSeconds * 2);
            var response = await _client.DetectVehicleDamageAsync(
                request,
                deadline: deadline,
                cancellationToken: cancellationToken);

            _logger.LogInformation(
                "AI damage detection: DamageDetected={Detected}, Confidence={Confidence:P0}",
                response.DamageDetected, response.Confidence);

            return MapToDamageResult(response);
        }
        catch (RpcException ex) when (ex.StatusCode == StatusCode.Unavailable)
        {
            _logger.LogWarning(ex, "AI Service is unavailable for damage detection, skipping");
            return CreateSkippedDamageResult(VehicleMessage.AiVerification.SkipUnavailable);
        }
        catch (RpcException ex) when (ex.StatusCode == StatusCode.DeadlineExceeded)
        {
            _logger.LogWarning(ex, "AI damage detection timeout, skipping");
            return CreateSkippedDamageResult(VehicleMessage.AiVerification.SkipTimeout);
        }
        catch (RpcException ex)
        {
            _logger.LogWarning(ex, "gRPC error during damage detection: {Status}, skipping", ex.Status);
            return CreateSkippedDamageResult(string.Format(VehicleMessage.AiVerification.SkipError, ex.Status.StatusCode));
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Unexpected error during damage detection, skipping");
            return CreateSkippedDamageResult(VehicleMessage.AiVerification.SkipUnexpected);
        }
    }

    private static AiImageVerificationResult MapToResult(VerifyImageResponse response)
    {
        var result = new AiImageVerificationResult
        {
            IsValidVehicle = response.IsValidVehicle,
            Confidence = response.Confidence,
            DetectedVehicleType = response.DetectedVehicleType,
            MessageVi = response.ResponseMessage?.MessageVi ?? string.Empty,
            MessageEn = response.ResponseMessage?.MessageEn ?? string.Empty,
            Severity = response.ResponseMessage?.Severity ?? "INFO",
            ProcessingTimeMs = response.Metadata?.ProcessingTimeMs ?? 0,
            WasSkipped = false
        };

        foreach (var kvp in response.VehicleTypeScores)
        {
            result.VehicleTypeScores[kvp.Key] = kvp.Value;
        }

        return result;
    }

    private static AiImageVerificationBatchResult MapToBatchResult(VerifyImagesBatchResponse response)
    {
        var result = new AiImageVerificationBatchResult
        {
            TotalImages = response.Summary?.TotalImages ?? response.Results.Count,
            ValidCount = response.Summary?.ValidCount ?? 0,
            InvalidCount = response.Summary?.InvalidCount ?? 0,
            TotalProcessingTimeMs = response.Summary?.TotalProcessingTimeMs ?? 0,
            AverageConfidence = response.Summary?.AverageConfidence ?? 0,
            WasSkipped = false
        };

        foreach (var r in response.Results)
        {
            result.Results.Add(MapToResult(r));
        }

        return result;
    }
    
    private static AiImageVerificationResult CreateSkippedResult(string reason)
    {
        return new AiImageVerificationResult
        {
            IsValidVehicle = true,
            Confidence = 0f,
            DetectedVehicleType = "unknown",
            MessageVi = string.Format(VehicleMessage.AiVerification.SkipMessageViFormat, reason),
            MessageEn = string.Format(VehicleMessage.AiVerification.SkipMessageEnFormat, reason),
            Severity = "WARNING",
            WasSkipped = true,
            SkipReason = reason
        };
    }
    
    private static AiImageVerificationBatchResult CreateSkippedBatchResult(int count, string reason)
    {
        var result = new AiImageVerificationBatchResult
        {
            TotalImages = count,
            ValidCount = count,
            InvalidCount = 0,
            AverageConfidence = 0f,
            WasSkipped = true,
            SkipReason = reason
        };

        for (var i = 0; i < count; i++)
        {
            result.Results.Add(CreateSkippedResult(reason));
        }

        return result;
    }

    private static AiLicensePlateResult MapToPlateResult(ExtractLicensePlateResponse response, string expectedPlate)
    {
        return new AiLicensePlateResult
        {
            PlateDetected = response.PlateDetected,
            DetectedPlate = response.DetectedPlate,
            ExpectedPlate = expectedPlate,
            IsMatched = response.IsMatched,
            Confidence = response.Confidence,
            MessageVi = response.ResponseMessage?.MessageVi ?? string.Empty,
            MessageEn = response.ResponseMessage?.MessageEn ?? string.Empty,
            WasSkipped = false
        };
    }

    private static AiLicensePlateResult CreateSkippedPlateResult(string reason)
    {
        return new AiLicensePlateResult
        {
            PlateDetected = false,
            DetectedPlate = string.Empty,
            IsMatched = true,
            Confidence = 0f,
            MessageVi = string.Format(BookingMessage.AiVerification.SkipLicensePlate, reason),
            MessageEn = $"License plate verification skipped: {reason}",
            WasSkipped = true,
            SkipReason = reason
        };
    }

    private static AiDamageDetectionResult MapToDamageResult(DetectDamageResponse response)
    {
        return new AiDamageDetectionResult
        {
            DamageDetected = response.DamageDetected,
            DamageDescriptionVi = response.DamageDescriptionVi,
            DamageDescriptionEn = response.DamageDescriptionEn,
            Confidence = response.Confidence,
            WasSkipped = false
        };
    }

    private static AiDamageDetectionResult CreateSkippedDamageResult(string reason)
    {
        return new AiDamageDetectionResult
        {
            DamageDetected = false,
            DamageDescriptionVi = string.Format(BookingMessage.AiVerification.SkipDamageDetection, reason),
            DamageDescriptionEn = $"Damage detection skipped: {reason}",
            Confidence = 0f,
            WasSkipped = true,
            SkipReason = reason
        };
    }
}
