using InstitutoIENService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstitutoIENService.Infrastructure.Data.Configuration
{
    public class CommissionDetailConfiguration : IEntityTypeConfiguration<CommissionDetail>
    {
        public void Configure(EntityTypeBuilder<CommissionDetail> builder)
        {
            builder.ToTable("Comisiones_Detalles");
            builder.HasKey(e => e.Id)
                .HasName("pk_comision_detalle");
            builder.Property(e => e.CommissionId)
                .IsRequired()
                .HasColumnName("id_comision");
            builder.Property(e => e.StudenId)
                .IsRequired()
                .HasColumnName("id_alumno");
            builder.Property(e => e.SubjectId)
                .IsRequired()
                .HasColumnName("id_materia");
            builder.Property(e => e.ClassroomId)
                .IsRequired()
                .HasColumnName("id_aula");
            builder.Property(e => e.ScheduleId)
                .IsRequired()
                .HasColumnName("id_horario");
            builder.Property(e => e.RegistrationDate)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            builder.Property(e => e.ModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");

            builder.HasOne(d => d.Student).WithMany(p => p.CommissionDetails)
                .HasForeignKey(d => d.StudenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_de_alumno");

            builder.HasOne(d => d.Classroom).WithMany(p => p.CommissionsDetails)
                .HasForeignKey(d => d.ClassroomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_de_aula");

            builder.HasOne(d => d.Commission).WithMany(p => p.CommissionsDetails)
                .HasForeignKey(d => d.CommissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_de_comision");

            builder.HasOne(d => d.Schedule).WithMany(p => p.CommissionsDetails)
                .HasForeignKey(d => d.ScheduleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_de_horario");

            builder.HasOne(d => d.Subject).WithMany(p => p.CommissionsDetails)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_de_materia");
        }
    }
}
