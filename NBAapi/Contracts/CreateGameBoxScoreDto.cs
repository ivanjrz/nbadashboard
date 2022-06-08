using System;
using System.ComponentModel.DataAnnotations;

namespace Contracts
{
    public class CreateGameBoxScoreDto
    {
        [Required(ErrorMessage = "Season (YYYY-YYYY) is required")]
        public string Season { get; set; }

        [Required(ErrorMessage = "Season (Year) is required")]
        public string SeasonShortName { get; set; }

        [Required(ErrorMessage = "Game date (EST) is required")]
        public DateTime DateEST { get; set; }

    }
}
