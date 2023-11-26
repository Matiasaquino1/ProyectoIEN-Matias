namespace InstitutoIENService.Core.DTOs;

public class ProfessorTitleDto
{
    public int ProfesorId { get; set; }

    public int TitleId { get; set; }

    public string? ImageTitlePath { get; set; }

    public DateTime RegistrationDate { get; set; }

    public DateTime? ModificationDate { get; set; }
}
