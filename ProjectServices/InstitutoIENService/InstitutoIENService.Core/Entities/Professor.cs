namespace InstitutoIENService.Core.Entities;

public partial class Professor : BaseEntity
{
    public string? RegistrationNumber { get; set; }

    public DateTime? DateOfEntry { get; set; }

    public DateTime? DateOfTermination { get; set; }

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    public virtual Rrhh Rrhh { get; set; } = null!;

    public virtual ICollection<ProfessorSubject> ProfessorsSubjects { get; set; } = new List<ProfessorSubject>();

    public virtual ICollection<ProfessorTitle> ProfessorsTitles { get; set; } = new List<ProfessorTitle>();
}
