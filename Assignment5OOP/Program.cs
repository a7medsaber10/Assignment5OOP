using Assignment5OOP.Classes;

namespace Assignment5OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _3DPoint P1 = ReadPointFromUser("Enter coordinates for Point P1 (x y z) space separated: ");
            Console.WriteLine($"P1: {P1}");

            _3DPoint P2 = ReadPointFromUser("Enter coordinates for Point P2 (x y z) space separated: ");
            Console.WriteLine($"P2: {P2}");

            if (P1 == P2)
            {
                Console.WriteLine("P1 and P2 are Equal");
            }
            else
            {
                Console.WriteLine("P1 and P2 are Not Equal");
            }

            _3DPoint[] points = { P1, P2 };

            // Sort the array of points based on X & Y coordinates
            Array.Sort(points);

            Console.WriteLine("\nSorted Points:");
            foreach (var point in points)
            {
                Console.WriteLine(point);
            }

            _3DPoint cloneP1 = (_3DPoint)P1.Clone();
            Console.WriteLine($"\nCloned P1: {cloneP1}");
        }

        // Helper method to read Point3D coordinates from user input
        static _3DPoint ReadPointFromUser(string prompt)
        {
            int x = 0, y = 0, z = 0;
            bool validInput = false;

            // Loop until valid input is provided
            while (!validInput)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');

                if (parts.Length == 3 && int.TryParse(parts[0], out x) && int.TryParse(parts[1], out y) && int.TryParse(parts[2], out z))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter three integers separated by spaces.");
                }
            }

            return new _3DPoint(x, y, z);
        }
    }
}
