using Assignment5OOPSecondProject.Classes;

namespace Assignment5OOPSecondProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read first number from user
            double num1 = ReadDoubleFromUser("Enter the first number: ");

            // Read second number from user
            double num2 = ReadDoubleFromUser("Enter the second number: ");


            // Calling static methods directly without creating an instance
            double resultAdd = Maths.Add(num1, num2);
            Console.WriteLine($"Addition result: {resultAdd}");

            double resultSubtract = Maths.Subtract(num1, num2);
            Console.WriteLine($"Subtraction result: {resultSubtract}");

            double resultMultiply = Maths.Multiply(num1, num2);
            Console.WriteLine($"Multiplication result: {resultMultiply}");

            double resultDivide = Maths.Divide(num1, num2);
            if (resultDivide != 0)
            {
                Console.WriteLine($"Division result: {resultDivide}");
            }
        }

        static double ReadDoubleFromUser(string Prompt)
        {
            double number;
            bool validInput = false;

            do
            {
                Console.Write(Prompt);
                string input = Console.ReadLine();

                if (double.TryParse(input, out number))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input please enter a valid number");
                }
            } while (!validInput);
            return number;
        }
    }
}
