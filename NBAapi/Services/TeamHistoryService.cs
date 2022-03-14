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
    internal sealed class TeamHistoryService : ITeamHistoryService
    {
        private readonly IRepositoryManager _repositoryManager;
        public TeamHistoryService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;
        public async Task<IEnumerable<TeamHistoryDto>> GetAllByTeamIdAsync(string team, CancellationToken cancellationToken = default)
        {
            var players = await _repositoryManager.PlayerRepository.GetAllByTeamIdAsync(team, cancellationToken);
            var playersDto = players.Adapt<IEnumerable<TeamHistoryDto>>();
            return playersDto;
        }
        public async Task<TeamHistoryDto> GetByIdAsync(int teamId, int playerId, CancellationToken cancellationToken)
        {
            var team = await _repositoryManager.TeamRepository.GetByIdAsync(teamId, cancellationToken);
            if (team is null)
            {
                throw new TeamNotFoundException(teamId);
            }
            var player = await _repositoryManager.PlayerRepository.GetByIdAsync(playerId, cancellationToken);
            if (player is null)
            {
                throw new PlayerNotFoundException(playerId);
            }
            //if (player.TeamId != team.Id)
            //{
            //    //throw new PlayerDoesNotBelongToOwnerException(team.Id, player.Id);
            //}
            var playerDto = player.Adapt<TeamHistoryDto>();
            return playerDto;
        }
        public async Task<TeamHistoryDto> CreateAsync(int teamId, CreateTeamHistoryDto PlayerForCreationDto, CancellationToken cancellationToken = default)
        {
            var team = await _repositoryManager.TeamRepository.GetByIdAsync(teamId, cancellationToken);
            if (team is null)
            {
                throw new TeamNotFoundException(teamId);
            }
            var player = PlayerForCreationDto.Adapt<Player>();
            player.PlayerId = team.TeamId;
            _repositoryManager.PlayerRepository.Insert(player);
            await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);
            return player.Adapt<TeamHistoryDto>();
        }
        public async Task DeleteAsync(int teamId, int playerId, CancellationToken cancellationToken = default)
        {
            var team = await _repositoryManager.TeamRepository.GetByIdAsync(teamId, cancellationToken);
            if (team is null)
            {
                throw new TeamNotFoundException(teamId);
            }
            var player = await _repositoryManager.PlayerRepository.GetByIdAsync(playerId, cancellationToken);
            if (player is null)
            {
                throw new PlayerNotFoundException(playerId);
            }
            //if (player.TeamId != team.TeamId)
            //{
            //    throw new PlayerDoesNotBelongToOwnerException(team.TeamId, player.PlayerId);
            //}
            _repositoryManager.PlayerRepository.Remove(player);
            await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<IEnumerable<TeamHistoryDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var players = await _repositoryManager.PlayerRepository.GetAllAsync(cancellationToken);
            var playerDto = players.Adapt<IEnumerable<TeamHistoryDto>>();
            return playerDto;
        }
    }
}
