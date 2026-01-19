using System.Threading;
using System.Threading.Tasks;

namespace NET_CarRentalSystem.Application.Interfaces.Services.AI;

public interface IEmbeddingService
{
    /// <summary>
    /// Generate embedding vector for given text
    /// </summary>
    /// <param name="text">Input text to embed</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>384-dimensional float array</returns>
    Task<float[]> GetEmbeddingAsync(string text, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Check if embedding service is available
    /// </summary>
    bool IsAvailable();
}
