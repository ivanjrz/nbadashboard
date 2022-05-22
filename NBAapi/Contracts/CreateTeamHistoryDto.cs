using System;
using System.ComponentModel.DataAnnotations;

namespace Contracts
{
    public class CreateTeamHistoryDto
    {
        [Required(ErrorMessage = "Team is required")]
        [StringLength(50, ErrorMessage = "Team can't be longer than 50 characters")]
        public string Team { get; set; }
        [Required(ErrorMessage = "NBA Season is required")]
        [StringLength(50, ErrorMessage = "Season can't be longer than 50 characters")]
        public string Season { get; set; }

        [Required(ErrorMessage = "Win record is required")]
        public int WinRecord { get; set; }
        [Required(ErrorMessage = "Loss record is required")]
        public int LossRecord { get; set; }
        [Required(ErrorMessage = "Draw record (if any) is required")]
        public int DrawRecord { get; set; }

        [Required(ErrorMessage = "Margin of Victory is required")]
        public double MOV { get; set; }
        [Required(ErrorMessage = "Team's average age is required")]
        public double AverageAge { get; set; }
        [Required(ErrorMessage = "Strength of schedule is required")]
        public double SOS { get; set; }
        [Required(ErrorMessage = "Offensive rating is required")]
        public double ORTg { get; set; }
        [Required(ErrorMessage = "Defensive rating is required")]
        public double DRTg { get; set; }
        [Required(ErrorMessage = "Net rating is required")]
        public double NRTg { get; set; }
        [Required(ErrorMessage = "Free throw attempt rate is required")]
        public double FTr { get; set; }
        [Required(ErrorMessage = "Three-point attempt rate is required")]
        public double ThreePAr { get; set; }
        [Required(ErrorMessage = "True shooting percentage is required")]
        public double TrueShootPct { get; set; }
        [Required(ErrorMessage = "Offensive Effective field goal percentage is required")]
        public double OEFGPct { get; set; }
        [Required(ErrorMessage = "Defensive effective field goal percentage is required")]
        public double DEFGPct { get; set; }
        [Required(ErrorMessage = "Offensive rebound percentage is required")]
        public double ORB { get; set; }
        [Required(ErrorMessage = "Defensive rebound percentage is required")]
        public double DRB { get; set; }
    }
}
