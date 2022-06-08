using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Repositories;
using Contracts;
using Mapster;

namespace Services
{
    internal sealed class GameBoxScoreService : IGameBoxScoreService
    {
        private readonly IRepositoryManager _repositoryManager;
        public GameBoxScoreService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;

        public async Task<GameBoxScoreDto> GetByIdAsync(double gameId, CancellationToken cancellationToken)
        {
            var gbs = await _repositoryManager.GameBoxScoreRepository.GetByIdAsync(gameId, cancellationToken);
            if (gbs is null)
            {
                throw new GameBoxScoreNotFoundException(gameId);
            }
            var gbsDto = gbs.Adapt<GameBoxScoreDto>();
            return gbsDto;
        }
        public async Task<GameBoxScoreDto> CreateAsync(CreateGameBoxScoreDto GBSToCreateDto, CancellationToken cancellationToken = default)
        {
            var gbs = GBSToCreateDto.Adapt<GameBoxScore>();
            _repositoryManager.GameBoxScoreRepository.Insert(gbs);
            await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);
            return gbs.Adapt<GameBoxScoreDto>();
        }
        public async Task DeleteAsync(double gameId, CancellationToken cancellationToken = default)
        {
            var gbs = await _repositoryManager.GameBoxScoreRepository.GetByIdAsync(gameId, cancellationToken);
            if (gbs is null)
            {
                throw new GameBoxScoreNotFoundException(gameId);
            }
            _repositoryManager.GameBoxScoreRepository.Remove(gbs);
            await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<IEnumerable<GameBoxScoreDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var gbs = await _repositoryManager.GameBoxScoreRepository.GetAllAsync(cancellationToken);
            var gbsDto = gbs.Adapt<IEnumerable<GameBoxScoreDto>>();
            return gbsDto;
        }
    }
}
