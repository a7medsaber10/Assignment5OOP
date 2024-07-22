using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    internal class Rectangle : Shape // implement & inherit
    {
        public override double Perimiter
        {
            get
            {
                return ((Dim01 +  Dim02) * 2);
            }
        }

        public override double CalcArea()
        {
            return Dim01 * Dim02;
        }
    }
}
