using FantasyNHL.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyNHL.Domain.Entities.Concrete.League
{
    public class Division: NamedEntity<int>
    {
        public Conference Conference { get; set; }
    }
}
