namespace SumOfDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Enter a number:");
           int number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Number should be greater than 0");
                return;
            }
            int sum = getSumOfDigit(number);
            Console.WriteLine($"Sum of digits is {sum}");
        }

        static int getSumOfDigit(int number) { 
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        
        }
    }
}
