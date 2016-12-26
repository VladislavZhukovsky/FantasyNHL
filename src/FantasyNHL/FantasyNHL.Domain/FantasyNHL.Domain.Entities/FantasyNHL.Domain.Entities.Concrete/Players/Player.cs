using FantasyNHL.Domain.Entities.Concrete.Teams;
using FantasyNHL.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyNHL.Domain.Entities.Concrete.Players
{
    public class Player: Person
    {
        public int Height { get; set; }
        public int Weight { get; set; }

        public int Number { get; set; }
        public char Shoots { get; set; }

        //public Team Team { get; set; }
    }
}
