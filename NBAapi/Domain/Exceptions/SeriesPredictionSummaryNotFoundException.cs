using System;
namespace Domain.Exceptions
{
	public class SeriesPredictionSummaryNotFoundException : NotFoundException
	{
		public SeriesPredictionSummaryNotFoundException(int id) : base($"The series with id: {id} was not found")
		{ }
	}
}

