using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Interfaces.Services.AI;

namespace NET_CarRentalSystem.Infrastructure.Services.AI;

/// <summary>
/// ONNX-based embedding service using all-MiniLM-L6-v2 model
/// </summary>
public class OnnxEmbeddingService : IEmbeddingService, IDisposable
{
    private readonly ILogger<OnnxEmbeddingService> _logger;
    private readonly EmbeddingSettings _settings;
    private InferenceSession? _session;
    private Dictionary<string, int>? _vocab;
    private bool _isInitialized;

    public OnnxEmbeddingService(
        IOptions<EmbeddingSettings> settings,
        ILogger<OnnxEmbeddingService> logger)
    {
        _settings = settings.Value;
        _logger = logger;
        
        if (_settings.Enabled)
        {
            InitializeModel();
        }
    }

    private void InitializeModel()
    {
        try
        {
            if (!File.Exists(_settings.ModelPath))
            {
                _logger.LogWarning("ONNX model not found at {Path}. Embedding service disabled.", _settings.ModelPath);
                return;
            }

            _session = new InferenceSession(_settings.ModelPath);
            _vocab = LoadVocab(_settings.VocabPath);
            _isInitialized = true;
            
            _logger.LogInformation("ONNX embedding model loaded successfully from {Path}", _settings.ModelPath);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to initialize ONNX embedding model");
            _isInitialized = false;
        }
    }

    public bool IsAvailable() => _isInitialized && _session != null;

    public async Task<float[]> GetEmbeddingAsync(string text, CancellationToken cancellationToken = default)
    {
        if (!IsAvailable())
        {
            throw new InvalidOperationException("Embedding service is not available");
        }

        try
        {
            // Run CPU-bound ONNX inference on background thread
            return await Task.Run(() =>
            {
                // Tokenize input text
                var tokens = Tokenize(text);
                
                // Create input tensors
                var inputIds = new DenseTensor<long>(new[] { 1, tokens.Length });
                var attentionMask = new DenseTensor<long>(new[] { 1, tokens.Length });
                var tokenTypeIds = new DenseTensor<long>(new[] { 1, tokens.Length });

                for (int i = 0; i < tokens.Length; i++)
                {
                    inputIds[0, i] = tokens[i];
                    attentionMask[0, i] = 1;
                    tokenTypeIds[0, i] = 0;
                }

                // Run inference
                var inputs = new List<NamedOnnxValue>
                {
                    NamedOnnxValue.CreateFromTensor("input_ids", inputIds),
                    NamedOnnxValue.CreateFromTensor("attention_mask", attentionMask),
                    NamedOnnxValue.CreateFromTensor("token_type_ids", tokenTypeIds)
                };

                using var results = _session!.Run(inputs);
                var outputTensor = results.First().AsTensor<float>();
                
                // Extract [CLS] token embedding (sentence embedding)
                var embedding = new float[_settings.Dimension];
                for (int i = 0; i < _settings.Dimension; i++)
                {
                    embedding[i] = outputTensor[0, 0, i];
                }

                // Normalize embedding
                return Normalize(embedding);
            }, cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to generate embedding for text: {Text}", text);
            throw;
        }
    }

    private long[] Tokenize(string text)
    {
        // Simple word-piece tokenization
        // In production, use proper BERT tokenizer
        var words = text.ToLower()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Take(128) // Max sequence length
            .ToArray();

        var tokens = new List<long> { 101 }; // [CLS]
        
        tokens.AddRange(words.Select(word => 
            _vocab!.TryGetValue(word, out var tokenId) ? tokenId : 100L
        ));

        tokens.Add(102); // [SEP]
        
        return tokens.ToArray();
    }

    private Dictionary<string, int> LoadVocab(string path)
    {
        if (!File.Exists(path))
        {
            _logger.LogWarning("Vocab file not found at {Path}. Using basic vocabulary.", path);
            return new Dictionary<string, int>();
        }

        var vocab = new Dictionary<string, int>();
        var lines = File.ReadAllLines(path);
        
        for (var i = 0; i < lines.Length; i++)
        {
            vocab[lines[i]] = i;
        }
        
        return vocab;
    }

    private static float[] Normalize(float[] vector)
    {
        var magnitude = Math.Sqrt(vector.Sum(x => x * x));
        return magnitude == 0 ? vector : vector.Select(x => (float)(x / magnitude)).ToArray();
    }

    public void Dispose()
    {
        _session?.Dispose();
    }
}
