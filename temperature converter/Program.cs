namespace TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the temperature in Celsius: ");
            try
            {
                double celcius = Convert.ToDouble(Console.ReadLine());
                double fahreiheit = (celcius * 1.8) + 32;
                Console.WriteLine("The temperature in fahreiheit is :" + "" + fahreiheit);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number");

            }
          

           
        
        }
    }
}
