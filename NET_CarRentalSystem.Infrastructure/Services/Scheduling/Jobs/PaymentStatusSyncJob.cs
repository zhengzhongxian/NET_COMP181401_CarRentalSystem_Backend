using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Quartz;
using NET_CarRentalSystem.Application.Features.Payments.Events;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Infrastructure.Services.Scheduling.Jobs;

[DisallowConcurrentExecution]
public class PaymentStatusSyncJob(
    ILogger<PaymentStatusSyncJob> logger,
    IServiceScopeFactory serviceScopeFactory) : IJob
{
    public async Task Execute(IJobExecutionContext context)
    {
        try
        {
            logger.LogInformation("[PaymentStatusSyncJob] Starting payment status synchronization at {time}", DateTime.UtcNow);

            using var scope = serviceScopeFactory.CreateScope();
            var serviceProvider = scope.ServiceProvider;

            var unitOfWork = serviceProvider.GetRequiredService<IUnitOfWork>();
            var publishEndpoint = serviceProvider.GetRequiredService<IPublishEndpoint>();

            var pendingTransactions = await unitOfWork.GetWriteRepository<PaymentTransaction>()
                .GetAsync(
                    filter: t => t.Status == TransactionStatus.Pending &&
                                t.CreatedAt < DateTime.UtcNow.AddMinutes(-15),
                    sortBy: "CreatedAt",
                    sortDirection: "asc",
                    cancellationToken: context.CancellationToken
                );

            logger.LogInformation("[PaymentStatusSyncJob] Found {Count} pending transactions", pendingTransactions.Count);

            if (pendingTransactions.Count == 0)
            {
                logger.LogInformation("[PaymentStatusSyncJob] No pending transactions to sync");
                return;
            }

            foreach (var transaction in pendingTransactions)
            {
                await publishEndpoint.Publish(new PaymentSyncEvent
                {
                    TransactionId = transaction.Id,
                    TransactionCode = transaction.TransactionCode
                }, context.CancellationToken);
            }

            logger.LogInformation("[PaymentStatusSyncJob] Published {Count} PaymentSyncEvents to RabbitMQ",
                pendingTransactions.Count);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "[PaymentStatusSyncJob] Fatal error during payment synchronization");
            throw;
        }
    }
}