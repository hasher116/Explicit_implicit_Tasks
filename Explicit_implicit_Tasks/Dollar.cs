using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_implicit_Tasks
{
    class Dollar
    {
        public decimal Sum { get; set; }
        public static implicit operator Dollar(Euro euro)
        {
            return new Dollar
            {
                Sum = euro.Sum * 1.14M
            };
        }
        public static explicit operator Euro(Dollar dollar)
        {
            return new Euro
            {
                Sum = dollar.Sum / 1.14M
            };
        }
    }
}
