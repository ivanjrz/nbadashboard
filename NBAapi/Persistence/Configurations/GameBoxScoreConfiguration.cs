using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    internal sealed class GameBoxScoreConfiguration : IEntityTypeConfiguration<GameBoxScore>
    {
        public void Configure(EntityTypeBuilder<GameBoxScore> builder)
        {
            builder.ToTable(nameof(GameBoxScore));
            builder.HasKey(gbs => gbs.GameBoxScoreId);
            builder.Property(gbs => gbs.DateEST);
            builder.Property(gbs => gbs.Season);
            builder.Property(gbs => gbs.SeasonShortName);
            builder.Property(gbs => gbs.HomeTeamWin);
            builder.Property(gbs => gbs.AwayTeamWin);
            builder.Property(gbs => gbs.PointsHome);
            builder.Property(gbs => gbs.FGPctHome);
            builder.Property(gbs => gbs.FTPctHome);
            builder.Property(gbs => gbs.FG3PctHome);
            builder.Property(gbs => gbs.ASTHome);
            builder.Property(gbs => gbs.REBHome);
            builder.Property(gbs => gbs.PointsAway);
            builder.Property(gbs => gbs.FGPctAway);
            builder.Property(gbs => gbs.FTPctAway);
            builder.Property(gbs => gbs.FG3PctAway);
            builder.Property(gbs => gbs.ASTAway);
            builder.Property(gbs => gbs.REBAway);
            builder.Property(gbs => gbs.NBA_API_GameId);
            builder.Property(gbs => gbs.NBA_API_HomeTeamId);
            builder.Property(gbs => gbs.NBA_API_AwayTeamId);

        }
    }
}