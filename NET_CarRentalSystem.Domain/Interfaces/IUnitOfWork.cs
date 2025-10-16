namespace NET_CarRentalSystem.Domain.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<T> GetRepository<T>() where T : class;

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
