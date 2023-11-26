using InstitutoIENService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstitutoIENService.Infrastructure.Data.Configuration
{
    public class AdministrativeConfiguration : IEntityTypeConfiguration<Administrative>
    {
        public void Configure(EntityTypeBuilder<Administrative> builder)
        {
            builder.ToTable("Administrativos");
            builder.HasKey(e => e.Id)                
                .HasName("pk_administrativo");
            builder.Property(e => e.Id)
                .ValueGeneratedNever();
            builder.Property(e => e.DateOfEntry)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("fe_ingreso");
            builder.Property(e => e.DateOfTermination)
                .HasColumnType("datetime")
                .HasColumnName("fe_baja");
            builder.Property(e => e.RegistrationDate)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            builder.Property(e => e.ModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");

            builder.HasOne(d => d.Rrhh).WithOne(p => p.Administrative)
                .HasForeignKey<Administrative>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ad_rrhh");
        }
    }
}
