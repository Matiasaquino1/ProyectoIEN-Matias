namespace InstitutoIENService.Core.Entities;

public partial class User : BaseEntity
{
    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int RrhhId { get; set; }

    public int RoleId { get; set; }

    public string IsActive { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;

    public virtual Rrhh Rrhh { get; set; } = null!;

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();
}
