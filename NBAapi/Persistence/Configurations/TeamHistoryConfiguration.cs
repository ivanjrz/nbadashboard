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

            builder.Property(account => account.TeamHistoryId).ValueGeneratedOnAdd();
            builder.Property(account => account.Team).IsRequired().HasMaxLength(50);
            builder.Property(account => account.Season).IsRequired().HasMaxLength(50);

            builder.Property(account => account.WinRecord).IsRequired();
            builder.Property(account => account.LossRecord).IsRequired();

            builder.Property(account => account.MOV).IsRequired();
            builder.Property(account => account.SOS).IsRequired();
            builder.Property(account => account.ORTg).IsRequired();
            builder.Property(account => account.DRTg).IsRequired();
            builder.Property(account => account.NRTg).IsRequired();
            builder.Property(account => account.FTr).IsRequired();
            builder.Property(account => account.ThreePAr).IsRequired();
            builder.Property(account => account.OEFGPct).IsRequired();
            builder.Property(account => account.DEFGPct).IsRequired();
            builder.Property(account => account.ORTg).IsRequired();
            builder.Property(account => account.DRB).IsRequired();
    }
    }
}
