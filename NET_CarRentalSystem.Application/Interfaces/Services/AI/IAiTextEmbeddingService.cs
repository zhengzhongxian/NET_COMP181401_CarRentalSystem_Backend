namespace NET_CarRentalSystem.Application.Interfaces.Services.Ai;

public interface IAiTextEmbeddingService
{
    /// <summary>
    /// Get embedding vector (as raw bytes, float32 LE) for a single text.
    /// </summary>
    /// <param name="text">Text to generate embedding for</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Embedding as byte[] (float32 LE), or null if service unavailable</returns>
    Task<byte[]?> GetEmbeddingAsync(string text, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Get embedding vectors for multiple texts in batch.
    /// </summary>
    /// <param name="texts">List of texts to embed</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>List of embedding byte arrays, or null if service unavailable</returns>
    Task<List<byte[]>?> GetEmbeddingsBatchAsync(List<string> texts, CancellationToken cancellationToken = default);
}
