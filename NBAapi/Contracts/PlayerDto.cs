using System;

namespace Contracts
{
    public class PlayerDto
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public DateTime Joined { get; set; }
        public string PhotoPath { get; set; }
    }
}