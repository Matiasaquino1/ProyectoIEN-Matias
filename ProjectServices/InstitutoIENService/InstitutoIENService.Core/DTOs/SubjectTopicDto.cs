namespace InstitutoIENService.Core.DTOs;

public class SubjectTopicDto
{
    public int SubjectId { get; set; }

    public int TopicId { get; set; }

    public DateTime RegistrationDate { get; set; }

    public DateTime? ModificationDate { get; set; }
}
