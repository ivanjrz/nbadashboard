using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class SinglePrediction
    {
        [Key]
        public int SinglePredictionId { get; set; }
        public int TeamId { get; set; }
        public double NBA_API_PlayerId { get; set; }
        public int Win { get; set; }

    }
}
