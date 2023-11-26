namespace InstitutoIENService.Core.Entities;

public partial class Schedule : BaseEntity
{
    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public int DayNumber { get; set; }
    public virtual ICollection<CommissionDetail> CommissionsDetails { get; set; } = new List<CommissionDetail>();
}
