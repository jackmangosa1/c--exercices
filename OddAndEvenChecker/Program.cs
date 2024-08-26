using InputValidationLibrary;

namespace OddAndEvenChecker
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Enter a number");


            while (!InputValidator.ValidateInt(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.WriteLine("Enter a number:");
            }


            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
