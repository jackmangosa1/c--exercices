using InputValidationLibrary;

namespace NegativePositiveChecker
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number;


            Console.Write("Enter a number:");
            while (!InputValidator.ValidateInt(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.WriteLine("Enter a number");
            }


            if (number > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number is zero");
            }
        }
    }
}
