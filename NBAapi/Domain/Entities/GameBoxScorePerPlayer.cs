using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class GameBoxScorePerPlayer
    {
        [Key]
        public int GameBoxScorePerPlayerId { get; set; }

        //Field Goals Attempted
        public int FGA { get; set; }
        //Field Goals Made
        public int FGM { get; set; }
        //Field Goals 3pt Attempted
        public int FG3A { get; set; }
        //Field Goals 3pt Made
        public int FG3M { get; set; }
        //Free throws attempted
        public int FTA { get; set; }
        //Free throws made
        public int FTM { get; set; }
        //Offensive rebounds
        public int OREB{ get; set; }
        //Defensive rebounds
        public int DREB { get; set; }
        //Total rebounds
        public int REB { get; set; }
        //Assists
        public int AST { get; set; }
        //Blocks
        public int BLK { get; set; }
        //Turnovers
        public int TO { get; set; }
        //Personal fouls
        public int PF { get; set; }

        public double NBA_API_GameId { get; set; }
    }
}
