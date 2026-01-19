using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Documents;

namespace NET_CarRentalSystem.Application.Features.Bookings.Commands.GenerateBookingContractCommand;

public class GenerateBookingContractCommand : ICommand<(bool Success, string Message, string? FileName)>
{
    public required Guid BookingId { get; init; }
}

public class GenerateBookingContractCommandHandler(
    IPdfContractService pdfContractService) : IRequestHandler<GenerateBookingContractCommand, (bool Success, string Message, string? FileName)>
{
    public async Task<(bool Success, string Message, string? FileName)> Handle(
        GenerateBookingContractCommand request, 
        CancellationToken cancellationToken)
    {
        var (success, message, fileName) = await pdfContractService.GenerateBookingContractAsync(
            request.BookingId,
            cancellationToken);

        return (success, message, fileName);
    }
}

