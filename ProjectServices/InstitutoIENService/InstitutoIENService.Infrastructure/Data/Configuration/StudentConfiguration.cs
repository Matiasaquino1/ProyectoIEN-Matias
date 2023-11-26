using InstitutoIENService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstitutoIENService.Infrastructure.Data.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Alumnos");
            builder.HasKey(e => e.Id).HasName("pk_alumno");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.RegistrationNumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nu_legajo");
            builder.Property(e => e.AdmissionDate)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("fe_ingreso");
            builder.Property(e => e.GraduationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_egreso");
            builder.Property(e => e.OverallAverageScore)
                .HasColumnType("numeric(5, 2)")
                .HasColumnName("nu_promedio_gral");
            builder.Property(e => e.StudyPlanId)
                .HasColumnName("id_plan_estudio");
            builder.Property(e => e.StatusEnrollmentType)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ti_estado_inscripcion");
            builder.Property(e => e.RegistrationDate)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            builder.Property(e => e.ModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");

            builder.HasOne(d => d.Rrhh).WithOne(p => p.Student)
                .HasForeignKey<Student>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_al_rrhh");

            builder.HasOne(d => d.StudyPlan).WithMany(p => p.Students)
                .HasForeignKey(d => d.StudyPlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_al_plan_estudio");
        }
    }
}
