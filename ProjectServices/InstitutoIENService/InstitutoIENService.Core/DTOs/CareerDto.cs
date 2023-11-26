namespace InstitutoIENService.Core.DTOs;

public class CareerDto : BaseEntityDto
{
    public string CareerDescription { get; set; } = null!;

    public string CampusDescription { get; set; } = null!;

    public int DurationInHours { get; set; }

    public string ManagerName { get; set; } = null!;

    public int StudyPlanId { get; set; }

    public string? CareerType { get; set; }
}
