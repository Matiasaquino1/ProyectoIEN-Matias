using InstitutoIENService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstitutoIENService.Infrastructure.Data.Configuration
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.ToTable("Horarios");
            builder.HasKey(e => e.Id).HasName("pk_horario");
            builder.Property(e => e.StartTime)
                .IsRequired()
                .HasColumnName("hr_inicio");
            builder.Property(e => e.EndTime)
                .IsRequired()
                .HasColumnName("hr_fin");
            builder.Property(e => e.DayNumber)
                .IsRequired()
                .HasColumnName("nu_dia");
            builder.Property(e => e.RegistrationDate)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            builder.Property(e => e.ModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
        }
    }
}
