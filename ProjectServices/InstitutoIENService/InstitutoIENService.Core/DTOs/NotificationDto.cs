namespace InstitutoIENService.Core.DTOs;

public class NotificationDto : BaseEntityDto
{
    public string Message { get; set; } = null!;

    public int UserId { get; set; }
}
