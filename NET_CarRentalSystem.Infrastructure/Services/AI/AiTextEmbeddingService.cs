using Grpc.Core;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Interfaces.Services.Ai;
using NET_CarRentalSystem.Infrastructure.Configurations;
using NET_CarRentalSystem.Infrastructure.Grpc;
using NET_CarRentalSystem.Infrastructure.Grpc.TextEmbedding;

namespace NET_CarRentalSystem.Infrastructure.Services.Ai;

public class AiTextEmbeddingService : IAiTextEmbeddingService
{
    private readonly ILogger<AiTextEmbeddingService> _logger;
    private readonly GrpcServicesSettings _settings;
    private readonly TextEmbeddingService.TextEmbeddingServiceClient _client;

    public AiTextEmbeddingService(
        IOptions<GrpcServicesSettings> options,
        ILogger<AiTextEmbeddingService> logger)
    {
        _logger = logger;
        _settings = options.Value;

        _client = ((TextEmbeddingService.TextEmbeddingServiceClient)null!)
            .SetChannel(_settings.AiService.Address);
        
        _logger.LogInformation("AI Text Embedding Service initialized. Enabled: {Enabled}", _settings.AiService.Enabled);
    }

    public async Task<byte[]?> GetEmbeddingAsync(string text, CancellationToken cancellationToken = default)
    {
        if (!_settings.AiService.Enabled)
        {
            _logger.LogDebug("Text embedding service is disabled");
            return null;
        }

        try
        {
            var request = new EmbeddingRequest { Text = text };
            
            var deadline = DateTime.UtcNow.AddSeconds(_settings.TimeoutSeconds);
            var response = await _client.GetEmbeddingAsync(
                request,
                deadline: deadline,
                cancellationToken: cancellationToken);

            if (response.Embedding == null || response.Embedding.IsEmpty)
            {
                _logger.LogWarning("Empty embedding returned for text: {TextPreview}",
                    text.Length > 50 ? text[..50] + "..." : text);
                return null;
            }

            _logger.LogDebug("Generated embedding: dim={Dim}, model={Model}",
                response.Dimension, response.ModelName);
            
            return response.Embedding.ToByteArray();
        }
        catch (RpcException ex) when (ex.StatusCode == StatusCode.Unavailable)
        {
            _logger.LogWarning("Text embedding AI service is unavailable");
            return null;
        }
        catch (RpcException ex) when (ex.StatusCode == StatusCode.DeadlineExceeded)
        {
            _logger.LogWarning("Text embedding request timed out");
            return null;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error generating text embedding");
            return null;
        }
    }

    public async Task<List<byte[]>?> GetEmbeddingsBatchAsync(List<string> texts, CancellationToken cancellationToken = default)
    {
        if (!_settings.AiService.Enabled)
            return null;

        try
        {
            var request = new EmbeddingsBatchRequest();
            request.Texts.AddRange(texts);
            
            var deadline = DateTime.UtcNow.AddSeconds(_settings.TimeoutSeconds * 2);
            var response = await _client.GetEmbeddingsBatchAsync(
                request,
                deadline: deadline,
                cancellationToken: cancellationToken);

            return response.Embeddings
                .Select(e => e.Embedding.ToByteArray())
                .ToList();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error generating batch text embeddings");
            return null;
        }
    }
}
