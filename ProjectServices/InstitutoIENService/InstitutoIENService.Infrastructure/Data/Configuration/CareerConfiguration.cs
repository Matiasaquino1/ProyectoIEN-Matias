using InstitutoIENService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstitutoIENService.Infrastructure.Data.Configuration
{
    public class CareerConfiguration : IEntityTypeConfiguration<Career>
    {
        public void Configure(EntityTypeBuilder<Career> builder)
        {
            builder.ToTable("Carreras");
            builder.HasKey(e => e.Id).HasName("pk_carrera");

            builder.Property(e => e.CareerDescription)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_carrera");
            builder.Property(e => e.CampusDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_sede");
            builder.Property(e => e.DurationInHours)
                .IsRequired()
                .HasColumnName("nu_duracion_horas");
            builder.Property(e => e.ManagerName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_responsable");
            builder.Property(e => e.StudyPlanId)
                .IsRequired()
                .HasColumnName("id_plan_estudio");
            builder.Property(e => e.CareerType)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ti_carrera");
            builder.Property(e => e.RegistrationDate)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            builder.Property(e => e.ModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");

            builder.HasOne(d => d.StudyPlan).WithMany(p => p.Careers)
                .HasForeignKey(d => d.StudyPlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ca_plan_estudio");
        }
    }
}
