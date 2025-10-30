using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Domain.Common;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Infrastructure.Persistence.Contexts;
using NET_CarRentalSystem.Shared.Enums;
using NET_CarRentalSystem.Shared.Pagination;
using System.Linq.Expressions;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Repositories;

public class GenericRepository<T>(RenticarWriteDbContext writeDbContext, RenticarReadDbContext readDbContext)
    : IGenericRepository<T> where T : class
{

    public IQueryable<T> GetQueryable()
    {
        IQueryable<T> query = readDbContext.Set<T>();

        if (typeof(BaseEntity).IsAssignableFrom(typeof(T)))
        {
            query = query.Cast<BaseEntity>()
                .OrderByDescending(e => e.UpdatedAt)
                .Cast<T>();
        }

        return query.AsQueryable();
    }

    public async Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default,
        bool useWriteConnection = false)
    {
        var db = useWriteConnection ? (DbContext)writeDbContext : readDbContext;
        return await db.Set<T>().FindAsync([id], cancellationToken);
    }

    public async Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await GetQueryable().ToListAsync(cancellationToken);
    }

    public async Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate,
        CancellationToken cancellationToken = default)
    {
        return await GetQueryable().Where(predicate).ToListAsync(cancellationToken);
    }

    public async Task AddAsync(T entity, CancellationToken cancellationToken = default)
    {
        await writeDbContext.Set<T>().AddAsync(entity, cancellationToken);
    }

    public void Update(T entity)
    {
        writeDbContext.Set<T>().Update(entity);
    }

    public void Remove(T entity, bool hardDelete = false)
    {
        if (hardDelete)
        {
            writeDbContext.Set<T>().Remove(entity);
            return;
        }

        if (entity is BaseEntity baseEntity)
        {
            baseEntity.IsDeleted = true;
            writeDbContext.Entry(baseEntity).State = EntityState.Modified;
        }
        else
        {
            writeDbContext.Set<T>().Remove(entity);
        }
    }

    public async Task<PagedList<T>> GetPagedAsync(
        PagingParams pagingParams,
        Expression<Func<T, bool>>? filter = null,
        string includeProperties = "")
    {
        IQueryable<T> query = readDbContext.Set<T>();

        query = includeProperties
            .Split([','], StringSplitOptions.RemoveEmptyEntries)
            .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

        if (filter != null)
        {
            query = query.Where(filter);
        }
        
        var count = await query.CountAsync();
        
        if (!string.IsNullOrWhiteSpace(pagingParams.SortBy))
        {
            query = pagingParams.SortDirection?.ToLower() == "desc"
                ? query.OrderByDescending(v => EF.Property<object>(v, pagingParams.SortBy))
                : query.OrderBy(v => EF.Property<object>(v, pagingParams.SortBy));
        }
        else if (typeof(BaseEntity).IsAssignableFrom(typeof(T)))
        {
            // Áp dụng sắp xếp mặc định nếu không có sortBy
            query = query.Cast<BaseEntity>().OrderByDescending(e => e.UpdatedAt).Cast<T>();
        }

        var items = await query
            .Skip((pagingParams.PageNumber - 1) * pagingParams.PageSize)
            .Take(pagingParams.PageSize)
            .ToListAsync();

        return new PagedList<T>(items, count, pagingParams.PageNumber, pagingParams.PageSize);
    }

    public async Task<T?> GetFirstOrDefaultAsync(
        Expression<Func<T, bool>> filter, string includeProperties = "",
        CancellationToken cancellationToken = default,
        bool useWriteConnection = false)
    {
        IQueryable<T> query = useWriteConnection ? writeDbContext.Set<T>() : readDbContext.Set<T>();
        query = includeProperties
            .Split([','], StringSplitOptions.RemoveEmptyEntries)
            .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

        return await query.FirstOrDefaultAsync(filter, cancellationToken);
    }

    public async Task<T?> GetSingleOrDefaultAsync(
        Expression<Func<T, bool>> filter,
        string includeProperties = "",
        CancellationToken cancellationToken = default,
        bool useWriteConnection = false)
    {
        IQueryable<T> query = useWriteConnection ? writeDbContext.Set<T>() : readDbContext.Set<T>();
        query = includeProperties
            .Split([','], StringSplitOptions.RemoveEmptyEntries)
            .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

        return await query.SingleOrDefaultAsync(filter, cancellationToken);
    }

    public async Task<List<T>> GetAsync(
        Expression<Func<T, bool>>? filter = null,
        string? sortBy = null, string? sortDirection = "asc",
        string includeProperties = "")
    {
        IQueryable<T> query = readDbContext.Set<T>();

        if (filter != null)
        {
            query = query.Where(filter);
        }

        query = includeProperties
            .Split([','], StringSplitOptions.RemoveEmptyEntries)
            .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

        if (!string.IsNullOrWhiteSpace(sortBy))
        {
            query = sortDirection?.ToLower() == "desc"
                ? query.OrderByDescending(v => EF.Property<object>(v, sortBy))
                : query.OrderBy(v => EF.Property<object>(v, sortBy));
        }
        else if (typeof(BaseEntity).IsAssignableFrom(typeof(T)))
        {
            query = query.Cast<BaseEntity>().OrderByDescending(e => e.UpdatedAt).Cast<T>();
        }

        return await query.ToListAsync();
    }

    public async Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate,
        CancellationToken cancellationToken = default)
    {
        return await readDbContext.Set<T>().AnyAsync(predicate, cancellationToken);
    }

    public async Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null,
        CancellationToken cancellationToken = default)
    {
        if (predicate == null)
        {
            return await readDbContext.Set<T>().CountAsync(cancellationToken);
        }

        return await readDbContext.Set<T>().CountAsync(predicate, cancellationToken);
    }

    public async Task<TResult> GetAggregateValueAsync<TResult>(
        Expression<Func<T, TResult>> selector,
        AggregateType aggregateType,
        Expression<Func<T, bool>>? filter = null,
        CancellationToken cancellationToken = default)
    {
        IQueryable<T> query = readDbContext.Set<T>();
        if (filter != null)
        {
            query = query.Where(filter);
        }

        return aggregateType switch
        {
            AggregateType.Min => await query.MinAsync(selector, cancellationToken),
            AggregateType.Max => await query.MaxAsync(selector, cancellationToken),
            _ => throw new NotSupportedException($"Aggregate type '{aggregateType}' is not supported.")
        };
    }

    public async Task<T> FirstAsync(
        Expression<Func<T, bool>> predicate,
        CancellationToken cancellationToken = default)
    {
        return await readDbContext.Set<T>().FirstAsync(predicate, cancellationToken);
    }

    public async Task<List<T>> FromSqlInterpolatedAsync(
        FormattableString sql,
        CancellationToken cancellationToken = default)
    {
        return await readDbContext.Set<T>()
            .FromSqlInterpolated(sql)
            .ToListAsync(cancellationToken);
    }



    public async Task<int> ExecuteSqlInterpolatedAsync(
        FormattableString sql,
        CancellationToken cancellationToken = default)
    {
        return await writeDbContext.Database.ExecuteSqlInterpolatedAsync(sql, cancellationToken);
    }

    public async Task<T?> GetFirstOrDefaultWithDeletedIncludesAsync(
        Expression<Func<T, bool>> filter,
        string includeProperties = "",
        CancellationToken cancellationToken = default,
        bool useWriteConnection = false)

    {

        var db = useWriteConnection ? (DbContext)writeDbContext : readDbContext;
        var query = db.Set<T>().IgnoreQueryFilters();

        query = includeProperties
            .Split([','], StringSplitOptions.RemoveEmptyEntries)
            .Select(includeProperty => includeProperty.Trim()).Aggregate(query, (current, trimmedProperty) => current.Include(trimmedProperty));

        var allEntities = await query.Where(filter).ToListAsync(cancellationToken);
        var result = allEntities.FirstOrDefault(entity =>
        {
            if (entity is BaseEntity baseEntity)
            {
                return !baseEntity.IsDeleted;

            }
            return true;
        });
        
        return result;
    }
    
    public IQueryable<T> GetQueryable(
        Expression<Func<T, bool>>? filter,
        string includeProperties = "")
    {
        IQueryable<T> query = readDbContext.Set<T>();

        if (filter != null)
        {
            query = query.Where(filter);
        }

        query = includeProperties
            .Split([','], StringSplitOptions.RemoveEmptyEntries)
            .Aggregate(query, (current, includeProperty) => current.Include(includeProperty.Trim()));

        return query.AsQueryable();
    }


}