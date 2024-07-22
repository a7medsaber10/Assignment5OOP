using Demo.Operator_Overloading;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex C1 = new Complex() { Real = 3, Imag = 4};
            Complex C2 = new Complex() { Real = 1, Imag = 2 };

            Complex C3 = C1 + C2;
        }
    }
}
