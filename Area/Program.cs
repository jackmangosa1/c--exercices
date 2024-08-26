using InputValidationLibrary;

namespace Area
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the length of the rectangle: ");
                string lengthInput = Console.ReadLine();
                if (!InputValidator.ValidateDouble(lengthInput, out double length))
                {
                    throw new FormatException("Invalid length. Please enter a valid number.");
                }

                Console.WriteLine("Enter the width of the rectangle: ");
                string widthInput = Console.ReadLine();
                if (!InputValidator.ValidateDouble(widthInput, out double width))
                {
                    throw new FormatException("Invalid width. Please enter a valid number.");
                }

                double area = length * width;
                Console.WriteLine("The area of the rectangle is: " + area);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
