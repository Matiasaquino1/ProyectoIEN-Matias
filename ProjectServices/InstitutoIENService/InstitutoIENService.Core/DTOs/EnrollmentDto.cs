namespace InstitutoIENService.Core.DTOs;

public class EnrollmentDto
{
    public int StudenId { get; set; }

    public int CareerId { get; set; }

    public int DniNumber { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int CellPhone { get; set; }

    public int Phone { get; set; }

    public string Address { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string? Email { get; set; }

    public DateTime DateOfBirth { get; set; }

    public DateTime EnrollmentDate { get; set; }

    public int StudyPlanId { get; set; }

    public DateTime RegistrationDate { get; set; }

}
