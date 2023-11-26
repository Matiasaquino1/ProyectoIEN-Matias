namespace InstitutoIENService.Core.Entities;

public partial class Commission : BaseEntity
{
    public string Description { get; set; } = null!;

    public string CommissionCode { get; set; } = null!;

    public int Year { get; set; }

    public string CareerDescription { get; set; } = null!;

    public string YearOfCourse { get; set; } = null!;

    public virtual ICollection<CommissionDetail> CommissionsDetails { get; set; } = new List<CommissionDetail>();
}
