using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using NET_CarRentalSystem.Application.Models.DTOs.PaymentDTOs.Create;

namespace NET_CarRentalSystem.Application.Features.Payments.Commands.CreatePaymentQrLinkCommand;

public class CreatePaymentQrLinkCommand : ICommand<CreatePaymentQrLinkDto>
{
    public required decimal Amount { get; init; }
    public required string Description { get; init; }
}

public class CreatePaymentQrLinkCommandHandler(IVnPayService vnPayService) 
    : IRequestHandler<CreatePaymentQrLinkCommand, CreatePaymentQrLinkDto>
{
    public async Task<CreatePaymentQrLinkDto> Handle(
        CreatePaymentQrLinkCommand request, 
        CancellationToken cancellationToken)
    {
        var qrCodeUrl = await vnPayService.GeneratePaymentQrCodeAsync(
            request.Amount,
            request.Description
        );

        return new CreatePaymentQrLinkDto
        {
            QrCodeUrl = qrCodeUrl,
            Amount = request.Amount,
            Description = request.Description,
            CreatedAt = DateTime.UtcNow
        };
    }
}