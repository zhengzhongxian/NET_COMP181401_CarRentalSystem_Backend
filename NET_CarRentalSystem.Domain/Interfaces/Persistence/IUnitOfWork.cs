namespace NET_CarRentalSystem.Domain.Interfaces.Persistence;

public interface IUnitOfWork : IDisposable
{
    IReadRepository<T> GetReadRepository<T>() where T : class;
    
    IWriteRepository<T> GetWriteRepository<T>() where T : class;

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    IRawSqlRepository GetQueryRepository();

    Task<IDbTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default);
    
    Task ExecuteInTransactionAsync(Func<CancellationToken, Task> operation, CancellationToken cancellationToken = default);
    
    Task<TResult> ExecuteInTransactionAsync<TResult>(Func<CancellationToken, Task<TResult>> operation, CancellationToken cancellationToken = default);
}
