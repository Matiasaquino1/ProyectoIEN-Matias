using InstitutoIENService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstitutoIENService.Infrastructure.Data.Configuration
{
    public class LocalityConfiguration : IEntityTypeConfiguration<Locality>
    {
        public void Configure(EntityTypeBuilder<Locality> builder)
        {
            builder.ToTable("Localidades");
            builder.HasKey(e => e.Id).HasName("pk_localidad");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_localidad");
            builder.Property(e => e.ProvinceId)
                .IsRequired() 
                .HasColumnName("id_provincia");
            builder.Property(e => e.RegistrationDate)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            builder.Property(e => e.ModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");

            builder.HasOne(d => d.Province).WithMany(p => p.Localities)
                .HasForeignKey(d => d.ProvinceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_lo_provincias");
        }
    }
}
