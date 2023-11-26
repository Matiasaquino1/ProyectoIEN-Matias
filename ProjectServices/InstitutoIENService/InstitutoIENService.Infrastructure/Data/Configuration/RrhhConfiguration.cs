using InstitutoIENService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstitutoIENService.Infrastructure.Data.Configuration
{
    public class RrhhConfiguration : IEntityTypeConfiguration<Rrhh>
    {
        public void Configure(EntityTypeBuilder<Rrhh> builder)
        {
            builder.ToTable("RRHH");
            builder.HasKey(e => e.Id).HasName("pk_rrhh");


            builder.Property(e => e.DniNumber)
                .IsRequired()
                .HasColumnName("nu_dni");
            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_nombre");
            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_apellido");
            builder.Property(e => e.CellPhone1)
                .IsRequired()
                .HasColumnName("nu_celular1");
            builder.Property(e => e.CellPhone2)
                .IsRequired()
                .HasColumnName("nu_celular2");
            builder.Property(e => e.CellPhone3)
                .IsRequired()
                .HasColumnName("nu_celular3");
            builder.Property(e => e.Phone1)
                .IsRequired()
                .HasColumnName("nu_telefono1");
            builder.Property(e => e.Phone2)
                .IsRequired()
                .HasColumnName("nu_telefono2");
            builder.Property(e => e.Phone3)
                .IsRequired()
                .HasColumnName("nu_telefono3");
            builder.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_direccion");
            builder.Property(e => e.Gender)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("de_genero");
            builder.Property(e => e.MaritalStatusId)
                .IsRequired()
                .HasColumnName("id_estado_civil");
            builder.Property(e => e.RrhhCategoryId)
                .IsRequired()
                .HasColumnName("id_categoria_rrhh");
            builder.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_mail");
            builder.Property(e => e.DateOfBirth)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("fe_nacimiento");
            builder.Property(e => e.LocalityId)
                .IsRequired()
                .HasColumnName("id_localidad");
            builder.Property(e => e.RegistrationDate)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            builder.Property(e => e.ModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");

            builder.HasOne(d => d.RrhhCategory).WithMany(p => p.Rrhhs)
                .HasForeignKey(d => d.RrhhCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rh_categoria");

            builder.HasOne(d => d.MaritalStatus).WithMany(p => p.Rrhhs)
                .HasForeignKey(d => d.MaritalStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rh_estado_civil");

            builder.HasOne(d => d.Locality).WithMany(p => p.Rrhhs)
                .HasForeignKey(d => d.LocalityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_localidad");
        }
    }
}
