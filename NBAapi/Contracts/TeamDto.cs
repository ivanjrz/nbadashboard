using System;
using System.Collections.Generic;

namespace Contracts
{
    public class TeamDto
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime DateFounded { get; set; }
        public string PhotoPath { get; set; }
        public IEnumerable<PlayerDto> Players { get; set; }
    }
}
