namespace NET_CarRentalSystem.API.Models.Response.Auth
{
    public class LoginResponse
    {
        public required string AccessToken { get; set; }
        
        public DateTime AccessTokenExpiry { get; set; }
        
        public required string RefreshToken { get; set; }
        
        public DateTime RefreshTokenExpiry { get; set; }
    }
}