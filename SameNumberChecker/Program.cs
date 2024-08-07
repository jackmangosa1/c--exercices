namespace SameNumberChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first number");
                int firstNumber  = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the third number");
                int thirdNumber = Convert.ToInt32(Console.ReadLine());

                if(firstNumber == secondNumber && secondNumber == thirdNumber)
                {
                    Console.WriteLine("Numbers are the same");
                }
                else
                {
                    Console.WriteLine("Numbers are not the same");
                }

            }catch(FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }
}
