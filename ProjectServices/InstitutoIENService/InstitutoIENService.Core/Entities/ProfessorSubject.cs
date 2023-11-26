namespace InstitutoIENService.Core.Entities;

public partial class ProfessorSubject
{
    public int ProfessorId { get; set; }

    public int SubjectId { get; set; }

    public string? Position { get; set; }
    public DateTime RegistrationDate { get; set; }
    public DateTime? ModificationDate { get; set; }

    public virtual Subject Subject { get; set; } = null!;

    public virtual Professor Professor { get; set; } = null!;
}
