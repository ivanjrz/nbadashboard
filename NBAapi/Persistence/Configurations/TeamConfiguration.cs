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
            builder.Property(team => team.Name).IsRequired().HasMaxLength(50);
            builder.Property(team => team.City).IsRequired().HasMaxLength(50);
            builder.Property(team => team.Arena).IsRequired().HasMaxLength(100);
            builder.Property(team => team.DateFounded).IsRequired();
            builder.HasMany(team => team.TeamHistories)
                .WithOne()
                .HasForeignKey(teamHistory => teamHistory.Team)
                .OnDelete(DeleteBehavior.NoAction);
                
            builder.HasMany(team => team.Players)
                .WithOne()
                .HasForeignKey(player => player.Team)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}