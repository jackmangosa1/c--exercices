using InputValidationLibrary;

namespace NumberSwapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;


            Console.WriteLine("Enter the first number:");
            while (!InputValidator.ValidateInt(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.WriteLine("Enter the first number:");
            }


            Console.WriteLine("Enter the second number:");
            while (!InputValidator.ValidateInt(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.WriteLine("Enter the second number:");
            }

            Console.WriteLine("Numbers before swapping:");
            Console.WriteLine("First number: " + firstNumber);
            Console.WriteLine("Second number: " + secondNumber);


            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine("Numbers after swapping:");
            Console.WriteLine("First number: " + firstNumber);
            Console.WriteLine("Second number: " + secondNumber);
        }
    }
}
