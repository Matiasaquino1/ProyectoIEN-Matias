namespace InstitutoIENService.Core.Entities;

public partial class Subject:BaseEntity
{
    public string Name { get; set; } = null!;

    public decimal CompulsoryAttendanceRate { get; set; }

    public int CareerId { get; set; }

    public virtual ICollection<CommissionDetail> CommissionsDetails { get; set; } = new List<CommissionDetail>();

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    public virtual Career Career { get; set; } = null!;

    public virtual ICollection<SubjectTopic> SubjectsTopics { get; set; } = new List<SubjectTopic>();

    public virtual ICollection<ProfessorSubject> ProfessorsSubjects { get; set; } = new List<ProfessorSubject>();
}
