using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyNHL.Domain.Entities.Interfaces
{
    public class NamedEntity<T>: Entity<T> where T: struct
    {
        public string Name { get; set; }
    }
}
