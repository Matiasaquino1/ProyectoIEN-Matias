using InstitutoIENService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstitutoIENService.Infrastructure.Data.Configuration
{
    public class CommissionConfiguration : IEntityTypeConfiguration<Commission>
    {
        public void Configure(EntityTypeBuilder<Commission> builder)
        {
            builder.ToTable("Comisiones");
            builder.HasKey(e => e.Id).HasName("pk_comision");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_descripcion");
            builder.Property(e => e.CommissionCode)
                .IsRequired()
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("nu_codigo_comision");
            builder.Property(e => e.Year)
                .IsRequired(true)
                .HasColumnName("nu_anio_comision");
            builder.Property(e => e.CareerDescription)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_carrera");
            builder.Property(e => e.YearOfCourse)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("de_anio_de_materia");
            builder.Property(e => e.ModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            builder.Property(e => e.RegistrationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
        }
    }
}
