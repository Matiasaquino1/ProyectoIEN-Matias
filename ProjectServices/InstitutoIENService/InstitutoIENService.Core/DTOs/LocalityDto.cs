namespace InstitutoIENService.Core.DTOs;

public class LocalityDto : BaseEntityDto
{
    public string Name { get; set; } = null!;

    public int ProvinceId { get; set; }

}
