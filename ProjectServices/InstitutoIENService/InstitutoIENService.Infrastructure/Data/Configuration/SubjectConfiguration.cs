using InstitutoIENService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstitutoIENService.Infrastructure.Data.Configuration
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.ToTable("Materias");
            builder.HasKey(e => e.Id).HasName("pk_materia");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_nombre");
            builder.Property(e => e.CompulsoryAttendanceRate)
                .IsRequired()
                .HasColumnType("numeric(3, 2)")
                .HasColumnName("ta_asistencia_obligatoria");
            builder.Property(e => e.CareerId)
                .IsRequired()
                .HasColumnName("id_carrera");
            builder.Property(e => e.RegistrationDate)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            builder.Property(e => e.ModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");

            builder.HasOne(d => d.Career).WithMany(p => p.Subject)
                .HasForeignKey(d => d.CareerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ma_carrera");
        }
    }
}
