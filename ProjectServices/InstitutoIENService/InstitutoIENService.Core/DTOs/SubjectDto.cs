namespace InstitutoIENService.Core.DTOs;

public class SubjectDto : BaseEntityDto
{
    public string Name { get; set; } = null!;

    public decimal CompulsoryAttendanceRate { get; set; }

    public int CareerId { get; set; }
}
