using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Domain.Common;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Infrastructure.Persistence.Contexts;
using NET_CarRentalSystem.Shared.Pagination;
using System.Linq.Expressions;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Repositories;

public class GenericRepository<T>(RenticarWriteDbContext writeDbContext, RenticarReadDbContext readDbContext) : IGenericRepository<T> where T : class
{
    private readonly RenticarWriteDbContext _writeDbContext = writeDbContext;
    private readonly RenticarReadDbContext _readDbContext = readDbContext;

    public IQueryable<T> GetQueryable()
    {
        IQueryable<T> query = _readDbContext.Set<T>();

        if (typeof(BaseEntity).IsAssignableFrom(typeof(T)))
        {
            var baseQuery = query.Cast<BaseEntity>();

            var orderedQuery = baseQuery.OrderByDescending(e => e.CreatedAt);

            query = orderedQuery.Cast<T>();
        }

        return query.AsQueryable();
    }

    public async Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _readDbContext.Set<T>().FindAsync([id], cancellationToken: cancellationToken);
    }

    public async Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await GetQueryable().ToListAsync(cancellationToken);
    }

    public async Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
    {
        return await _readDbContext.Set<T>().Where(predicate).ToListAsync(cancellationToken);
    }

    public async Task AddAsync(T entity, CancellationToken cancellationToken = default)
    {
        await _writeDbContext.Set<T>().AddAsync(entity, cancellationToken);
    }

    public void Update(T entity)
    {
        _writeDbContext.Set<T>().Update(entity);
    }

    public void Remove(T entity, bool hardDelete = false)
    {
        if (hardDelete)
        {
            _writeDbContext.Set<T>().Remove(entity);
            return;
        }

        if (entity is BaseEntity baseEntity)
        {
            baseEntity.IsDeleted = true;
            _writeDbContext.Entry(baseEntity).State = EntityState.Modified;
        }
        else
        {
            _writeDbContext.Set<T>().Remove(entity);
        }
    }

    public async Task<List<T>> GetAsync(
    Expression<Func<T, bool>>? filter = null,
    Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
    string includeProperties = "")
    {
        IQueryable<T> query = _readDbContext.Set<T>();

        if (filter != null)
        {
            query = query.Where(filter);
        }

        foreach (var includeProperty in includeProperties.Split
            (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        {
            query = query.Include(includeProperty);
        }

        if (orderBy != null)
        {
            return await orderBy(query).ToListAsync();
        }

        return await GetQueryable().ToListAsync();
    }

    public async Task<PagedList<T>> GetPagedAsync(
        PagingParams pagingParams,
        Expression<Func<T, bool>>? filter = null,
        string includeProperties = "")
    {
        IQueryable<T> query = _readDbContext.Set<T>();

        if (filter != null)
        {
            query = query.Where(filter);
        }

        foreach (var includeProperty in includeProperties.Split
            ([','], StringSplitOptions.RemoveEmptyEntries))
        {
            query = query.Include(includeProperty);
        }

        if (!string.IsNullOrWhiteSpace(pagingParams.SortBy))
        {
            query = pagingParams.SortDirection?.ToLower() == "desc"
                ? query.OrderByDescending(v => EF.Property<object>(v, pagingParams.SortBy))
                : query.OrderBy(v => EF.Property<object>(v, pagingParams.SortBy));
        }
        else if (typeof(BaseEntity).IsAssignableFrom(typeof(T)))
        {
            // Áp dụng sắp xếp mặc định nếu không có sortBy
            query = query.Cast<BaseEntity>().OrderByDescending(e => e.CreatedAt).Cast<T>();
        }

        var count = await query.CountAsync();
        var items = await query
            .Skip((pagingParams.PageNumber - 1) * pagingParams.PageSize)
            .Take(pagingParams.PageSize)
            .ToListAsync();

        return new PagedList<T>(items, count, pagingParams.PageNumber, pagingParams.PageSize);
    }
}

