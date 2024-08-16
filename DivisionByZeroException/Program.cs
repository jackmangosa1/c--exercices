namespace DivisionByZeroException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the first number: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second number: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                int division = firstNumber / secondNumber;
                Console.WriteLine($"The division of {firstNumber} by {secondNumber} is {division}");
            }
            catch (DivideByZeroException ) 
            { 
            Console.WriteLine("Cannot divide by zero");
           
            }

      
        }
    }
}
