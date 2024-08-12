namespace RangeAndAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first numver");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("The first number must be less than the second number");
                return;
            }
            int sum = 0;
            int average = 0;
            int count = 0;
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                sum += i;
                count++;    
            }
            average = sum / count;
            Console.WriteLine($"The sum of the numbers is {sum} and the average is {average}");
        }
    }
}
