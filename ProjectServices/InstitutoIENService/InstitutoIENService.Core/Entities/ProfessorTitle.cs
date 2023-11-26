namespace InstitutoIENService.Core.Entities;

public partial class ProfessorTitle
{
    public int ProfesorId { get; set; }

    public int TitleId { get; set; }

    public string? ImageTitlePath { get; set; }

    public DateTime RegistrationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public virtual Professor Professor { get; set; } = null!;

    public virtual Title Title { get; set; } = null!;
}
