namespace StringToIntegerException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.Write("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"The converted string is {number} ");
            }
            catch (FormatException ex) { 
                Console.WriteLine("Invalid input please enter a valid integer");
            }
        }
    }
}
