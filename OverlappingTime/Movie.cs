﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverlappingTime
{
    public class Movie
    {

        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        public Movie(DateTime start, DateTime end)
        {
            this.Start = start;
            this.End = end;
        }
        
    }
}
