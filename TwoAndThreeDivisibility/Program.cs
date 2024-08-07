namespace TwoAndThreeDivisibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number");
                int number  = Convert.ToInt32(Console.ReadLine());
                if(number % 2 == 0 && number % 3 == 0)
                {
                    int mutiplication = 2 * 3;
                    Console.WriteLine("The multiplication of 2 and 3 is:" + " " + mutiplication );
                }
                else
                {
                    int addition = 2 + 3;
                    Console.WriteLine("The addition of 2 and 3 is:" + " " + addition);
                }

            }catch(FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }
}
