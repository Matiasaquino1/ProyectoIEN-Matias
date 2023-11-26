namespace InstitutoIENService.Core.DTOs;

public class ProvinceDto : BaseEntityDto
{

    public string Name { get; set; } = null!;

    public int CountryId { get; set; }

}
