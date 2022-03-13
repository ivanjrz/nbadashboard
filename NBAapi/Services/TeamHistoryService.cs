﻿using System;
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
    internal sealed class TeamHistoryService : IPlayerService
    {
        private readonly IRepositoryManager _repositoryManager;
        public TeamHistoryService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;
        public async Task<IEnumerable<PlayerDto>> GetAllByTeamIdAsync(string team, CancellationToken cancellationToken = default)
        {
            var players = await _repositoryManager.PlayerRepository.GetAllByTeamIdAsync(team, cancellationToken);
            var playersDto = players.Adapt<IEnumerable<PlayerDto>>();
            return playersDto;
        }
        public async Task<PlayerDto> GetByIdAsync(int teamId, int playerId, CancellationToken cancellationToken)
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
            var playerDto = player.Adapt<PlayerDto>();
            return playerDto;
        }
        public async Task<PlayerDto> CreateAsync(int teamId, CreatePlayerDto PlayerForCreationDto, CancellationToken cancellationToken = default)
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
            return player.Adapt<PlayerDto>();
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

        public async Task<IEnumerable<PlayerDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var players = await _repositoryManager.PlayerRepository.GetAllAsync(cancellationToken);
            var playerDto = players.Adapt<IEnumerable<PlayerDto>>();
            return playerDto;
        }
    }
}