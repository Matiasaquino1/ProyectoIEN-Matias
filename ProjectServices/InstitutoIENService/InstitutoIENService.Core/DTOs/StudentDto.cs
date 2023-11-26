namespace InstitutoIENService.Core.DTOs;

public class StudentDto : BaseEntityDto
{
    public string RegistrationNumber { get; set; } = null!;

    public decimal? AverageScore { get; set; }

    public decimal? OverallAverageScore { get; set; }

    public int StudyPlanId { get; set; }

    public string StatusEnrollmentType { get; set; } = null!;

    public DateTime? AdmissionDate { get; set; }

    public DateTime? GraduationDate { get; set; }
}
