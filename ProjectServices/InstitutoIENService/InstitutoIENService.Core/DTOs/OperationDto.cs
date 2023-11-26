namespace InstitutoIENService.Core.DTOs;

public class OperationDto : BaseEntityDto
{
    public string Description { get; set; } = null!;

    public int ModuleId { get; set; }
}
