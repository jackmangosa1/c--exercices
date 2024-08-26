using InputValidationLibrary;

namespace PositiveAndNegativeArraySeparator
{
    public class Program
    {
        static void Main(string[] args)
        {
            int arrayLength;

            Console.Write("How many elements do you want in your array?: ");
            while (!InputValidator.ValidatePositiveInt(Console.ReadLine(), out arrayLength))
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                Console.Write("How many elements do you want in your array?: ");
            }

            int[] arrayOfNumbers = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                int element;
                Console.Write($"Enter the {i + 1} element: ");
                while (!InputValidator.ValidateInt(Console.ReadLine(), out element))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.Write($"Enter the {i + 1} element: ");
                }
                arrayOfNumbers[i] = element;
            }

            int positiveCount = 0;
            int negativeCount = 0;
            foreach (int number in arrayOfNumbers)
            {
                if (number > 0)
                {
                    positiveCount++;
                }
                else if (number < 0)
                {
                    negativeCount++;
                }
            }

            int[] positiveArray = new int[positiveCount];
            int[] negativeArray = new int[negativeCount];

            int positiveIndex = 0;
            int negativeIndex = 0;
            foreach (int number in arrayOfNumbers)
            {
                if (number > 0)
                {
                    positiveArray[positiveIndex++] = number;
                }
                else if (number < 0)
                {
                    negativeArray[negativeIndex++] = number;
                }
            }

            Console.WriteLine("Positive numbers are:");
            foreach (var number in positiveArray)
            {
                Console.Write($"{number}\t");
            }

            Console.WriteLine();

            Console.WriteLine("Negative numbers are:");
            foreach (var number in negativeArray)
            {
                Console.Write($"{number}\t");
            }
        }
    }
}
