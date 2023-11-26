namespace InstitutoIENService.Core.DTOs;

public class StudyPlanDto : BaseEntityDto
{
    public string PlanName { get; set; } = null!;

    public string? Observation { get; set; }

    public int PlanYear { get; set; }
}
