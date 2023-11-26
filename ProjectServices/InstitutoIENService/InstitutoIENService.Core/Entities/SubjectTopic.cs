namespace InstitutoIENService.Core.Entities;

public partial class SubjectTopic
{
    public int SubjectId { get; set; }

    public int TopicId { get; set; }

    public DateTime RegistrationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public virtual Subject Subject { get; set; } = null!;

    public virtual Topic Topic { get; set; } = null!;
}
