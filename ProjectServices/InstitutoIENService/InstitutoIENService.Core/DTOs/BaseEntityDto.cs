namespace InstitutoIENService.Core.DTOs
{
    public class BaseEntityDto
    {
        public int Id { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime? ModificationDate { get; set; }
    }
}
