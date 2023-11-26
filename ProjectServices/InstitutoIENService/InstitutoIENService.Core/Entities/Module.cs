namespace InstitutoIENService.Core.Entities;

public partial class Module : BaseEntity
{
    public string Description { get; set; } = null!;

    public virtual ICollection<Operation> Operations { get; set; } = new List<Operation>();
}
