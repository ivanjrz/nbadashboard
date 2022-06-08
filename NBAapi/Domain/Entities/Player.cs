using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public DateTime Joined { get; set; }
        public string PhotoPath { get; set; }
        public double NBA_API_PlayerId { get; set; }
    }
}
