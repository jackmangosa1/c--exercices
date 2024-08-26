using InputValidationLibrary;

namespace DivisionByZeroException
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int firstNumber;
                int secondNumber;

                Console.Write("Enter the first number: ");
                while (!InputValidator.ValidateInt(Console.ReadLine(), out firstNumber))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.Write("Enter the first number: ");
                }

                Console.Write("Enter the second number: ");
                while (!InputValidator.ValidateInt(Console.ReadLine(), out secondNumber))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.Write("Enter the second number: ");
                }

                int division = firstNumber / secondNumber;

                Console.WriteLine($"The division of {firstNumber} by {secondNumber} is {division}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
        }
    }
}
