namespace PersonFinderMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            getPerson("John", "Doe", 1980);
        }

        static void getPerson(string firstName, string lastName, int yearOfBirth)
        {
            int cuurentYear = DateTime.Now.Year;
            int age = cuurentYear - yearOfBirth;
            Console.Write($"{firstName} {lastName} {age} years old");
        }
    }
}
