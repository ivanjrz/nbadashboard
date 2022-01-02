
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NBAapi.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public DateTime Joined { get; set; }
        public string PhotoPath { get; set; }

    }
}
