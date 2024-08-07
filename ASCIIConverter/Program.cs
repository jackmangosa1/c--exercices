namespace ASCIIConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character");
            try
            {
                char character = Convert.ToChar(Console.ReadLine());
                int ascii = Convert.ToSByte(character);
                Console.WriteLine("The ASCII value of the character is: " + ascii);
            }catch(FormatException)
            {
                Console.WriteLine("Please enter a valid character");
            }
        }
    }
}
