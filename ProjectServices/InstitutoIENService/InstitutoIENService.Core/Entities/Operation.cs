namespace InstitutoIENService.Core.Entities;

public partial class Operation : BaseEntity
{
    public string Description { get; set; } = null!;

    public int ModuleId { get; set; }

    public virtual Module Module { get; set; } = null!;

    public virtual ICollection<OperationRole> OperationsRoles { get; set; } = new List<OperationRole>();
}
