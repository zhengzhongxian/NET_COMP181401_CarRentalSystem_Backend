using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using NET_CarRentalSystem.Application.Models.DTOs.TransactionDTOs;
using NET_CarRentalSystem.Application.Models.Payments.PayOs;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Bookings.Queries.RegenerateFinalPaymentQuery;

public class RegenerateFinalPaymentQuery : IQuery<(bool, string, PaymentTransactionDto?)>
{
    public required Guid BookingId { get; init; }
}

public class RegenerateFinalPaymentQueryHandler(
    IUnitOfWork unitOfWork,
    IPayOsService payOsService) : IRequestHandler<RegenerateFinalPaymentQuery, (bool, string, PaymentTransactionDto?)>
{
    public async Task<(bool, string, PaymentTransactionDto?)> Handle(
        RegenerateFinalPaymentQuery request,
        CancellationToken cancellationToken)
    {
        var transaction = await unitOfWork.GetWriteRepository<PaymentTransaction>()
            .GetFirstOrDefaultAsync(
                t => t.BookingId == request.BookingId && t.Type == TransactionType.FinalPayment,
                cancellationToken: cancellationToken);

        if (transaction == null)
        {
            return (false, BookingMessage.FinalPayment.TransactionNotFound, null);
        }
        
        var booking = await unitOfWork.GetWriteRepository<Booking>()
            .GetFirstOrDefaultAsync(b => b.Id == request.BookingId, cancellationToken);

        if (booking == null)
        {
            return (false, BookingMessage.FinalPayment.BookingNotFound, null);
        }

        if (booking.Status == BookingStatus.InProgress)
        {
            return (false, BookingMessage.FinalPayment.BookingInProgress, null);
        }

        var customer = await unitOfWork.GetWriteRepository<Customer>()
            .GetByIdAsync(booking.CustomerId, cancellationToken);

        var user = await unitOfWork.GetReadRepository<User>()
            .GetFirstOrDefaultAsync(u => u.Id == customer!.UserId, cancellationToken: cancellationToken);

        if (customer == null || user == null)
        {
            return (false, BookingMessage.FinalPayment.BookingNotFound, null);
        }
        
        var newTransactionCode = long.Parse($"{transaction.TransactionCode}{DateTimeOffset.UtcNow.ToUnixTimeSeconds() % 1000}");
        
        var payOsRequest = new PayOsCreateRequest
        {
            TransactionCode = newTransactionCode,
            TotalAmount = (long)transaction.Amount,
            TransactorName = $"{customer.FirstName} {customer.LastName}",
            TransactorEmail = user.Email,
            TransactorPhone = customer.PhoneNumber,
            TransactorAddress = customer.Address ?? "N/A",
            Description = $"Final: {booking.Id.ToString()[..8]}"
        };

        var payOsResponse = await payOsService.CreatePaymentAsync(payOsRequest);

        transaction.ExternalTransactionId = payOsResponse.PaymentLinkId;
        unitOfWork.GetWriteRepository<PaymentTransaction>().Update(transaction);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        var expireDate = payOsResponse.ExpiredAt.HasValue
            ? DateTimeOffset.FromUnixTimeSeconds(payOsResponse.ExpiredAt.Value).UtcDateTime
            : DateTime.UtcNow.AddMinutes(15);

        var transactionDto = new PaymentTransactionDto
        {
            BookingId = transaction.BookingId,
            TransactionCode = transaction.TransactionCode,
            TransactionId = transaction.Id,
            Status = transaction.Status,
            AmountToPay = transaction.Amount,
            PaymentMethod = transaction.PaymentMethod,
            PaymentUrl = payOsResponse.CheckoutUrl,
            QrCode = payOsResponse.QrCode,
            ExpireDate = expireDate,
            TransactionType = transaction.Type
        };

        return (true, BookingMessage.FinalPayment.RegenerateSuccess, transactionDto);
    }
}
