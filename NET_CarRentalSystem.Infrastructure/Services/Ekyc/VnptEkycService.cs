using System.Net.Http.Headers;
using System.Text;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Interfaces.Services.Ekyc;
using NET_CarRentalSystem.Application.Models.Ekyc;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Infrastructure.Services.Ekyc;

public class VnptEkycService : IVnptEkycService
{
    private readonly HttpClient _httpClient;
    private readonly VnptEkycSettings _settings;
    private readonly ILogger<VnptEkycService> _logger;

    public VnptEkycService(
        HttpClient httpClient,
        IOptions<VnptEkycSettings> settings,
        ILogger<VnptEkycService> logger)
    {
        _httpClient = httpClient;
        _settings = settings.Value;
        _logger = logger;

        ConfigureHttpClient();
    }

    private void ConfigureHttpClient()
    {
        _httpClient.BaseAddress = new Uri(_settings.BaseUrl);
        _httpClient.DefaultRequestHeaders.Clear();
        _httpClient.DefaultRequestHeaders.Add("Token-id", _settings.TokenId);
        _httpClient.DefaultRequestHeaders.Add("Token-key", _settings.TokenKey);
        _httpClient.DefaultRequestHeaders.Add("mac-address", _settings.MacAddress);
        _httpClient.DefaultRequestHeaders.Authorization = 
            new AuthenticationHeaderValue("Bearer", _settings.AccessToken);
    }

    public async Task<EkycUploadResponse> UploadFileAsync(
        Stream fileStream,
        string fileName,
        string title,
        string description,
        CancellationToken ct = default)
    {
        using var content = new MultipartFormDataContent();
        using var streamContent = new StreamContent(fileStream);
        
        content.Add(streamContent, "file", fileName);
        content.Add(new StringContent(title), "title");
        content.Add(new StringContent(description), "description");

        var response = await _httpClient.PostAsync("/file-service/v1/addFile", content, ct);
        var json = await response.Content.ReadAsStringAsync(ct);
        
        _logger.LogInformation("[eKYC] Upload response: {Response}", json);
        
        return json.FromJson<EkycUploadResponse>() ?? new EkycUploadResponse();
    }

    public async Task<EkycLivenessResponse> CheckCardLivenessAsync(
        string imageHash,
        string clientSession,
        CancellationToken ct = default)
    {
        var requestBody = new
        {
            img = imageHash,
            client_session = clientSession
        };

        var content = new StringContent(
            requestBody.ToJson(),
            Encoding.UTF8,
            "application/json");

        var response = await _httpClient.PostAsync("/ai/v1/card/liveness", content, ct);
        var json = await response.Content.ReadAsStringAsync(ct);
        
        _logger.LogInformation("[eKYC] Card liveness response: {Response}", json);
        
        return json.FromJson<EkycLivenessResponse>() ?? new EkycLivenessResponse();
    }

    public async Task<EkycOcrResponse> ExtractIdInfoAsync(
        string frontHash,
        string backHash,
        string clientSession,
        CancellationToken ct = default)
    {
        var requestBody = new
        {
            img_front = frontHash,
            img_back = backHash,
            client_session = clientSession,
            type = -1,
            validate_postcode = true,
            token = Guid.NewGuid().ToString("N")
        };

        var content = new StringContent(
            requestBody.ToJson(),
            Encoding.UTF8,
            "application/json");

        var response = await _httpClient.PostAsync("/ai/v1/ocr/id", content, ct);
        var json = await response.Content.ReadAsStringAsync(ct);
        
        _logger.LogInformation("[eKYC] OCR response: {Response}", json);
        
        return json.FromJson<EkycOcrResponse>() ?? new EkycOcrResponse();
    }

    public async Task<EkycFaceCompareResponse> CompareFaceAsync(
        string cardHash,
        string selfieHash,
        string clientSession,
        CancellationToken ct = default)
    {
        var requestBody = new
        {
            img_front = cardHash,
            img_face = selfieHash,
            client_session = clientSession,
            token = Guid.NewGuid().ToString("N")
        };

        var content = new StringContent(
            requestBody.ToJson(),
            Encoding.UTF8,
            "application/json");

        var response = await _httpClient.PostAsync("/ai/v1/face/compare", content, ct);
        var json = await response.Content.ReadAsStringAsync(ct);
        
        _logger.LogInformation("[eKYC] Face compare response: {Response}", json);
        
        return json.FromJson<EkycFaceCompareResponse>() ?? new EkycFaceCompareResponse();
    }

    public async Task<EkycOcrResponse> ExtractDriverLicenseInfoAsync(
        string frontHash,
        string backHash,
        string clientSession,
        CancellationToken ct = default)
    {
        var requestBody = new
        {
            img_front = frontHash,
            img_back = backHash,
            client_session = clientSession,
            type = 6, // 6 = Giấy phép lái xe (Driver License)
            validate_postcode = false,
            token = Guid.NewGuid().ToString("N")
        };

        var content = new StringContent(
            requestBody.ToJson(),
            Encoding.UTF8,
            "application/json");

        var response = await _httpClient.PostAsync("/ai/v1/ocr/id", content, ct);
        var json = await response.Content.ReadAsStringAsync(ct);
        
        _logger.LogInformation("[eKYC] Driver License OCR response: {Response}", json);
        
        return json.FromJson<EkycOcrResponse>() ?? new EkycOcrResponse();
    }

    public async Task<EkycLivenessResponse> CheckFaceLivenessAsync(
        string selfieHash,
        string clientSession,
        CancellationToken ct = default)
    {
        var requestBody = new
        {
            img = selfieHash,
            client_session = clientSession,
            token = Guid.NewGuid().ToString("N")
        };

        var content = new StringContent(
            requestBody.ToJson(),
            Encoding.UTF8,
            "application/json");

        var response = await _httpClient.PostAsync("/ai/v1/face/liveness", content, ct);
        var json = await response.Content.ReadAsStringAsync(ct);
        
        _logger.LogInformation("[eKYC] Face liveness response: {Response}", json);
        
        return json.FromJson<EkycLivenessResponse>() ?? new EkycLivenessResponse();
    }

    public async Task<EkycVerificationResult> VerifyIdentityAsync(
        Stream frontImage,
        string frontFileName,
        Stream backImage,
        string backFileName,
        Stream selfieImage,
        string selfieFileName,
        CancellationToken ct = default)
    {
        var result = new EkycVerificationResult();
        var clientSession = GenerateClientSession();
        var warnings = new List<string>();

        try
        {
            var uploadFront = await UploadFileAsync(frontImage, frontFileName, "CCCD Front", "CCCD mat truoc", ct);
            if (!uploadFront.IsSuccess || uploadFront.Object == null)
            {
                result.Message = EkycMessage.Verify.UploadFrontFailed;
                return result;
            }
            result.FrontImageHash = uploadFront.Object.Hash;

            var uploadBack = await UploadFileAsync(backImage, backFileName, "CCCD Back", "CCCD mat sau", ct);
            if (!uploadBack.IsSuccess || uploadBack.Object == null)
            {
                result.Message = EkycMessage.Verify.UploadBackFailed;
                return result;
            }
            result.BackImageHash = uploadBack.Object.Hash;

            var uploadSelfie = await UploadFileAsync(selfieImage, selfieFileName, "Selfie", "Anh chan dung", ct);
            if (!uploadSelfie.IsSuccess || uploadSelfie.Object == null)
            {
                result.Message = EkycMessage.Verify.UploadSelfieFailed;
                return result;
            }
            result.SelfieHash = uploadSelfie.Object.Hash;

            var cardLiveness = await CheckCardLivenessAsync(result.FrontImageHash, clientSession, ct);
            result.IsCardLivenessPass = cardLiveness.IsSuccess && cardLiveness.Object?.IsReal == true;
            if (!result.IsCardLivenessPass)
            {
                warnings.Add(EkycMessage.Verify.CardNotReal);
            }

            var ocrResult = await ExtractIdInfoAsync(result.FrontImageHash, result.BackImageHash, clientSession, ct);
            if (!ocrResult.IsSuccess || ocrResult.Object == null)
            {
                result.Message = EkycMessage.Verify.OcrFailed;
                result.Warnings = warnings;
                return result;
            }

            result.IdNumber = ocrResult.Object.Id;
            result.FullName = ocrResult.Object.Name;
            result.DateOfBirth = ocrResult.Object.BirthDay;
            result.Gender = ocrResult.Object.Gender;
            result.Address = ocrResult.Object.RecentLocation;
            result.Hometown = ocrResult.Object.OriginLocation;
            result.IssueDate = ocrResult.Object.IssueDate;
            result.IssuePlace = ocrResult.Object.IssuePlace;
            result.ValidDate = ocrResult.Object.ValidDate;

            if (ocrResult.Object.Warning != null)
            {
                warnings.AddRange(ocrResult.Object.Warning);
            }

            var faceLiveness = await CheckFaceLivenessAsync(result.SelfieHash, clientSession, ct);
            result.IsFaceLivenessPass = faceLiveness.IsSuccess && faceLiveness.Object?.IsReal == true;
            if (!result.IsFaceLivenessPass)
            {
                warnings.Add(EkycMessage.Verify.FaceNotReal);
            }

            var faceCompare = await CompareFaceAsync(result.FrontImageHash, result.SelfieHash, clientSession, ct);
            if (faceCompare is { IsSuccess: true, Object: not null })
            {
                result.FaceMatchScore = faceCompare.Object.Prob;
                result.IsFaceMatch = faceCompare.Object.Prob >= _settings.FaceMatchThreshold;
                
                if (!result.IsFaceMatch)
                {
                    warnings.Add($"{EkycMessage.Verify.FaceNotMatch} ({faceCompare.Object.Prob:F1}% < {_settings.FaceMatchThreshold}%)");
                }
            }

            result.IsSuccess = result.IsCardLivenessPass && 
                               result.IsFaceLivenessPass && 
                               result.IsFaceMatch &&
                               !string.IsNullOrEmpty(result.IdNumber);
            
            result.Message = result.IsSuccess ? EkycMessage.Verify.Success : GetDetailedFailureMessage(result);
            
            result.Warnings = warnings;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "[eKYC] Verification failed");
            result.Message = EkycMessage.Verify.SystemError;
            result.Warnings = [ex.Message];
        }

        return result;
    }
    
    private static string GetDetailedFailureMessage(EkycVerificationResult result)
    {
        var failedSteps = new List<string>();

        if (!result.IsCardLivenessPass)
        {
            failedSteps.Add(EkycMessage.Verify.CardNotReal);
        }

        if (string.IsNullOrEmpty(result.IdNumber))
        {
            failedSteps.Add(EkycMessage.Verify.OcrFailed);
        }

        if (!result.IsFaceLivenessPass)
        {
            failedSteps.Add(EkycMessage.Verify.FaceNotReal);
        }

        if (!result.IsFaceMatch)
        {
            failedSteps.Add($"{EkycMessage.Verify.FaceNotMatch} (Độ khớp: {result.FaceMatchScore:F1}%)");
        }

        return failedSteps.Count > 0 
            ? string.Join(" | ", failedSteps) 
            : EkycMessage.Verify.Failed;
    }

    private static string GenerateClientSession()
    {
        var timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        return $"WEB_CarRental_1.0.0_Device_{Guid.NewGuid():N}_{timestamp}";
    }
}
