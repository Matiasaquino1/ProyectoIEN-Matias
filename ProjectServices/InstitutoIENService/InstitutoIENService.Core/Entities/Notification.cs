namespace InstitutoIENService.Core.Entities;

public partial class Notification : BaseEntity
{
    public string Message { get; set; } = null!;

    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
