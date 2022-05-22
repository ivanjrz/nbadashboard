using System;
using System.ComponentModel.DataAnnotations;

namespace Contracts
{
    public class CreatePlayerDto
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Team is required")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string Team { get; set; }

        [Required(ErrorMessage = "Joining date is required")]
        public DateTime Joined { get; set; }

        public string PhotoPath { get; set; }
    }
}
