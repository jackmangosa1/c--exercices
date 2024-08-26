namespace PasswordChecker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a password");
            string password = Console.ReadLine();
            string savedPassword = "s3cr3t!p@ssw0rd";
            if (password == savedPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
    }
}
