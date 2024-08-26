using InputValidationLibrary;

namespace FirstAndLastDigitFinder
{
    public class Program
    {
        static void Main(string[] args)
        {
            int enteredNumber;

            Console.Write("Enter the number: ");
            while (!InputValidator.ValidateInt(Console.ReadLine(), out enteredNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write("Enter the number: ");
            }

            int lastDigit = enteredNumber % 10;

            int firstDigit = enteredNumber;
            while (firstDigit >= 10)
            {
                firstDigit /= 10;
            }

            Console.WriteLine($"First digit is {firstDigit}");
            Console.WriteLine($"Last digit is {lastDigit}");
        }
    }
}
