namespace EvenDIigtsAddition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number  = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
           for(int i = 1; i < number; i++)
            {
                if(i % 2 == 0)
                {
                    sum += i;
                }
            }

           Console.WriteLine($"Sum of even digits is {sum}");
        }
    }
}
