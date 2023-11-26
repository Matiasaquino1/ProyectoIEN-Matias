using InstitutoIENService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstitutoIENService.Infrastructure.Data.Configuration
{
    public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.ToTable("Notificaciones");
            builder.HasKey(e => e.Id).HasName("pk_notificacion");

            builder.Property(e => e.Message)
                .IsRequired()
                .HasColumnType("text")
                .HasColumnName("de_mensaje");
            builder.Property(e => e.UserId)
                .IsRequired()
                .HasColumnName("id_usuario");
            builder.Property(e => e.RegistrationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_registro");
            builder.Property(e => e.ModificationDate)
                .HasColumnType("datetime")
                .HasColumnName("fe_modificacion");

            builder.HasOne(d => d.User).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_no_usuario");
        }
    }
}
