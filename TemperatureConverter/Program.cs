using InputValidationLibrary;

namespace TemperatureConverter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in Celsius: ");
            string input = Console.ReadLine();

            if (!InputValidator.ValidateDouble(input, out double celsius))
            {
                Console.WriteLine("Please enter a valid number.");
                return;
            }

            double fahrenheit = (celsius * 1.8) + 32;
            Console.WriteLine($"The temperature in Fahrenheit is: {fahrenheit}");
        }
    }
}
