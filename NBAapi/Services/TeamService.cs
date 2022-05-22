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
    internal sealed class TeamService : ITeamService
    //: ITeamService
    {
        private readonly IRepositoryManager _repositoryManager;
        public TeamService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;
        public async Task<IEnumerable<TeamDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var teams = await _repositoryManager.TeamRepository.GetAllAsync(cancellationToken);
            var teamsDto = teams.Adapt<IEnumerable<TeamDto>>();
            return teamsDto;
        }
        public async Task<TeamDto> GetByIdAsync(int Id, CancellationToken cancellationToken = default)
        {
            var team = await _repositoryManager.TeamRepository.GetByIdAsync(Id, cancellationToken);
            if (team is null)
            {
                throw new TeamNotFoundException(Id);
            }
            var teamDto = team.Adapt<TeamDto>();
            return teamDto;
        }
        public async Task<TeamDto> CreateAsync(CreateTeamDto teamForCreationDto, CancellationToken cancellationToken = default)
        {
            var team = teamForCreationDto.Adapt<Team>();
            _repositoryManager.TeamRepository.Insert(team);
            await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);
            return team.Adapt<TeamDto>();
        }
        public async Task UpdateAsync(int Id, UpdateTeamDto teamForUpdateDto, CancellationToken cancellationToken = default)
        {
            var team = await _repositoryManager.TeamRepository.GetByIdAsync(Id, cancellationToken);
            if (team is null)
            {
                throw new TeamNotFoundException(Id);
            }
            team.Name = teamForUpdateDto.Name;
            team.City = teamForUpdateDto.City;
            team.DateFounded = teamForUpdateDto.DateFounded;
            await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);
        }
        public async Task DeleteAsync(int Id, CancellationToken cancellationToken = default)
        {
            var team = await _repositoryManager.TeamRepository.GetByIdAsync(Id, cancellationToken);
            if (team is null)
            {
                throw new TeamNotFoundException(Id);
            }
            _repositoryManager.TeamRepository.Remove(team);
            await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
