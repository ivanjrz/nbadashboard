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
    internal sealed class SeriesPredictionSummaryService : ISeriesPredictionSummaryService
    {
        private readonly IRepositoryManager _repositoryManager;
        public SeriesPredictionSummaryService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;

        public async Task<IEnumerable<SeriesPredictionSummaryDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var series = await _repositoryManager.SeriesPredictionSummaryRepository.GetAllAsync(cancellationToken);
            var seriesDto = series.Adapt<IEnumerable<SeriesPredictionSummaryDto>>();
            return seriesDto;
        }
        public async Task<SeriesPredictionSummaryDto> GetByIdAsync(int Id, CancellationToken cancellationToken = default)
        {
            var series = await _repositoryManager.SeriesPredictionSummaryRepository.GetByIdAsync(Id, cancellationToken);
            if (series is null)
            {
                throw new SeriesPredictionSummaryNotFoundException(Id);
            }
            var seriesDto = series.Adapt<SeriesPredictionSummaryDto>();
            return seriesDto;
        }
        public async Task<SeriesPredictionSummaryDto> CreateAsync(SeriesPredictionSummaryDto seriesForCreation, CancellationToken cancellationToken = default)
        {
            var series = seriesForCreation.Adapt<Domain.Entities.SeriesPredictionSummary>();
            _repositoryManager.SeriesPredictionSummaryRepository.Insert(series);
            await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);
            return series.Adapt<SeriesPredictionSummaryDto>();
        }
        public async Task DeleteAsync(int Id, CancellationToken cancellationToken = default)
        {
            var series = await _repositoryManager.SeriesPredictionSummaryRepository.GetByIdAsync(Id, cancellationToken);
            if (series is null)
            {
                throw new SeriesPredictionSummaryNotFoundException(Id);
            }
            _repositoryManager.SeriesPredictionSummaryRepository.Remove(series);
            await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
