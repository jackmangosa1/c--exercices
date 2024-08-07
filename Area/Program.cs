namespace Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the length of the rectangle: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the width of the rectangle: ");
                double width  = Convert.ToDouble(Console.ReadLine());
                double area = length * width;
                Console.WriteLine("The area of the rectangle is: " + area);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }
}
