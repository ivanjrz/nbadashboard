using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Arena { get; set; }
        public DateTime DateFounded { get; set; }
        public string PhotoPath { get; set; }
        public double NBA_API_TeamId { get; set; }
        public ICollection<Player> Players { get; set; }
        public ICollection<TeamHistory> TeamHistories { get; set; }
    }
}
