using InputValidationLibrary;

namespace StringToIntegerException
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (InputValidator.ValidateInt(input, out int number))
            {
                Console.WriteLine($"The converted number is {number}");
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a valid integer.");
            }
        }
    }
}
