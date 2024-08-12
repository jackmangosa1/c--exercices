namespace FirstAndLastDigitFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number:");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());
            int lastDigit = enteredNumber % 10;
            int firstDigit = enteredNumber;
            while (firstDigit >= 10)
            {
                firstDigit /= 10;
            }
            Console.WriteLine($"First digit is {firstDigit}");
            Console.WriteLine($"Last digit is {lastDigit}");
        }

       
    }
}
