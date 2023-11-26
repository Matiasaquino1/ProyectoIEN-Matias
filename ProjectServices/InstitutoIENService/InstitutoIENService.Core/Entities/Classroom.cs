namespace InstitutoIENService.Core.Entities;

public partial class Classroom : BaseEntity
{
    public int MaxCapacity { get; set; }

    public virtual ICollection<CommissionDetail> CommissionsDetails { get; set; } = new List<CommissionDetail>();
}
