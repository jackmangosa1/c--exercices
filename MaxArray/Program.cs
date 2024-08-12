namespace MaxArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do you want in your array");
            int numberOfElemenst = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[numberOfElemenst];
           
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Enter number {i + 1}");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = numbers[0];

            for(int i=0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {

                   max = numbers[i];
                }
               
            }
            Console.WriteLine($"The maximum number in the array is {max}");
        }
    }
}
