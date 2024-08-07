namespace OddAndEvenChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number");
                int number  = Convert.ToInt32(Console.ReadLine());
                if(number % 2 == 0)
                {

                   Console.WriteLine("The number is even");
                }
                else
                {
                    Console.WriteLine("The number is odd");
                }

            }catch(FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }
}
