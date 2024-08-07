namespace LearYearChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) { 
                Console.WriteLine("The year is a leap year");
            }
            else
            {
                Console.WriteLine("The year is not a leap year");
            }
        }
    }
}
