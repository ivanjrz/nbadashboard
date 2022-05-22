using System;
using System.ComponentModel.DataAnnotations;

namespace Contracts
{
    public class UpdateTeamDto
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string City { get; set; }

        [Required(ErrorMessage = "Founding date is required")]
        public DateTime DateFounded { get; set; }

        public string PhotoPath { get; set; }
    }
}
