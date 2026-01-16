using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.API.Extensions;

public static class QueryExecutorExtensions
{
    public static WebApplication InitializeQueryExecutor(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var queryExecutor = scope.ServiceProvider.GetRequiredService<IQueryExecutor>();
        QueryableApplicationExtensions.Initialize(queryExecutor);

        return app;
    }
}

