using FantasyNHL.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyNHL.Domain.Entities.Concrete.Players
{
    public class Player: Entity<Guid>
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }

        public int Height { get; set; }
        public int Weight { get; set; }

        public int Number { get; set; }
        public char Shoots { get; set; }

        //public Team Team { get; set; }
    }
}
