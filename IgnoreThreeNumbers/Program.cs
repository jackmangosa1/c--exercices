using InputValidationLibrary;

namespace IgnoreThreeNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, thirdNumber;


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


            Console.Write("Enter the third number: ");
            while (!InputValidator.ValidateInt(Console.ReadLine(), out thirdNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write("Enter the third number: ");
            }

            int count = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i == firstNumber || i == secondNumber || i == thirdNumber)
                {
                    continue;
                }
                Console.Write($"{i}\t");
                count++;
                if (count == 7)
                {
                    Console.WriteLine();
                    count = 0;
                }
            }
        }
    }
}
