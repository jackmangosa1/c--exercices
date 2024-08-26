using InputValidationLibrary;

namespace MonthAndYearGetter
{
    public class Program
    {
        static void Main(string[] args)
        {
            int days;


            Console.Write("Enter number of days: ");
            while (!InputValidator.ValidateInt(Console.ReadLine(), out days) || days < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid non-negative integer.");
                Console.WriteLine("Enter number of days:");
            }


            int months = days / 30;
            int years = days / 365;

            Console.WriteLine("The number of months is: " + months);
            Console.WriteLine("The number of years is: " + years);
        }
    }
}
