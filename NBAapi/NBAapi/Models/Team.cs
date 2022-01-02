
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NBAapi.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime DateFounded { get; set; }
        public string PhotoPath { get; set; }
        public Team()
        {

        }

    }
}
