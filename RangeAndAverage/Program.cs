using InputValidationLibrary;

namespace RangeAndAverage
{
    public class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;

            Console.Write("Enter the first number:");
            while (!InputValidator.ValidateInt(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write("Enter the first number:");
            }


            Console.Write("Enter the second number:");
            while (!InputValidator.ValidateInt(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write("Enter the second number:");
            }

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("The first number must be less than the second number");
                return;
            }

            int sum = 0;
            int count = 0;
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                sum += i;
                count++;
            }

            int average = count > 0 ? sum / count : 0;

            Console.WriteLine($"The sum of the numbers is {sum} and the average is {average}");
        }
    }
}
