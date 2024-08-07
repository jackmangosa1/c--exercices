namespace MonthAndYearGetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter number of days:");
                int days = Convert.ToInt32((Console.ReadLine()));
                int months = days / 30;
                int years = days / 365;

                Console.WriteLine("The number of months is: " + months);
                Console.WriteLine("The number of years is: " + years);

            }catch(FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }
}
