namespace InstitutoIENService.Core.Entities;

public partial class Locality : BaseEntity
{

    public string Name { get; set; } = null!;

    public int ProvinceId { get; set; }

    public virtual Province Province { get; set; } = null!;

    public virtual ICollection<Rrhh> Rrhhs { get; set; } = new List<Rrhh>();
}
