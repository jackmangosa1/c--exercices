namespace NumberDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.Write("Enter the first number: ");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                int secondNumber = int.Parse(Console.ReadLine());

                int division = firstNumber / secondNumber;
                Console.Write($"The division of {firstNumber} by {secondNumber} is {division}.");
            }
            catch(FormatException e)
            {
                Console.Write("Please enter a valid number.");
            }

            catch(DivideByZeroException e)
            {
                Console.Write("Cannot divide by zero.");
            }
           
           
        }
    }
}
