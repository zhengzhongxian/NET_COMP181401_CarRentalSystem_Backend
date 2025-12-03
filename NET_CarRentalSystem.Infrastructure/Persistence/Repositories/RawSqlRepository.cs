using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Infrastructure.Persistence.Contexts;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Repositories;

public class RawSqlRepository(RenticarReadDbContext readDbContext) : IRawSqlRepository
{
    public async Task<List<TResult>> FromSqlInterpolatedAsync<TResult>(
        FormattableString sql,
        CancellationToken cancellationToken = default) where TResult : class
    {
        return await readDbContext.Set<TResult>()
            .FromSqlInterpolated(sql)
            .ToListAsync(cancellationToken);
    }
}
