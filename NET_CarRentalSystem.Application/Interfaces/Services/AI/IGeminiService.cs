using NET_CarRentalSystem.Application.Models.AI;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Interfaces.Services.AI;

public interface IGeminiService
{
    Task<AiEnhancedQueryParams> ParseAndEnhanceVehicleQueryAsync(
        string searchKeyword,
        IDapperRepository dapperRepository,
        CancellationToken cancellationToken = default);
}
