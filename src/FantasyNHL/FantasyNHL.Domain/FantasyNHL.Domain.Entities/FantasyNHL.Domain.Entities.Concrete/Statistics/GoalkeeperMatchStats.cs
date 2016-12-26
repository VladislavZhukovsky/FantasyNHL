using FantasyNHL.Domain.Entities.Concrete.Matches;
using FantasyNHL.Domain.Entities.Concrete.Players;
using FantasyNHL.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyNHL.Domain.Entities.Concrete.Statistics
{
    //[GoalkeeperId] [uniqueidentifier] NOT NULL,
    //[MatchId] [int] NOT NULL,
    //[Goals] [int] NULL,
    //[Assists] [int] NULL,
    //[Points] [int] NULL,
    //[PenaltyMinutes] [int] NULL,
    //[TimeOnIce] [int] NULL,
    //[Saves] [int] NULL,
    //[SavePercentage] [float] NULL
    public class GoalkeeperMatchStats: Entity
    {
        public Player Goalkeeper { get; set; }
        public Match Match { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Points { get; set; }
        public int PenaltyMinutes { get; set; }
        public int TimeOnIce { get; set; }
        public int Saves { get; set; }
        public double SavePercentage { get; set; } 
    }
}
