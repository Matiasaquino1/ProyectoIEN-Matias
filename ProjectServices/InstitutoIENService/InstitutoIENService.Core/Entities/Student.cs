namespace InstitutoIENService.Core.Entities;

public partial class Student : BaseEntity
{
    public string RegistrationNumber { get; set; } = null!;

    public decimal? AverageScore { get; set; }

    public decimal? OverallAverageScore { get; set; }

    public int StudyPlanId { get; set; }

    public string StatusEnrollmentType { get; set; } = null!;

    public DateTime? AdmissionDate { get; set; }

    public DateTime? GraduationDate { get; set; }

    public virtual ICollection<CommissionDetail> CommissionDetails { get; set; } = new List<CommissionDetail>();

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    public virtual Rrhh Rrhh { get; set; } = null!;

    public virtual StudyPlan StudyPlan { get; set; } = null!;

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
