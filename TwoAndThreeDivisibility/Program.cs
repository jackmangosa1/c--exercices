using InputValidationLibrary;

namespace TwoAndThreeDivisibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number");

            string input = Console.ReadLine();

            if (InputValidator.ValidateInt(input, out int number))
            {
                if (number % 2 == 0 && number % 3 == 0)
                {
                    int multiplication = 2 * 3;
                    Console.WriteLine("The multiplication of 2 and 3 is: " + multiplication);
                }
                else
                {
                    int addition = 2 + 3;
                    Console.WriteLine("The addition of 2 and 3 is: " + addition);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }
}
