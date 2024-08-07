namespace NumberSwapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int firstNumber  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numbers before swapping:");
            Console.WriteLine("First number: " + firstNumber);
            Console.WriteLine("Second number: " + secondNumber);

            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine("Numbers after swapping:");
            Console.WriteLine("First number: " + firstNumber);
            Console.WriteLine("Second number: " + secondNumber);
        }
    }
}
