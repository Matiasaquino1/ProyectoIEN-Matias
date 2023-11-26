namespace InstitutoIENService.Core.Entities;

public partial class RrhhCategory : BaseEntity
{

    public string CategoryDescription { get; set; } = null!;

    public virtual ICollection<Rrhh> Rrhhs { get; set; } = new List<Rrhh>();
}
