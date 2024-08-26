using InputValidationLibrary;

namespace SumOfDigitInNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (!InputValidator.ValidateInt(input, out int number))
            {
                Console.WriteLine("Invalid input, please enter a valid integer.");
                return;
            }

            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine($"Sum of digits is {sum}");
        }
    }
}
