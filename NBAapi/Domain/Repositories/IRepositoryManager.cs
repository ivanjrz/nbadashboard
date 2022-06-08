using System;
namespace Domain.Repositories
{
    public interface IRepositoryManager
    {
        ITeamRepository TeamRepository { get; }

        IPlayerRepository PlayerRepository { get; }

        ITeamHistoryRepository TeamHistoryRepository { get; }

        IGameBoxScoreRepository GameBoxScoreRepository { get; }

        ISeriesPredictionSummaryRepository SeriesPredictionSummaryRepository { get; }

        ISinglePredictionRepository SinglePredictionRepository { get; }

        IUnitOfWork UnitOfWork { get; }
    }
}