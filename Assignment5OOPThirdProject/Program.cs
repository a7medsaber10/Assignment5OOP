using Assignment5OOPThirdProject.Classes;

namespace Assignment5OOPThirdProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());

            // Operator overloads test
            D3 = D1 + D2;
            Console.WriteLine(D3.ToString());

            D3 = D1 + 7800;
            Console.WriteLine(D3.ToString());

            D3 = 666 + D3;
            Console.WriteLine(D3.ToString());

            D3 = ++D1;
            Console.WriteLine(D3.ToString());

            D3 = --D2;
            Console.WriteLine(D3.ToString());

            D1 = D1 - D2;
            Console.WriteLine(D1.ToString());

            if (D1 > D2)
                Console.WriteLine("D1 is greater than D2");

            if (D1 <= D2)
                Console.WriteLine("D1 is less than or equal to D2");

            DateTime Obj = (DateTime)D1;
            Console.WriteLine(Obj.ToString("HH:mm:ss"));
        }
    }
}
