﻿using System;
namespace Domain.Entities
{
    /// <summary>
    /// Includes W/L/D, Advanced stats
    /// Source: https://www.basketball-reference.com
    /// </summary>
    public class TeamHistory
    {
        public int TeamHistoryId { get; set; }
        public string Team { get; set; }

        public string Season { get; set; }

        public int WinRecord { get; set; }
        public int LossRecord { get; set; }
        public int DrawRecord { get; set; }

        public double MOV { get; set; }
        public double AverageAge { get; set; }
        public double SOS { get; set; }
        public double ORTg { get; set; }
        public double DRTg { get; set; }
        public double NRTg { get; set; }
        public double FTr { get; set; }
        public double ThreePAr { get; set; }
        public double TrueShootPct { get; set; }
        public double OEFGPct { get; set; }
        public double DEFGPct { get; set; }
        public double ORB { get; set; }
        public double DRB { get; set; }
    }
}
