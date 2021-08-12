using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_implicit_Tasks
{
    class Clock
    {
        public int Hours { get; set; }
        public static explicit operator int(Clock clock)
        {
            return clock.Hours;
        }
        public static explicit operator Clock(int x)
        {
            return new Clock
            {
                Hours = x % 24
            };
        }
    }
}
