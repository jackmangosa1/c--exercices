using InputValidationLibrary;

namespace RangeException
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                if (!InputValidator.ValidateInt(input, out int number))
                {
                    throw new FormatException("Invalid input. Please enter a valid integer.");
                }

                if (!InputValidator.ValidateInRange(number, 0, 1000))
                {
                    throw new ArgumentOutOfRangeException(nameof(number), "Number must be between 0 and 1000.");
                }

                Console.WriteLine("Number is within the valid range.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
