namespace InstitutoIENService.Core.DTOs;

public class ProfessorDto : BaseEntityDto
{
    public string? RegistrationNumber { get; set; }

    public DateTime? DateOfEntry { get; set; }

    public DateTime? DateOfTermination { get; set; }
}
