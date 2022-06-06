using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class HeadToHeadPrediction
    {
        [Key]
        public int HeadToHeadPredictionId { get; set; }
        public string HomeTeamId { get; set; }
        public string AwayTeamId { get; set; }
        public double NBA_API_HomeTeamId { get; set; }
        public double NBA_API_AwayTeamId { get; set; }
        public int HomeWin { get; set; }
        public int AwayWin { get; set; }

    }
}
