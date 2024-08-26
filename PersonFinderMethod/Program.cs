namespace PersonFinderMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.GetPerson("John", "Doe", 1980);


        }

        public void GetPerson(string firstName, string lastName, int yearOfBirth)
        {
            int cuurentYear = DateTime.Now.Year;
            int age = cuurentYear - yearOfBirth;
            Console.Write($"{firstName} {lastName} {age} years old");
        }
    }
}
