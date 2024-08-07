namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication app");
            Console.WriteLine("Enter the first number");
            int firstNumber = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter the second nuber");
            int secondNumber = Convert.ToInt32( Console.ReadLine());
            int result = firstNumber * secondNumber;
            Console.WriteLine("The result is: " + result);

        }
    }
}
