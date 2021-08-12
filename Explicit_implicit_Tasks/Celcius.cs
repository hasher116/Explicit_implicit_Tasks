using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_implicit_Tasks
{
    class Celcius
    {
        public double Gradus { get; set; }
        public static explicit operator Fahrenheit(Celcius celcius)
        {
            return new Fahrenheit
            {
                Gradus = 9.0 / 5 * celcius.Gradus + 32
            };
        }
    }
}
