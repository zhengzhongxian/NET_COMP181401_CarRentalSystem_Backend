using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using NET_CarRentalSystem.Application.Models.DTOs.TransactionDTOs;
using NET_CarRentalSystem.Application.Models.Payments.PayOs;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.CoreHelpers;

namespace NET_CarRentalSystem.Application.Features.Violations.Commands.CreateViolationPaymentCommand;

public class CreateViolationPaymentCommand : ICommand<(bool Success, string Message, PaymentTransactionDto? Transaction)>
{
    public Guid ViolationId { get; set; }
}

public class CreateViolationPaymentCommandHandler(
    IUnitOfWork unitOfWork,
    IPayOsService payOsService) : IRequestHandler<CreateViolationPaymentCommand, (bool, string, PaymentTransactionDto?)>
{
    public async Task<(bool, string, PaymentTransactionDto?)> Handle(
        CreateViolationPaymentCommand request,
        CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async ct =>
        {
            var violation = await unitOfWork.GetWriteRepository<BookingViolation>()
                .GetFirstOrDefaultAsync(v => v.Id == request.ViolationId, ct);

            if (violation == null)
                return (false, ViolationMessage.CreatePaymentLink.ViolationNotFound, null);
            
            var booking = await unitOfWork.GetWriteRepository<Booking>()
                .GetFirstOrDefaultAsync(b => b.Id == violation.BookingId, ct);

            if (booking == null)
                return (false, ViolationMessage.CreatePaymentLink.ViolationNotFound, null);

            var customer = await unitOfWork.GetReadRepository<Customer>()
                .GetFirstOrDefaultAsync(c => c.CustomerId == booking.CustomerId, cancellationToken: ct);

            if (customer == null)
                return (false, ViolationMessage.CreatePaymentLink.ViolationNotFound, null);

            var user = customer.UserId.HasValue
                ? await unitOfWork.GetReadRepository<User>().GetByIdAsync(customer.UserId.Value, ct)
                : null;
            
            if (violation.ViolationType == ViolationType.VehicleDamage)
                return (false, ViolationMessage.CreatePaymentLink.InvalidViolationType, null);

            switch (violation.Status)
            {
                case ViolationStatus.Paid:
                case ViolationStatus.Resolved:
                    return (false, ViolationMessage.CreatePaymentLink.AlreadyPaid, null);
                case ViolationStatus.PaymentPending when violation.PaymentTransactionId.HasValue:
                {
                    var existingTransaction = await unitOfWork.GetReadRepository<PaymentTransaction>()
                        .GetByIdAsync(violation.PaymentTransactionId.Value, ct);

                    if (existingTransaction is { Status: TransactionStatus.Pending })
                    {
                        var existingDto = new PaymentTransactionDto
                        {
                            TransactionId = existingTransaction.Id,
                            TransactionCode = existingTransaction.TransactionCode,
                            AmountToPay = existingTransaction.Amount,
                            Status = existingTransaction.Status,
                            PaymentMethod = existingTransaction.PaymentMethod,
                            TransactionType = existingTransaction.Type,
                            BookingId = existingTransaction.BookingId
                        };

                        return (true, ViolationMessage.CreatePaymentLink.Success, existingDto);
                    }

                    break;
                }
            }

            // 4. Generate transaction code
            var transactionCode = TransactionHelper.CreateCode();

            // 5. Create payment transaction
            var transaction = new PaymentTransaction
            {
                TransactionCode = transactionCode,
                BookingId = violation.BookingId,
                Amount = violation.Amount,
                PaymentDate = DateTime.UtcNow,
                PaymentMethod = PaymentMethod.PayOs,
                Type = TransactionType.ViolationPayment,
                Status = TransactionStatus.Pending,
                Note = $"Thanh toán vi phạm: {violation.Description}"
            };

            await unitOfWork.GetWriteRepository<PaymentTransaction>().AddAsync(transaction, ct);
            await unitOfWork.SaveChangesAsync(ct);

            var payOsDesc = $"VP {violation.ViolationType}";
            if (payOsDesc.Length > 25) payOsDesc = payOsDesc[..25];
            
            var payOsRequest = new PayOsCreateRequest
            {
                TransactionCode = transactionCode,
                TotalAmount = (long)violation.Amount,
                TransactorName = $"{customer.FirstName} {customer.LastName}",
                TransactorEmail = user?.Email ?? "customer@renticar.com",
                TransactorPhone = customer.PhoneNumber,
                TransactorAddress = customer.Address ?? "N/A",
                Description = payOsDesc
            };

            var payOsResponse = await payOsService.CreatePaymentAsync(payOsRequest);
            
            violation.Status = ViolationStatus.PaymentPending;
            violation.PaymentTransactionId = transaction.Id;
            unitOfWork.GetWriteRepository<BookingViolation>().Update(violation);
            await unitOfWork.SaveChangesAsync(ct);
            
            var responseDto = new PaymentTransactionDto
            {
                TransactionId = transaction.Id,
                TransactionCode = transactionCode,
                AmountToPay = violation.Amount,
                Status = TransactionStatus.Pending,
                PaymentMethod = PaymentMethod.PayOs,
                TransactionType = TransactionType.ViolationPayment,
                PaymentUrl = payOsResponse.CheckoutUrl,
                QrCode = payOsResponse.QrCode,
                ExpireDate = payOsResponse.ExpiredAt.HasValue 
                    ? DateTimeOffset.FromUnixTimeSeconds(payOsResponse.ExpiredAt.Value).UtcDateTime 
                    : DateTime.UtcNow.AddMinutes(15)
            };

            return (true, ViolationMessage.CreatePaymentLink.Success, responseDto);

        }, cancellationToken);
    }
}
