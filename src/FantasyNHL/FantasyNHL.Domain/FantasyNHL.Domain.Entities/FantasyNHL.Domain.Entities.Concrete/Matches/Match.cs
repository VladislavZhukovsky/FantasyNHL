using FantasyNHL.Domain.Entities.Concrete.Teams;
using FantasyNHL.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyNHL.Domain.Entities.Concrete.Matches
{
    public class Match: Entity<int>
    {
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public int HomeRosterId { get; set; }
        public int AwayRosterId { get; set; }

        public char Tournament { get; set; }
        public int Season { get; set; }
        public string Arena { get; set; }
        public DateTime DateTime { get; set; }
        public string HomeHeadCoach { get; set; }
        public string AwayHeadCoach { get; set; }
        public string Status { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
    }
}
