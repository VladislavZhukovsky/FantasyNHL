using FantasyNHL.Domain.Entities.Concrete.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyNHL.Domain.Entities.Concrete.Statistics
{
    //[SkaterId] [uniqueidentifier] NOT NULL,
    //[Season] [int] NOT NULL,
    //[Tournament] [char](1) NOT NULL,
    //[GamesPlayed] [int] NOT NULL,
    //[Goals] [int] NOT NULL,
    //[Assists] [int] NOT NULL,
    //[Points] [int] NOT NULL,
    //[PlusMinus] [int] NOT NULL,
    //[PenaltyMinutes] [int] NOT NULL,
    //[PointsPerGame] [float] NOT NULL,
    //[PowerPlayGoals] [int] NOT NULL,
    //[PowerPlayPoints] [int] NOT NULL,
    //[GameWinningGoals] [int] NOT NULL,
    //[OvertimeGoals] [int] NOT NULL,
    //[Shots] [int] NOT NULL,
    //[ShootingPercentage] [float] NOT NULL,
    //[TimeOnIcePerGame] [int] NOT NULL,
    //[FaceOffWinPercentage] [float] NOT NULL
    public class SkaterSeasonStats
    {
        public Player Skater { get; set; }
        public int Season { get; set; }
        public char Tournament { get; set; }
        public int GamesPlayed { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int PlusMinus { get; set; }
        public int PenaltyMinutes { get; set; }
        public double PointsPerGame { get; set; }
        public int PowerPlayPoints { get; set; }
        public int GameWinningGoals { get; set; }
        public int OvertimeGoals { get; set; }
        public int Shots { get; set; }
        public double ShootingPercentage { get; set; }
        public int TimeOnIcePerGame { get; set; }
        public double FaceOffWinPercentage { get; set; }
    }
}
