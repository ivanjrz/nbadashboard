using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime DateFounded { get; set; }
        public string PhotoPath { get; set; }
        public ICollection<Player> Players { get; set; }
    }
}
