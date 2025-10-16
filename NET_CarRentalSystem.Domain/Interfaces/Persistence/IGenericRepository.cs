namespace NET_CarRentalSystem.Domain.Interfaces;

public interface IGenericRepository<T> where T : class
{
    IQueryable<T> GetQueryable();

    Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task AddAsync(T entity, CancellationToken cancellationToken = default);

    void Update(T entity);

    void Remove(T entity);
}

