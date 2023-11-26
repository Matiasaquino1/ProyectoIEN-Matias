using InstitutoIENService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstitutoIENService.Infrastructure.Data.Configuration
{
    public class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.ToTable("Examenes");
            builder.HasKey(e => e.Id)
                .HasName("pk_examen");
            builder.Property(e => e.TestScore)
                .IsRequired()
                .HasColumnType("numeric(5, 2)")
                .HasColumnName("nu_nota");
            builder.Property(e => e.Condition)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_condicion");
            builder.Property(e => e.StudenId)
                .IsRequired()
                .HasColumnName("id_alumno");
            builder.Property(e => e.SubjectId)
                .IsRequired()
                .HasColumnName("id_materia");
            builder.Property(e => e.ProfessorId)
                .IsRequired()
                .HasColumnName("id_profesor");
            builder.Property(e => e.ExamType)
                .IsRequired()
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("ti_examen");
            builder.Property(e => e.ExamDate)
                .HasColumnType("date")
                .HasColumnName("fe_examen");
            builder.Property(e => e.ExamTime)
                .IsRequired()
                .HasColumnName("hr_examen");
            builder.Property(e => e.IsAbsent)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("sn_ausente");
            builder.Property(e => e.RegistrationDate)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            builder.Property(e => e.ModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");

            builder.HasOne(d => d.Student).WithMany(p => p.Exams)
                .HasForeignKey(d => d.StudenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ex_alumno");

            builder.HasOne(d => d.Subject).WithMany(p => p.Exams)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ex_materia");

            builder.HasOne(d => d.Professor).WithMany(p => p.Exams)
                .HasForeignKey(d => d.ProfessorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ex_profesor");
        }
    }
}
