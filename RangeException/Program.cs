namespace RangeException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < 0 || number > 1000)
                {
                    throw new ArgumentOutOfRangeException(nameof(number), "Number must be between 0 and 1000.");
                }

            } catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
