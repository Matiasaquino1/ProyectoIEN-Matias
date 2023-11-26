using InstitutoIENService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstitutoIENService.Infrastructure.Data.Configuration
{
    public class OperationConfiguration : IEntityTypeConfiguration<Operation>
    {
        public void Configure(EntityTypeBuilder<Operation> builder)
        {
            builder.ToTable("Operaciones");
            builder.HasKey(e => e.Id).HasName("pk_operacion");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("de_operaciones");
            builder.Property(e => e.ModuleId)
                .IsRequired()
                .HasColumnName("id_modulo");
            builder.Property(e => e.RegistrationDate)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            builder.Property(e => e.ModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");

            builder.HasOne(d => d.Module).WithMany(p => p.Operations)
                .HasForeignKey(d => d.ModuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_op_modulo");
        }
    }
}
