using FantasyNHL.Domain.Entities.Concrete.Teams;
using FantasyNHL.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyNHL.Domain.Entities.Concrete.Statistics
{
    //[TeamId] [int] NOT NULL,
    //[Season] [int] NOT NULL,
    //[Tournament] [char](1) NOT NULL,
    //[GamesPlayed] [int] NOT NULL,
    //[Wins] [int] NOT NULL,
    //[Losses] [int] NOT NULL,
    //[OvertimeShootoutLosses] [int] NOT NULL,
    //[Points] [int] NOT NULL,
    //[RegularOvertimeWins] [int] NOT NULL,
    //[GoalsFor] [int] NOT NULL,
    //[GoalsAgainst] [int] NOT NULL,
    //[GoalDifferential] [int] NOT NULL,
    //[HomeRecord] [char](8) NOT NULL,
    //[AwayRecord] [char](8) NOT NULL,
    //[ShootoutRecord] [char](5) NOT NULL,
    //[Last10] [char](8) NOT NULL,
    //[Streak] [char](4) NOT NULL
    public class TeamStandingStats: Entity
    {
        public Team Team { get; set; }
        public int Season { get; set; }
        public char Tournament { get; set; }
        public int GamesPlayed { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int OvertimeShootoutLosses { get; set; }
        public int Points { get; set; }
        public int RegularOvertimeWins { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int GoalDifferential { get; set; }
        public string HomeRecord { get; set; }
        public string AwayRecord { get; set; }
        public string ShootoutRecord { get; set; }
        public string Last10 { get; set; }
        public string Streak { get; set; }
    }
}
