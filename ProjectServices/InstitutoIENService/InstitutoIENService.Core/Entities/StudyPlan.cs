namespace InstitutoIENService.Core.Entities;

public partial class StudyPlan:BaseEntity
{
    public string PlanName { get; set; } = null!;

    public string? Observation { get; set; }

    public int PlanYear { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual ICollection<Career> Careers { get; set; } = new List<Career>();

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
