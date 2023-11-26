namespace InstitutoIENService.Core.DTOs;

public class CommissionDto : BaseEntityDto
{
    public string Description { get; set; } = null!;

    public string CommissionCode { get; set; } = null!;

    public int Year { get; set; }

    public string CareerDescription { get; set; } = null!;

    public string YearOfCourse { get; set; } = null!;
}
