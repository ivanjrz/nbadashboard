using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class SeriesPredictionSummary
    {
        [Key]
        public int SeriesPredictionSummaryId { get; set; }
        public DateTime DateAdded { get; set; }

        //Algorithm specific values
        public int Features { get; set; }
        public double Loss { get; set; }
        public double Accuracy { get; set; }
        public double Recall { get; set; }
        public string Optimizer { get; set; }
        public int Epochs { get; set; }
        public int TrainSize { get; set; }
        public int TestSize { get; set; }
        public string Technique { get; set; }

        [MaxLength(255)]
        public string Comments { get; set; }
        public string Team { get; set; }
        public int TeamId { get; set; }
        public double NBA_API_TeamId { get; set; }
        public ICollection<SinglePrediction> Predictions { get; set; }

    }
}
