using InputValidationLibrary;

namespace MaxArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements;


            Console.Write("How many numbers do you want in your array?: ");
            while (!InputValidator.ValidateInt(Console.ReadLine(), out numberOfElements) || numberOfElements <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                Console.WriteLine("How many numbers do you want in your array?");
            }

            int[] numbers = new int[numberOfElements];


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Enter number {i + 1}:");
                while (!InputValidator.ValidateInt(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.WriteLine($"Enter number {i + 1}:");
                }
            }

            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine($"The maximum number in the array is {max}");
        }
    }
}
