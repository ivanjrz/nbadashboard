using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    internal sealed class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.ToTable(nameof(Player));

            builder.HasKey(account => account.PlayerId);

            builder.Property(account => account.PlayerId).ValueGeneratedOnAdd();

            builder.Property(account => account.Name).HasMaxLength(50);

            builder.Property(account => account.Team).HasMaxLength(50);

            builder.Property(account => account.Joined).IsRequired();

            builder.Property(account => account.PhotoPath).HasMaxLength(150);
        }
    }
}