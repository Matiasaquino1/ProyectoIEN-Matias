using InstitutoIENService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstitutoIENService.Infrastructure.Data.Configuration
{
    public class OperationRoleConfiguration : IEntityTypeConfiguration<OperationRole>
    {
        public void Configure(EntityTypeBuilder<OperationRole> builder)
        {
            builder.ToTable("Operaciones_Roles");
            builder.HasKey(e => new { e.OperationId, e.RoleId }).HasName("pk_operacionrol");

            builder.Property(e => e.OperationId).HasColumnName("id_operacion");
            builder.Property(e => e.RoleId).HasColumnName("id_rol");
            builder.Property(e => e.ModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");
            builder.Property(e => e.RegistrationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");

            builder.HasOne(d => d.Operation).WithMany(p => p.OperationsRoles)
                .HasForeignKey(d => d.OperationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_or_operacion");

            builder.HasOne(d => d.Role).WithMany(p => p.OperationsRoles)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_or_rol");
        }
    }
}
