using InputValidationLibrary;

namespace NegativeNumberException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter a number: ");
            while (!InputValidator.ValidateInt(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write("Enter a number: ");
            }

            try
            {
                Program program = new Program();
                program.CheckIfNegative(number);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CheckIfNegative(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Negative numbers are not allowed.");
            }
        }
    }
}
