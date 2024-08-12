namespace IgnoreThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number:");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for(int i = 1; i <= 100; i++)
            {
                if(i == firstNumber || i == secondNumber || i == thirdNumber)
                {
                    continue;
                }
                Console.Write($"{i}\t");
                count++;
                if(count == 7)
                {
                    Console.WriteLine();
                    count = 0;
                }
            
            }

            


        }
    }
}
