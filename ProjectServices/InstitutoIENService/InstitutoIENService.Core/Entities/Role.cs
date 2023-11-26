namespace InstitutoIENService.Core.Entities;

public partial class Role: BaseEntity
{

    public string RoleDescription { get; set; } = null!;

    public virtual ICollection<OperationRole> OperationsRoles { get; set; } = new List<OperationRole>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
