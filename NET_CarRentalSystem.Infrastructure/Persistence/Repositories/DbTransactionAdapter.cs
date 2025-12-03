using Microsoft.EntityFrameworkCore.Storage;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Repositories;

public class DbTransactionAdapter(IDbContextTransaction efTransaction) : IDbTransaction
{
    public async Task CommitAsync(CancellationToken cancellationToken = default) 
    {
        await efTransaction.CommitAsync(cancellationToken);
    }

    public async Task RollbackAsync(CancellationToken cancellationToken = default) 
    {
        await efTransaction.RollbackAsync(cancellationToken);
    }

    public void Dispose() => efTransaction.Dispose();
    
    public async ValueTask DisposeAsync() => await efTransaction.DisposeAsync();
    
    public System.Data.IDbTransaction GetDbTransaction() => efTransaction.GetDbTransaction();
}