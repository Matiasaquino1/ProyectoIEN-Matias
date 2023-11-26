namespace InstitutoIENService.Core.Entities;

public partial class Rrhh : BaseEntity
{
    public int DniNumber { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int CellPhone1 { get; set; }

    public int CellPhone2 { get; set; }

    public int CellPhone3 { get; set; }

    public int Phone1 { get; set; }

    public int Phone2 { get; set; }

    public int Phone3 { get; set; }

    public string Address { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public int MaritalStatusId { get; set; }

    public int RrhhCategoryId { get; set; }

    public string? Email { get; set; }

    public DateTime DateOfBirth { get; set; }

    public int LocalityId { get; set; }

    public virtual Administrative? Administrative { get; set; }

    public virtual Student? Student { get; set; }

    public virtual RrhhCategory RrhhCategory { get; set; } = null!;

    public virtual MaritalStatus MaritalStatus { get; set; } = null!;

    public virtual Locality Locality { get; set; } = null!;

    public virtual Professor? Professor { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
