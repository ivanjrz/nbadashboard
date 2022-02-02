using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    internal sealed class TeamHistoryConfiguration : IEntityTypeConfiguration<TeamHistory>
    {
        public void Configure(EntityTypeBuilder<TeamHistory> builder)
        {
            builder.ToTable(nameof(TeamHistory));
            builder.HasKey(team => team.TeamHistoryId);
            
            builder.HasMany(team => team.Team)
                .WithOne()
                .HasForeignKey(player => player.Team)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}