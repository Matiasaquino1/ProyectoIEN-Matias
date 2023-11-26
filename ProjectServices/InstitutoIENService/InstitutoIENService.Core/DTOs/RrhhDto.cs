namespace InstitutoIENService.Core.DTOs;

public class RrhhDto : BaseEntityDto
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

    public int MaritalStatus { get; set; }

    public int RrhhCategoryId { get; set; }

    public string? Email { get; set; }

    public DateTime DateOfBirth { get; set; }

    public int LocalityId { get; set; }
}
