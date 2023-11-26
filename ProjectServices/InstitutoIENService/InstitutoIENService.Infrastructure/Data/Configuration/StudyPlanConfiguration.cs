using InstitutoIENService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstitutoIENService.Infrastructure.Data.Configuration
{
    public class StudyPlanConfiguration : IEntityTypeConfiguration<StudyPlan>
    {
        public void Configure(EntityTypeBuilder<StudyPlan> builder)
        {
            builder.ToTable("Planes_Estudios");
            builder.HasKey(e => e.Id).HasName("pk_plan_estudio");
            builder.Property(e => e.PlanName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_plan");
            builder.Property(e => e.Observation)
                .HasColumnType("text")
                .HasColumnName("de_observacion");
            builder.Property(e => e.PlanYear)
                .IsRequired()
                .HasColumnName("nu_anio_plan");
            builder.Property(e => e.ModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            builder.Property(e => e.RegistrationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
        }
    }
}
