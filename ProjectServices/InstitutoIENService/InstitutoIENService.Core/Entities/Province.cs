namespace InstitutoIENService.Core.Entities;

public partial class Province:BaseEntity
{

    public string Name { get; set; } = null!;

    public int CountryId { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<Locality> Localities { get; set; } = new List<Locality>();
}
