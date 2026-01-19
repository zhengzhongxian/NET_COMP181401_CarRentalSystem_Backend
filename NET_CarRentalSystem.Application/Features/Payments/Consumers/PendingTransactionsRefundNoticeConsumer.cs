using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Payments.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Notifications;
using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Features.Payments.Consumers;

public class PendingTransactionsRefundNoticeConsumer(
    ILogger<PendingTransactionsRefundNoticeConsumer> logger,
    IEmailService emailService,
    IConfiguration configuration) : IConsumer<PendingTransactionsRefundNoticeEvent>
{
    public async Task Consume(ConsumeContext<PendingTransactionsRefundNoticeEvent> context)
    {
        var @event = context.Message;
        
        logger.LogInformation(
            "[PendingTransactionsRefundNotice] Started processing. CustomerId={CustomerId}, TransactionCount={TransactionCount}, TotalAmount={TotalAmount}VND",
            @event.CustomerId, @event.TransactionCount, @event.TotalAmount);
        
        var appUrl = configuration[KeyConstants.EmailRedirectUrl] ?? "http://localhost:5173";
        
        var placeholders = new Dictionary<string, string>
        {
            { "CustomerName", @event.CustomerName },
            { "TransactionCount", @event.TransactionCount.ToString() },
            { "TotalAmount", $"{@event.TotalAmount:N0}đ" },
            { "TransactionCodes", string.Join(", ", @event.TransactionCodes) },
            { "AppUrl", appUrl.TrimEnd('/') }
        };
        
        await emailService.SendTemplateEmailViaGmailApiAsync(
            @event.CustomerEmail,
            "Thông báo hoàn tiền giao dịch - Renticar",
            AppConstants.EmailTemplates.PendingTransactionsRefundNotice,
            placeholders,
            context.CancellationToken
        );
        
        logger.LogInformation(
            "[PendingTransactionsRefundNotice] Email sent successfully. CustomerId={CustomerId}, Email={Email}, TransactionCount={TransactionCount}",
            @event.CustomerId, @event.CustomerEmail, @event.TransactionCount);
    }
}

