using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using NET_CarRentalSystem.Application.Models.Payments.PayOs;
using NET_CarRentalSystem.Application.Models.Payments.PayOs.Webhooks;
using NET_CarRentalSystem.Domain.Exceptions.PayOs;
using PayOS;
using PayOS.Models.V1.Payouts;
using PayOS.Models.V2.PaymentRequests;
using PayOS.Models.Webhooks;

namespace NET_CarRentalSystem.Infrastructure.Services.Payments;

public class PayOsService(
    IOptions<PayOsSettings> payOsSetting,
    PayOSClient payOsClient) : IPayOsService
{
    private readonly PayOsSettings _payOsSetting = payOsSetting.Value;
    
    public async Task<PayOsCreateResponse> CreatePaymentAsync(PayOsCreateRequest payOsCreateRequest)
    {
        var expirationTime = DateTimeOffset.UtcNow.AddMinutes(_payOsSetting.ExpiryMinutes);
        var unixTimestamp = expirationTime.ToUnixTimeSeconds();
        
        var paymentRequest = new CreatePaymentLinkRequest
        {
            OrderCode = payOsCreateRequest.TransactionCode,
            Amount = payOsCreateRequest.TotalAmount,
            Description = payOsCreateRequest.Description,
            ReturnUrl = _payOsSetting.ReturnUrl,
            CancelUrl = _payOsSetting.CancelUrl,
            BuyerName = payOsCreateRequest.TransactorName,
            BuyerEmail = payOsCreateRequest.TransactorEmail,
            BuyerPhone = payOsCreateRequest.TransactorPhone,
            ExpiredAt = unixTimestamp
        };

        try
        {
            var result = await payOsClient.PaymentRequests.CreateAsync(paymentRequest);
            
            if (result == null)
            {
                throw new PayOsTechnicalException("Received null response from PayOS API.");
            }
            
            return new PayOsCreateResponse
            {
                Bin = result.Bin,
                AccountNumber = result.AccountNumber,
                AccountName = result.AccountName,
                Amount = result.Amount,
                Description = result.Description,
                OrderCode = result.OrderCode,
                Currency = result.Currency,
                PaymentLinkId = result.PaymentLinkId,
                ExpiredAt = result.ExpiredAt,
                Status = result.Status.ToString(),
                CheckoutUrl = result.CheckoutUrl,
                QrCode = result.QrCode
            };
        }
        catch (Exception ex)
        {
            throw new PayOsBusinessException($"PayOS Error: {ex.Message}", "PAYOS_ERROR");
        }
    }

    public async Task<PayOsGetPaymentLinkResponse> GetPaymentLinkInformationAsync(long orderCode)
    {
        try
        {
            var result = await payOsClient.PaymentRequests.GetAsync(orderCode);
            
            if (result == null)
            {
                throw new PayOsTechnicalException("Received null response from PayOS API.");
            }
            
            return new PayOsGetPaymentLinkResponse
            {
                Id = result.Id,
                OrderCode = result.OrderCode,
                Amount = result.Amount,
                AmountPaid = result.AmountPaid,
                AmountRemaining = result.AmountRemaining,
                Status = result.Status.ToString(),
                CreatedAt = result.CreatedAt,
                CancellationReason = result.CancellationReason,
                CanceledAt = result.CanceledAt,
                Transactions = result.Transactions?.Select(t => new PaymentTransactionInfo
                {
                    Reference = t.Reference,
                    Amount = t.Amount,
                    AccountNumber = t.AccountNumber,
                    Description = t.Description,
                    TransactionDateTime = t.TransactionDateTime,
                    CounterAccountBankId = t.CounterAccountBankId,
                    CounterAccountBankName = t.CounterAccountBankName,
                    CounterAccountName = t.CounterAccountName,
                    CounterAccountNumber = t.CounterAccountNumber,
                    VirtualAccountName = t.VirtualAccountName,
                    VirtualAccountNumber = t.VirtualAccountNumber
                }).ToList()
            };
        }
        catch (Exception ex)
        {
            throw new PayOsBusinessException($"PayOS Error: {ex.Message}", "PAYOS_GET_ERROR");
        }
    }

    public async Task<PayOsWebhookData?> VerifyWebhookAsync(PayOsWebhook webhook)
    {
        try
        {
            if (webhook.Data is null)
            {
                return null;
            }
            
            var payosWebhookData = new WebhookData
            {
                OrderCode = webhook.Data.OrderCode,
                Amount = webhook.Data.Amount,
                Description = webhook.Data.Description,
                AccountNumber = webhook.Data.AccountNumber,
                Reference = webhook.Data.Reference,
                TransactionDateTime = webhook.Data.TransactionDateTime,
                Currency = webhook.Data.Currency,
                PaymentLinkId = webhook.Data.PaymentLinkId,
                Code = webhook.Data.Code,
                CounterAccountBankId = webhook.Data.CounterAccountBankId,
                CounterAccountBankName = webhook.Data.CounterAccountBankName,
                CounterAccountName = webhook.Data.CounterAccountName,
                CounterAccountNumber = webhook.Data.CounterAccountNumber,
                VirtualAccountName = webhook.Data.VirtualAccountName,
                VirtualAccountNumber = webhook.Data.VirtualAccountNumber
            };
            
            var payosWebhook = new Webhook
            {
                Data = payosWebhookData,
                Signature = webhook.Signature ?? string.Empty
            };
            
            var verifiedData = await payOsClient.Webhooks.VerifyAsync(payosWebhook);
            
            return new PayOsWebhookData
            {
                OrderCode = verifiedData.OrderCode,
                Amount = verifiedData.Amount,
                Description = verifiedData.Description,
                AccountNumber = verifiedData.AccountNumber,
                Reference = verifiedData.Reference,
                TransactionDateTime = verifiedData.TransactionDateTime,
                Currency = verifiedData.Currency,
                PaymentLinkId = verifiedData.PaymentLinkId,
                Code = verifiedData.Code,
                CounterAccountBankId = verifiedData.CounterAccountBankId,
                CounterAccountBankName = verifiedData.CounterAccountBankName,
                CounterAccountName = verifiedData.CounterAccountName,
                CounterAccountNumber = verifiedData.CounterAccountNumber,
                VirtualAccountName = verifiedData.VirtualAccountName,
                VirtualAccountNumber = verifiedData.VirtualAccountNumber
            };
        }
        catch (Exception ex)
        {
            throw new PayOsBusinessException($"Webhook verification failed: {ex.Message}", "WEBHOOK_VERIFY_ERROR");
        }
    }
    
    public async Task<CreatePayoutResponse> RefundPaymentAsync(CreatePayoutRequest payoutData)
    {
        try
        {
            // ✅ Validate input
            if (payoutData == null)
            {
                throw new PayOsBusinessException("Payout data cannot be null", "INVALID_PAYOUT_DATA");
            }

            string toBin = payoutData.ToBin;
            string toAccountNumber = payoutData.ToAccountNumber;

            // ✅ Nếu có TransactionCode, lấy thông tin tài khoản từ payment đã thanh toán
            if (payoutData.TransactionCode.HasValue)
            {
                var paymentInfo = await GetPaymentLinkInformationAsync(payoutData.TransactionCode.Value);
                
                // Lấy thông tin từ transactions (tài khoản người chuyển tiền)
                if (paymentInfo.Transactions != null && paymentInfo.Transactions.Count > 0)
                {
                    var transaction = paymentInfo.Transactions[0];
                    
                    if (!string.IsNullOrEmpty(transaction.CounterAccountBankId) && 
                        !string.IsNullOrEmpty(transaction.CounterAccountNumber))
                    {
                        toBin = transaction.CounterAccountBankId;
                        toAccountNumber = transaction.CounterAccountNumber;
                    }
                }
            }

            // ✅ Validate thông tin tài khoản
            if (string.IsNullOrWhiteSpace(toBin) || 
                string.IsNullOrWhiteSpace(toAccountNumber) || 
                payoutData.Amount <= 0)
            {
                throw new PayOsBusinessException(
                    "Missing or invalid payout information (bank code, account number, or amount)", 
                    "INVALID_PAYOUT_DATA");
            }

            // ✅ Tạo PayOS PayoutRequest
            var payosPayoutRequest = new PayoutRequest
            {
                ReferenceId = payoutData.ReferenceId,
                Amount = payoutData.Amount,
                Description = payoutData.Description,
                ToBin = toBin,
                ToAccountNumber = toAccountNumber
            };
            
            var result = await payOsClient.Payouts.CreateAsync(payosPayoutRequest);
            
            if (result == null)
            {
                throw new PayOsTechnicalException("Received null response from PayOS Payout API.");
            }
            
            return new CreatePayoutResponse
            {
                Id = result.Id,
                ReferenceId = result.ReferenceId,
                Transactions = result.Transactions?.Select(t => new PayoutTransactionDto
                {
                    Id = t.Id,
                    ReferenceId = t.ReferenceId,
                    Amount = t.Amount,
                    Description = t.Description,
                    ToBin = t.ToBin,
                    ToAccountNumber = t.ToAccountNumber,
                    ToAccountName = t.ToAccountName,
                    Reference = t.Reference,
                    TransactionDatetime = t.TransactionDatetime,
                    ErrorMessage = t.ErrorMessage,
                    ErrorCode = t.ErrorCode,
                    State = t.State.ToString()
                }).ToList(),
                ApprovalState = result.ApprovalState.ToString(),
                CreatedAt = result.CreatedAt
            };
        }
        catch (PayOsBusinessException)
        {
            throw;
        }
        catch (PayOsTechnicalException)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new PayOsBusinessException($"Payout (Refund) failed: {ex.Message}", "PAYOUT_ERROR");
        }
    }
}
