using NET_CarRentalSystem.Application.Models.Ekyc;

namespace NET_CarRentalSystem.Application.Interfaces.Services.Ekyc;

/// <summary>
/// Interface for VNPT eKYC service integration.
/// Provides methods for identity verification using VNPT eKYC API.
/// </summary>
public interface IVnptEkycService
{
    /// <summary>
    /// Upload a file to VNPT eKYC system and get the hash for further processing.
    /// </summary>
    /// <param name="fileStream">The file stream to upload.</param>
    /// <param name="fileName">The name of the file.</param>
    /// <param name="title">Title for the uploaded file.</param>
    /// <param name="description">Description for the uploaded file.</param>
    /// <param name="ct">Cancellation token.</param>
    /// <returns>Upload response containing the file hash.</returns>
    Task<EkycUploadResponse> UploadFileAsync(
        Stream fileStream,
        string fileName,
        string title,
        string description,
        CancellationToken ct = default);

    /// <summary>
    /// Check if the ID card image is from a real document (not a photo of a photo).
    /// </summary>
    /// <param name="imageHash">Hash of the uploaded image.</param>
    /// <param name="clientSession">Client session identifier.</param>
    /// <param name="ct">Cancellation token.</param>
    /// <returns>Liveness check response.</returns>
    Task<EkycLivenessResponse> CheckCardLivenessAsync(
        string imageHash,
        string clientSession,
        CancellationToken ct = default);

    /// <summary>
    /// Extract information from front and back of ID card using OCR.
    /// </summary>
    /// <param name="frontHash">Hash of the front image.</param>
    /// <param name="backHash">Hash of the back image.</param>
    /// <param name="clientSession">Client session identifier.</param>
    /// <param name="ct">Cancellation token.</param>
    /// <returns>OCR extraction response.</returns>
    Task<EkycOcrResponse> ExtractIdInfoAsync(
        string frontHash,
        string backHash,
        string clientSession,
        CancellationToken ct = default);

    /// <summary>
    /// Compare face on ID card with selfie photo.
    /// </summary>
    /// <param name="cardHash">Hash of the ID card image.</param>
    /// <param name="selfieHash">Hash of the selfie image.</param>
    /// <param name="clientSession">Client session identifier.</param>
    /// <param name="ct">Cancellation token.</param>
    /// <returns>Face comparison response.</returns>
    Task<EkycFaceCompareResponse> CompareFaceAsync(
        string cardHash,
        string selfieHash,
        string clientSession,
        CancellationToken ct = default);

    /// <summary>
    /// Check if the selfie is from a real person (not a photo).
    /// </summary>
    /// <param name="selfieHash">Hash of the selfie image.</param>
    /// <param name="clientSession">Client session identifier.</param>
    /// <param name="ct">Cancellation token.</param>
    /// <returns>Liveness check response.</returns>
    Task<EkycLivenessResponse> CheckFaceLivenessAsync(
        string selfieHash,
        string clientSession,
        CancellationToken ct = default);

    /// <summary>
    /// Extract information from Driver License using OCR.
    /// Uses type = 6 for VNPT eKYC API.
    /// </summary>
    /// <param name="frontHash">Hash of the front image.</param>
    /// <param name="backHash">Hash of the back image.</param>
    /// <param name="clientSession">Client session identifier.</param>
    /// <param name="ct">Cancellation token.</param>
    /// <returns>OCR extraction response.</returns>
    Task<EkycOcrResponse> ExtractDriverLicenseInfoAsync(
        string frontHash,
        string backHash,
        string clientSession,
        CancellationToken ct = default);

    /// <summary>
    /// Perform full identity verification: upload images, check liveness, OCR, and face comparison.
    /// </summary>
    /// <param name="frontImage">Front image of ID card.</param>
    /// <param name="backImage">Back image of ID card.</param>
    /// <param name="selfieImage">Selfie image.</param>
    /// <param name="ct">Cancellation token.</param>
    /// <returns>Full verification result.</returns>
    Task<EkycVerificationResult> VerifyIdentityAsync(
        Stream frontImage,
        string frontFileName,
        Stream backImage,
        string backFileName,
        Stream selfieImage,
        string selfieFileName,
        CancellationToken ct = default);
}
