namespace NegativeNumberException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                checkIfNegative(number);

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    public static void checkIfNegative(int number)
        {
            if (number < 0) { 
            throw new ArgumentOutOfRangeException(nameof(number), "Negative numbers are not allowed.");
            }
        }
    }
}
