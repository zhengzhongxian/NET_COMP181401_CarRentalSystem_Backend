using NET_CarRentalSystem.Application.Models.Ai;

namespace NET_CarRentalSystem.Application.Interfaces.Services.Ai;

public interface IAiImageVerificationService
{
    /// <summary>
    /// Verify if a single image contains a valid vehicle.
    /// </summary>
    /// <param name="imageData">Image data as byte array</param>
    /// <param name="filename">Original filename for logging</param>
    /// <param name="minConfidence">Minimum confidence threshold (0.0 - 1.0), default: 0.7</param>
    /// <param name="expectedVehicleType">Expected vehicle type for stricter validation (optional)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Verification result with confidence score and detected vehicle type</returns>
    Task<AiImageVerificationResult> VerifyVehicleImageAsync(
        byte[] imageData,
        string filename,
        float minConfidence = 0.7f,
        string? expectedVehicleType = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Verify multiple images in batch for efficiency.
    /// </summary>
    /// <param name="images">List of (imageData, filename) tuples</param>
    /// <param name="minConfidence">Minimum confidence threshold (0.0 - 1.0), default: 0.7</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Batch verification result with individual results and summary</returns>
    Task<AiImageVerificationBatchResult> VerifyVehicleImagesBatchAsync(
        List<(byte[] Data, string Filename)> images,
        float minConfidence = 0.7f,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Check if the AI service is healthy and available.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if service is healthy</returns>
    Task<bool> HealthCheckAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Extract and verify license plate from vehicle image using OCR.
    /// </summary>
    /// <param name="imageData">Image data as byte array</param>
    /// <param name="expectedPlate">Expected license plate to compare (e.g., "51A-12345")</param>
    /// <param name="filename">Original filename for logging</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>License plate extraction result with match status</returns>
    Task<AiLicensePlateResult> ExtractLicensePlateAsync(
        byte[] imageData,
        string expectedPlate,
        string? filename = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Detect vehicle damage by comparing before/after images.
    /// </summary>
    /// <param name="beforeImages">Images from when vehicle was picked up</param>
    /// <param name="afterImages">Images from when vehicle is returned</param>
    /// <param name="minConfidence">Minimum confidence threshold (0.0 - 1.0), default: 0.7</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Damage detection result</returns>
    Task<AiDamageDetectionResult> DetectDamageAsync(
        List<byte[]> beforeImages,
        List<byte[]> afterImages,
        float minConfidence = 0.7f,
        CancellationToken cancellationToken = default);
}
