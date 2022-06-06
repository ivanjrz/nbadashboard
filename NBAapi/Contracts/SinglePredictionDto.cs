using System;
using System.Collections.Generic;

namespace Contracts
{
    public class SinglePredictionDto
    {
        public int SinglePredictionId { get; set; }
        public string TeamId { get; set; }
        public double NBA_API_PlayerId { get; set; }
        public int Win { get; set; }
    }
}
