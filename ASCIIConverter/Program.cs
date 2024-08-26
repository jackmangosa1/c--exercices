using InputValidationLibrary;

namespace ASCIIConverter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            string input = Console.ReadLine();

            if (InputValidator.ValidateChar(input, out char character))
            {
                int ascii = Convert.ToInt32(character);
                Console.WriteLine("The ASCII value of the character is: " + ascii);
            }
            else
            {
                Console.WriteLine("Please enter a valid character");
            }
        }
    }
}
