namespace NET_CarRentalSystem.Domain.Interfaces.Persistence;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<T> GetRepository<T>() where T : class;

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    IQueryRepository GetQueryRepository();

    Task<IDbTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default);
    
    Task ExecuteInTransactionAsync(Func<CancellationToken, Task> operation, CancellationToken cancellationToken = default);
    
    Task<TResult> ExecuteInTransactionAsync<TResult>(Func<CancellationToken, Task<TResult>> operation, CancellationToken cancellationToken = default);
}
