using FantasyNHL.Domain.Entities.Concrete.League;
using FantasyNHL.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyNHL.Domain.Entities.Concrete.Teams
{
    public class Team: NamedEntity<int>
    {
        public string Abbreviation { get; set; }
        public Division Division { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Arena { get; set; }
        public string HeadCoach { get; set; }

        //public List<Player> Players { get; set; } // roster
    }
}
