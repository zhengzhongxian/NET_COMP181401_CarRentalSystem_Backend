namespace NET_CarRentalSystem.Domain.Interfaces.Persistence;

public interface IDbTransaction : IDisposable, IAsyncDisposable
{
    Task CommitAsync(CancellationToken cancellationToken = default);
    
    Task RollbackAsync(CancellationToken cancellationToken = default);
}