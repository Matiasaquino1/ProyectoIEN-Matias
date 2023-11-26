namespace InstitutoIENService.Core.Entities;

public partial class OperationRole
{
    public int OperationId { get; set; }

    public int RoleId { get; set; }

    public DateTime RegistrationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public virtual Operation Operation { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;
}
