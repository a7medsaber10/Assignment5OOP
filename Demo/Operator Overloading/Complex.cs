using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Operator_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
        #region Binary Operators
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) + (b?.Real ?? 0),
                Imag = (a?.Imag ?? 0) + (b?.Imag ?? 0)
            };
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) - (b?.Real ?? 0),
                Imag = (a?.Imag ?? 0) - (b?.Imag ?? 0)
            };
        }
        #endregion

        #region Unary Operators
        public static Complex operator ++(Complex complex)
        {
            return new Complex()
            {
                Real = (complex?.Real ?? 0) + 1,
                Imag = (complex?.Imag ?? 0)
            };
        }

        public static Complex operator --(Complex complex)
        {
            return new Complex()
            {
                Real = (complex?.Real ?? 0) - 1,
                Imag = (complex?.Imag ?? 0)
            };
        }
        #endregion
    }
}
