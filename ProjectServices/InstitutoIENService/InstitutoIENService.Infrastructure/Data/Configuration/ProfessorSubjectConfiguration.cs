using InstitutoIENService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstitutoIENService.Infrastructure.Data.Configuration
{
    public class ProfessorSubjectConfiguration : IEntityTypeConfiguration<ProfessorSubject>
    {
        public void Configure(EntityTypeBuilder<ProfessorSubject> builder)
        {
            builder.ToTable("Profesores_Materias");
            builder.HasKey(e => new { e.ProfessorId, e.SubjectId }).HasName("pk_profesormateria");


            builder.Property(e => e.ProfessorId)
                .IsRequired()
                .HasColumnName("id_profesor");
            builder.Property(e => e.SubjectId)
                .IsRequired()
                .HasColumnName("id_materia");
            builder.Property(e => e.Position)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ti_cargo");
            builder.Property(e => e.RegistrationDate)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            builder.Property(e => e.ModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");

            builder.HasOne(d => d.Subject).WithMany(p => p.ProfessorsSubjects)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pm_materia");

            builder.HasOne(d => d.Professor).WithMany(p => p.ProfessorsSubjects)
                .HasForeignKey(d => d.ProfessorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pm_profesor");
        }
    }
}
