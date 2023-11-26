using InstitutoIENService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstitutoIENService.Infrastructure.Data.Configuration
{
    public class ProfessorConfiguration : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.ToTable("Profesores");
            builder.HasKey(e => e.Id).HasName("pk_profesor");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.RegistrationNumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nu_matricula");
            builder.Property(e => e.DateOfEntry)
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

            builder.HasOne(d => d.Rrhh).WithOne(p => p.Professor)
                .HasForeignKey<Professor>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pr_rrhh");
        }
    }
}
