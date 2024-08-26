namespace MaxFinderMethod
{
    public class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();
            int max = program.GetMaxValueInArray(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            Console.WriteLine($"The maximum number in the array is {max}");
        }

        int GetMaxValueInArray(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
    }
}
