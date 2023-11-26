namespace InstitutoIENService.Core.DTOs;

public class ScheduleDto : BaseEntityDto
{
    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public int DayNumber { get; set; }
}
