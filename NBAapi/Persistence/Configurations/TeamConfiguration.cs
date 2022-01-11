using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    internal sealed class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.ToTable(nameof(Team));

            builder.HasKey(team => team.TeamId);

            builder.Property(team => team.Name).HasMaxLength(60);

            builder.Property(team => team.City).IsRequired();

            builder.Property(team => team.DateFounded).HasMaxLength(100);

            builder.HasMany(team => team.Players)
                .WithOne()
                .HasForeignKey(player => player.Team)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}