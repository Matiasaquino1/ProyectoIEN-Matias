namespace InstitutoIENService.Core.Entities;

public partial class Title : BaseEntity
{
    public string? TitleDescription { get; set; }

    public virtual ICollection<ProfessorTitle> ProfessorsTitles { get; set; } = new List<ProfessorTitle>();
}
