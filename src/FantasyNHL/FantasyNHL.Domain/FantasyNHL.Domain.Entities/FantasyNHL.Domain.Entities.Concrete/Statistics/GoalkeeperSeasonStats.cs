using FantasyNHL.Domain.Entities.Concrete.Players;
using FantasyNHL.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyNHL.Domain.Entities.Concrete.Statistics
{
    //[GoalKeeperId] [uniqueidentifier] NOT NULL,
    //[Season] [int] NOT NULL,
    //[Tournament] [char](1) NOT NULL,
    //[GamesPlayed] [int] NOT NULL,
    //[Goals] [int] NOT NULL,
    //[Assists] [int] NOT NULL,
    //[Points] [int] NOT NULL,
    //[GoalsAgainstAverage] [float] NOT NULL,
    //[SavePercentage] [float] NOT NULL
    public class GoalkeeperSeasonStats: Entity
    {
        public Player Goalkeeper { get; set; }
        public int Season { get; set; }
        public char Tournament {get; set;}
        public int GamesPlayed { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Points { get; set; }
        public double GoalsAgainstAverage { get; set; } 
        public double SavePercentage { get; set; } 
    }
}
