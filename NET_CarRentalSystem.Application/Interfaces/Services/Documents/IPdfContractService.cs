namespace NET_CarRentalSystem.Application.Interfaces.Services.Documents;

public interface IPdfContractService
{
    Task<(bool Success, string Message, string? FileName)> GenerateBookingContractAsync(
        Guid bookingId,
        CancellationToken cancellationToken = default);
}

