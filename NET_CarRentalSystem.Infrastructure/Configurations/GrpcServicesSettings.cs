using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Infrastructure.Configurations;

public class GrpcServicesSettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.GrpcServices;
    
    public int MaxMessageSizeMb { get; set; } = 10;
    
    public int TimeoutSeconds { get; set; } = 30;
    
    public GrpcServiceEndpoint AiService { get; set; } = new();
}

public class GrpcServiceEndpoint
{
    public string Address { get; set; } = "http://localhost:50051";
    public bool Enabled { get; set; } = true;
}
