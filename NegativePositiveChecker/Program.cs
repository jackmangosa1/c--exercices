namespace NegativePositiveChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number");
                int number  = Convert.ToInt32(Console.ReadLine());
                if (number > 0)
                {
                    Console.WriteLine("The number is positive");
                }
                else if (number < 0)
                {
                    Console.WriteLine("The number is negative");
                }
                else
                {
                    Console.WriteLine("The number is zero");
                }
            }catch(FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }
}
