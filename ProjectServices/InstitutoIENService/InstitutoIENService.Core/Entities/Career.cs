namespace InstitutoIENService.Core.Entities;

public partial class Career : BaseEntity
{
    public string CareerDescription { get; set; } = null!;

    public string CampusDescription { get; set; } = null!;

    public int DurationInHours { get; set; }

    public string ManagerName { get; set; } = null!;

    public int StudyPlanId { get; set; }

    public string? CareerType { get; set; }

    public virtual StudyPlan StudyPlan { get; set; } = null!;

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual ICollection<Subject> Subject { get; set; } = new List<Subject>();
}
