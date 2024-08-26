using InputValidationLibrary;

namespace SameNumberChecker
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first number");
                string firstInput = Console.ReadLine();
                if (!InputValidator.ValidateInt(firstInput, out int firstNumber))
                {
                    throw new FormatException("Invalid input for the first number. Please enter a valid integer.");
                }

                Console.WriteLine("Enter the second number");
                string secondInput = Console.ReadLine();
                if (!InputValidator.ValidateInt(secondInput, out int secondNumber))
                {
                    throw new FormatException("Invalid input for the second number. Please enter a valid integer.");
                }

                Console.WriteLine("Enter the third number");
                string thirdInput = Console.ReadLine();
                if (!InputValidator.ValidateInt(thirdInput, out int thirdNumber))
                {
                    throw new FormatException("Invalid input for the third number. Please enter a valid integer.");
                }

                if (firstNumber == secondNumber && secondNumber == thirdNumber)
                {
                    Console.WriteLine("Numbers are the same");
                }
                else
                {
                    Console.WriteLine("Numbers are not the same");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
