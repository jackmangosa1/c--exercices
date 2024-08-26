using InputValidationLibrary;

namespace EvenDigitsAddition
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
                Console.WriteLine("Enter a number:");
            }

            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"Sum of even digits is {sum}");
        }
    }
}
