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

            C1++;

            if (C1 > C2) 
            {
                Console.WriteLine("C1 is greater");
            }
            else if (C1 < C2)
            {
                Console.WriteLine("C2 is greater");
            }
            else
            {
                Console.WriteLine("Both equal");
            }
        }
    }
}
