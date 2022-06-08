using System;
namespace Services
{
    public interface IServiceManager
    {
        ITeamService TeamService { get; }

        IPlayerService PlayerService { get; }

        ITeamHistoryService TeamHistoryService { get; }

        IGameBoxScoreService GameBoxScoreService { get; }

        ISeriesPredictionSummaryService SeriesPredictionSummaryService { get; }

        ISinglePredictionService SinglePredictionService { get; }
    }
}
