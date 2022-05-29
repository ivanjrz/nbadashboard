using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class GameBoxScore
    {
        [Key]
        public int GameBoxScoreId { get; set; }
        public DateTime DateEST { get; set; }
        public string Season { get; set; }
        public string SeasonShortName { get; set; }
        public int HomeTeamWin { get; set; }
        public int AwayTeamWin { get; set; }

        public int PointsHome { get; set; }
        //Field goals percentage
        public float FGPctHome {get; set; }
        //Free throws percentage
        public float FTPctHome { get; set; }
        //Field goals 3pt percentage
        public float FG3PctHome { get; set; }
        //Total assists 
        public int ASTHome { get; set; }
        //Total rebounds
        public int REBHome { get; set; }

        public int PointsAway { get; set; }
        //Field goals percentage
        public float FGPctAway { get; set; }
        //Free throws percentage
        public float FTPctAway { get; set; }
        //Field goals 3pt percentae
        public float FG3PctAway { get; set; }
        //Total assists 
        public int ASTAway { get; set; }
        //Total rebounds
        public int REBAway { get; set; }

        public double NBA_API_GameId { get; set; }
        public double NBA_API_HomeTeamId { get; set; }
        public double NBA_API_AwayTeamId { get; set; }
    }
}
