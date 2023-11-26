namespace InstitutoIENService.Core.Entities;

public partial class Country : BaseEntity
{
    public string Name { get; set; } = null!;

    public virtual ICollection<Province> Provinces { get; set; } = new List<Province>();
}
