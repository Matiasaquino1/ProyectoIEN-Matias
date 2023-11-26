namespace InstitutoIENService.Core.DTOs;

public class CommissionDetailDto : BaseEntityDto
{
    public int CommissionId { get; set; }

    public int StudenId { get; set; }

    public int SubjectId { get; set; }

    public int ClassroomId { get; set; }

    public int ScheduleId { get; set; }
}
