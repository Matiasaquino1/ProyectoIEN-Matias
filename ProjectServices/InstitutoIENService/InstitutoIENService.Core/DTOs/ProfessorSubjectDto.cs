namespace InstitutoIENService.Core.DTOs;

public class ProfessorSubjectDto
{
    public int ProfessorId { get; set; }

    public int SubjectId { get; set; }

    public string? Position { get; set; }

    public DateTime RegistrationDate { get; set; }

    public DateTime? ModificationDate { get; set; }
}
