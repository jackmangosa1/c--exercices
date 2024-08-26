using InputValidationLibrary;
namespace LeapYearChecker
{
    public class Program
    {
        static void Main(string[] args)
        {
            int year;


            Console.Write("Enter a year:");
            while (!InputValidator.ValidateInt(Console.ReadLine(), out year))
            {
                Console.Write("Invalid input. Please enter a valid year.");
                Console.Write("Enter a year: ");
            }


            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("The year is a leap year.");
            }
            else
            {
                Console.WriteLine("The year is not a leap year.");
            }
        }
    }
}
