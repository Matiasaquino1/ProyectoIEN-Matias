namespace InstitutoIENService.Core.Entities;
public partial class Topic : BaseEntity
{
    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<SubjectTopic> SubjectsTopics { get; set; } = new List<SubjectTopic>();
}
