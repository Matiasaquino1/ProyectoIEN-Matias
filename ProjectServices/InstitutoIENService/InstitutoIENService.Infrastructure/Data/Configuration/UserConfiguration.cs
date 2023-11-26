using InstitutoIENService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstitutoIENService.Infrastructure.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Usuarios");
            builder.HasKey(e => e.Id).HasName("pk_usuario");
            builder.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("de_nombre_cuenta");
            builder.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("de_contrasenia");
            builder.Property(e => e.RrhhId)
                .IsRequired()
                .HasColumnName("id_rrhh");
            builder.Property(e => e.RoleId)
                .IsRequired()
                .HasColumnName("id_rol");
            builder.Property(e => e.IsActive)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('S')")
                .HasColumnName("sn_activo");
            builder.Property(e => e.RegistrationDate)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            builder.Property(e => e.ModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");

            builder.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_us_rol");

            builder.HasOne(d => d.Rrhh).WithMany(p => p.Users)
                .HasForeignKey(d => d.RrhhId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_us_rrhh");
        }
    }
}
