using InstitutoIENService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstitutoIENService.Infrastructure.Data.Configuration
{
    public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.ToTable("Incripciones");
            builder.HasKey(e => new { e.StudenId, e.CareerId }).HasName("pk_alumno_carrera");

            builder.Property(e => e.StudenId)
                .IsRequired()
                .HasColumnName("id_alumno");
            builder.Property(e => e.CareerId)
                .IsRequired()
                .HasColumnName("id_carrera");

            builder.Property(e => e.DniNumber)
                .IsRequired()
                .HasColumnName("nu_dni");
            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_nombre");
            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_apellido");
            builder.Property(e => e.CellPhone)
                .IsRequired()
                .HasColumnName("nu_celular");
            builder.Property(e => e.Phone)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nu_telefono");
            builder.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_direccion");
            builder.Property(e => e.Gender)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_genero");
            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_email");
            builder.Property(e => e.DateOfBirth)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("fe_nacimiento");
            builder.Property(e => e.EnrollmentDate)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("fe_inscripcion");
            builder.Property(e => e.StudyPlanId)
                .IsRequired()
                .HasColumnName("id_plan_estudio");
            builder.Property(e => e.RegistrationDate)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            builder.Property(e => e.ModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");

            builder.HasOne(d => d.Student).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.StudenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ac_alumno");

            builder.HasOne(d => d.Career).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.CareerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ac_carrera");

            builder.HasOne(d => d.StudyPlan).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.StudyPlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ac_plan_estudio");
        }
    }
}
