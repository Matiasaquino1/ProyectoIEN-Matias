namespace InstitutoIENService.Core.DTOs;

public class UserDto : BaseEntityDto
{
    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int RrhhId { get; set; }

    public int RoleId { get; set; }

    public string IsActive { get; set; } = null!;
}
