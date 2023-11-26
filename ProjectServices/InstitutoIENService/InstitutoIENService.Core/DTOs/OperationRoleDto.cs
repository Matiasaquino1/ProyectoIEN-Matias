namespace InstitutoIENService.Core.DTOs;

public class OperationRoleDto
{
    public int OperationId { get; set; }

    public int RoleId { get; set; }

    public DateTime RegistrationDate { get; set; }

    public DateTime? ModificationDate { get; set; }
}
