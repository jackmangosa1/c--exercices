namespace LessThenEvenNumberGetter
{
    public class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();
            int[] evenNumbers = program.GetLessThenEvenNumber(10);
            foreach (int number in evenNumbers)
            {
                Console.Write($"{number} ");
            }
        }

        int[] GetLessThenEvenNumber(int number)
        {
            int evenNumberCount = number / 2;
            int[] evenNumbers = new int[evenNumberCount];
            int index = 0;

            for (int i = 1; i < number; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers[index++] = i;

                }
            }

            return evenNumbers;
        }
    }
}
