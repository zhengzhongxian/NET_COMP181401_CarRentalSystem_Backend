namespace NET_CarRentalSystem.Application.Models.DTOs.ReturnImageDTOs.Create;

public class CreateJsonReturnImageDto
{
    public Guid Id { get; set; }
    
    public string? ImageUrl { get; set; }
    
    public string? PublicId { get; set; }
    
    public int DisplayOrder { get; set; }
}

