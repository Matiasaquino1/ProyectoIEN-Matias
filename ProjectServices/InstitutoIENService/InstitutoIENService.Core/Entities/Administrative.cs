namespace InstitutoIENService.Core.Entities;

public partial class Administrative : BaseEntity
{
    public DateTime? DateOfEntry { get; set; }

    public DateTime? DateOfTermination { get; set; }

    public virtual Rrhh Rrhh { get; set; } = null!;
}
