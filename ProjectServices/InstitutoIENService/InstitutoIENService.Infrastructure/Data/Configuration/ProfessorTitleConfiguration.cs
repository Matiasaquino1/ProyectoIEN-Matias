using InstitutoIENService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstitutoIENService.Infrastructure.Data.Configuration
{
    public class ProfessorTitleConfiguration : IEntityTypeConfiguration<ProfessorTitle>
    {
        public void Configure(EntityTypeBuilder<ProfessorTitle> builder)
        {
            builder.ToTable("Profesores_Titulos");
            builder.HasKey(e => new { e.ProfesorId, e.TitleId }).HasName("pk_profesortitulo");


            builder.Property(e => e.ProfesorId)
                .IsRequired()
                .HasColumnName("id_profesor");
            builder.Property(e => e.TitleId)
                .IsRequired()
                .HasColumnName("id_titulo");
            builder.Property(e => e.ImageTitlePath)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("re_imagen_titulo");
            builder.Property(e => e.RegistrationDate)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            builder.Property(e => e.ModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");

            builder.HasOne(d => d.Professor).WithMany(p => p.ProfessorsTitles)
                .HasForeignKey(d => d.ProfesorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pt_profesor");

            builder.HasOne(d => d.Title).WithMany(p => p.ProfessorsTitles)
                .HasForeignKey(d => d.TitleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pt_titulo");
        }
    }
}
