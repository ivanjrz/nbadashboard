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
    internal sealed class SinglePredictionService : ISinglePredictionService
    {
        private readonly IRepositoryManager _repositoryManager;
        public SinglePredictionService(IRepositoryManager repositoryManager) => _repositoryManager = repositoryManager;

        public async Task<IEnumerable<SinglePredictionDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var preds = await _repositoryManager.SinglePredictionRepository.GetAllAsync(cancellationToken);
            var predsDto = preds.Adapt<IEnumerable<SinglePredictionDto>>();
            return predsDto;
        }

        public async Task<IEnumerable<SinglePredictionDto>> GetAllBySeriesIdAsync(int seriesId, CancellationToken cancellationToken = default)
        {
            var predictions = await _repositoryManager.SinglePredictionRepository.GetAllBySeriesIdAsync(seriesId, cancellationToken);
            var predsDto = predictions.Adapt<IEnumerable<SinglePredictionDto>>();
            return predsDto;
        }

    }
}
