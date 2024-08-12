namespace ReverseInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the integer number");
            string enteredNumber = Console.ReadLine();
            for(int i = enteredNumber.Length - 1; i >= 0; i--)
            {
                Console.Write(enteredNumber[i]);
            }

        }
    }
}
