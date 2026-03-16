namespace NET_CarRentalSystem.Application.Models.Ai;

public class AiImageVerificationResult
{
    public bool IsValidVehicle { get; set; }
    
    public float Confidence { get; set; }
    
    public string DetectedVehicleType { get; set; } = string.Empty;
    
    public string MessageVi { get; set; } = string.Empty;
    
    public string MessageEn { get; set; } = string.Empty;
    
    public string Severity { get; set; } = "INFO";
    
    public long ProcessingTimeMs { get; set; }
    
    public Dictionary<string, float> VehicleTypeScores { get; set; } = new();
    
    public bool WasSkipped { get; set; }
    
    public string? SkipReason { get; set; }
}

public class AiImageVerificationBatchResult
{
    public List<AiImageVerificationResult> Results { get; set; } = new();
    
    public int TotalImages { get; set; }
    
    public int ValidCount { get; set; }
    
    public int InvalidCount { get; set; }
    
    public long TotalProcessingTimeMs { get; set; }
    
    public float AverageConfidence { get; set; }
    
    public bool AllValid => InvalidCount == 0;
    
    public List<int> InvalidIndices => Results
        .Select((r, i) => (Result: r, Index: i))
        .Where(x => !x.Result.IsValidVehicle)
        .Select(x => x.Index)
        .ToList();
    
    public bool WasSkipped { get; set; }
    
    public string? SkipReason { get; set; }
}

public class AiLicensePlateResult
{
    public bool PlateDetected { get; set; }
    
    public string DetectedPlate { get; set; } = string.Empty;
    
    public string? ExpectedPlate { get; set; }
    
    public bool IsMatched { get; set; }
    
    public float Confidence { get; set; }
    
    public string MessageVi { get; set; } = string.Empty;
    
    public string MessageEn { get; set; } = string.Empty;
    
    public bool WasSkipped { get; set; }

    public string? SkipReason { get; set; }
}

public class AiDamageDetectionResult
{
    public bool DamageDetected { get; set; }
    
    public string DamageDescriptionVi { get; set; } = string.Empty;
    
    public string DamageDescriptionEn { get; set; } = string.Empty;
    
    public float Confidence { get; set; }
    
    public bool WasSkipped { get; set; }
    
    public string? SkipReason { get; set; }
}
