using InputValidationLibrary;

namespace NumberToLetter
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number;


            Console.Write("Enter a number:");
            while (!InputValidator.ValidateInt(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write("Enter a number:");
            }


            switch (number)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("Number too big");
                    break;
            }
        }
    }
}
