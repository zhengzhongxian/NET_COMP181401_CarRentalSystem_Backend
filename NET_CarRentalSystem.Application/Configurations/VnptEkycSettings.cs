using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Configurations;

public class VnptEkycSettings
{
    public static string SectionName => KeyConstants.ConfigurationSections.VnptEkycSettings;

    public string BaseUrl { get; set; } = "https://api.idg.vnpt.vn";

    public string TokenId { get; set; } = string.Empty;

    public string TokenKey { get; set; } = string.Empty;

    public string AccessToken { get; set; } = string.Empty;

    public string MacAddress { get; set; } = "CARRENTAL01";

    public double FaceMatchThreshold { get; set; } = 80.0;
}
