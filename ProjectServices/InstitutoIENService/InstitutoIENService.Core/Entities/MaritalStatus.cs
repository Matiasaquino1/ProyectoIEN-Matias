namespace InstitutoIENService.Core.Entities;

public partial class MaritalStatus : BaseEntity
{
    public string Description { get; set; } = null!;

    public virtual ICollection<Rrhh> Rrhhs { get; set; } = new List<Rrhh>();
}
