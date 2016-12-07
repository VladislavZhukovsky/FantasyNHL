﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyNHL.Domain.Entities.Interfaces
{
    public abstract class Entity<T>: Entity where T: struct
    {
        public T Id { get; set; }
    }
}
