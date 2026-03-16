using Microsoft.Extensions.DependencyInjection;
using NET_CarRentalSystem.Application.Interfaces.Services.Ai;
using NET_CarRentalSystem.Infrastructure.Services.Ai;

namespace NET_CarRentalSystem.Infrastructure.DependencyInjection;

public static class AiServiceRegistration
{
    public static IServiceCollection AddAiServices(this IServiceCollection services)
    {
        services.AddSingleton<IAiImageVerificationService, AiImageVerificationService>();
        services.AddSingleton<IAiTextEmbeddingService, AiTextEmbeddingService>();
        
        return services;
    }
}
