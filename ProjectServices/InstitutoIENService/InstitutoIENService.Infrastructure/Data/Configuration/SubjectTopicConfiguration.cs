using InstitutoIENService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstitutoIENService.Infrastructure.Data.Configuration
{
    public class SubjectTopicConfiguration : IEntityTypeConfiguration<SubjectTopic>
    {
        public void Configure(EntityTypeBuilder<SubjectTopic> builder)
        {
            builder.ToTable("Materias_Temas");
            builder.HasKey(e => new { e.SubjectId, e.TopicId }).HasName("pk_materia_tema");

            builder.Property(e => e.SubjectId)
                .IsRequired()
                .HasColumnName("id_materia");
            builder.Property(e => e.TopicId)
                .IsRequired()
                .HasColumnName("id_tema");
            builder.Property(e => e.RegistrationDate)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            builder.Property(e => e.ModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");

            builder.HasOne(d => d.Subject).WithMany(p => p.SubjectsTopics)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_mt_materia");

            builder.HasOne(d => d.Topic).WithMany(p => p.SubjectsTopics)
                .HasForeignKey(d => d.TopicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_mt_tema");
        }
    }
}
