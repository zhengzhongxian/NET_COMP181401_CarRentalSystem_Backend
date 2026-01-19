# Download ONNX Embedding Model
# Run this script from project root: C:\Users\ADMIN\Desktop\SPNC\NET_CarRentalSystem

Write-Host "========================================" -ForegroundColor Cyan
Write-Host "ONNX Model Downloader" -ForegroundColor Cyan
Write-Host "Model: all-MiniLM-L6-v2" -ForegroundColor Cyan
Write-Host "========================================`n" -ForegroundColor Cyan

# Create Models directory
$modelsDir = "Models"
if (-not (Test-Path $modelsDir)) {
    New-Item -ItemType Directory -Path $modelsDir | Out-Null
    Write-Host "[OK] Created $modelsDir directory" -ForegroundColor Green
}

# Define files to download
# Note: model.onnx is in /onnx subfolder, tokenizer/vocab are in root
$files = @(
    @{Name="model.onnx"; Url="https://huggingface.co/sentence-transformers/all-MiniLM-L6-v2/resolve/main/onnx/model.onnx"; Size="~90 MB"},
    @{Name="tokenizer.json"; Url="https://huggingface.co/sentence-transformers/all-MiniLM-L6-v2/resolve/main/tokenizer.json"; Size="~466 KB"},
    @{Name="vocab.txt"; Url="https://huggingface.co/sentence-transformers/all-MiniLM-L6-v2/resolve/main/vocab.txt"; Size="~232 KB"}
)

# Download each file
foreach ($file in $files) {
    $fileName = $file.Name
    $filePath = Join-Path $modelsDir $fileName
    
    if (Test-Path $filePath) {
        Write-Host "[SKIP] $fileName already exists" -ForegroundColor Yellow
        continue
    }
    
    Write-Host "[DOWN] Downloading $fileName ($($file.Size))..." -ForegroundColor Cyan
    try {
        Invoke-WebRequest -Uri $file.Url -OutFile $filePath -UseBasicParsing
        Write-Host "[OK] Downloaded $fileName successfully" -ForegroundColor Green
    }
    catch {
        Write-Host "[ERROR] Failed to download $fileName : $_" -ForegroundColor Red
        Write-Host "  URL: $($file.Url)" -ForegroundColor Gray
        exit 1
    }
}

Write-Host "`n========================================" -ForegroundColor Cyan
Write-Host "[OK] All files downloaded successfully!" -ForegroundColor Green
Write-Host "========================================" -ForegroundColor Cyan

# Verify files
Write-Host "`nVerifying files..." -ForegroundColor Cyan
foreach ($file in $files) {
    $filePath = Join-Path $modelsDir $file.Name
    if (Test-Path $filePath) {
        $size = (Get-Item $filePath).Length / 1MB
        Write-Host "  [OK] $($file.Name) - $([math]::Round($size, 2)) MB" -ForegroundColor Green
    }
    else {
        Write-Host "  [ERROR] $($file.Name) - MISSING" -ForegroundColor Red
    }
}

Write-Host "`n[OK] Setup complete! Next: dotnet restore" -ForegroundColor Green
