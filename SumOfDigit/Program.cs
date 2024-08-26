using InputValidationLibrary;

namespace SumOfDigit
{
    public class Program
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

            if (number < 0)
            {
                Console.WriteLine("Number should be greater than 0");
                return;
            }

            Program program = new Program();
            int sum = program.GetSumOfDigit(number);

            Console.WriteLine($"Sum of digits is {sum}");
        }

        int GetSumOfDigit(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}
