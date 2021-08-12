using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_implicit_Tasks
{
    class Fahrenheit
    {
        public double Gradus { get; set; }
        public static explicit operator Celcius(Fahrenheit fahrenheit)
        {
            return new Celcius
            {
                Gradus = 5.0 / 9 * (fahrenheit.Gradus - 32)
            };
        }
    }
}
