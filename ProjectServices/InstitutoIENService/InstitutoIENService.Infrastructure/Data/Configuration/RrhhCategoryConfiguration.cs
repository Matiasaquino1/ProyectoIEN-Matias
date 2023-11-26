using InstitutoIENService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstitutoIENService.Infrastructure.Data.Configuration
{
    public class RrhhCategoryConfiguration : IEntityTypeConfiguration<RrhhCategory>
    {
        public void Configure(EntityTypeBuilder<RrhhCategory> builder)
        {
            builder.ToTable("Categorias_Rrhh");

            builder.HasKey(e => e.Id).HasName("pk_categoria_rrhh");

            builder.Property(e => e.CategoryDescription)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_categoria_rrhh");
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
