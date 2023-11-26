namespace InstitutoIENService.Core.Entities;

public partial class CommissionDetail : BaseEntity
{
    public int CommissionId { get; set; }

    public int StudenId { get; set; }

    public int SubjectId { get; set; }

    public int ClassroomId { get; set; }

    public int ScheduleId { get; set; }

    public virtual Student Student { get; set; } = null!;

    public virtual Classroom Classroom { get; set; } = null!;

    public virtual Commission Commission { get; set; } = null!;

    public virtual Schedule Schedule { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;
}
