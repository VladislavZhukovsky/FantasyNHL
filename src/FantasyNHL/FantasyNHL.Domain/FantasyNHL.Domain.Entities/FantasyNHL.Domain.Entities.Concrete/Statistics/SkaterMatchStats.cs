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
    //[SkaterId] [uniqueidentifier] NOT NULL,
    //[MatchId] [int] NOT NULL,
    //[ShotsOnGoal] [int] NOT NULL,
    //[Goals] [int] NOT NULL,
    //[Assists] [int] NOT NULL,
    //[Points] [int] NOT NULL,
    //[FaceOffPercentage] [float] NULL,
    //[PenaltyMinutes] [int] NOT NULL,
    //[Hits] [int] NOT NULL,
    //[BlockedShots] [int] NOT NULL,
    //[Giveaways] [int] NOT NULL,
    //[Takeaways] [int] NOT NULL,
    //[PlusMinus] [int] NOT NULL,
    //[TimeOnIce] [int] NOT NULL
    public class SkaterMatchStats: Entity
    {
        public Player Skater { get; set; }
        public Match Match { get; set; }
        public int ShotsOnGoal { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Points { get; set; }
        public double FaceOffPercentage { get; set; }
        public int PenaltyMinutes { get; set; }
        public int Hits { get; set; }
        public int BlockedShots { get; set; }
        public int Giveaways { get; set; }
        public int Takeaways { get; set; }
        public int PlusMinus { get; set; }
        public int TimeOnIce { get; set; }
    }
}
