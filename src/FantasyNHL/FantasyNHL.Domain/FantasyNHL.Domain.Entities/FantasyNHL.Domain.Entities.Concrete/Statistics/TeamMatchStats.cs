using FantasyNHL.Domain.Entities.Concrete.Matches;
using FantasyNHL.Domain.Entities.Concrete.Teams;
using FantasyNHL.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyNHL.Domain.Entities.Concrete.Statistics
{
    //[MatchId] [int] NOT NULL,
    //[TeamId] [int] NOT NULL,
    //[ShotsOnGoal] [int] NOT NULL,
    //[Goals] [int] NOT NULL,
    //[FaceOffPercentage] [float] NOT NULL,
    //[PowerPlayRealization] [char](10) NOT NULL,
    //[PenaltyMinutes] [int] NOT NULL,
    //[Hits] [int] NOT NULL,
    //[BlockedShots] [int] NOT NULL,
    //[Giveaways] [int] NOT NULL
    public class TeamMatchStats: Entity
    {
        public Match Match { get; set; }
        public Team Team { get; set; }
        public int ShotsOnGoal { get; set; }
        public int Goals { get; set; }
        public double FaceOffPercentage { get; set; }
        public double PowerPlayRealization { get; set; }
        public int PenaltyMinutes { get; set; }
        public int Hits { get; set; }
        public int BlockedShots { get; set; }
        public int Giveaways { get; set; }
    }
}
