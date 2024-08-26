namespace OddNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 0; i <= 500; i++)
            {
                if (i % 2 != 0)
                {

                    Console.Write($"{i}\t");
                    count++;
                    if (count >= 10)
                    {
                        Console.WriteLine();
                        count = 0;
                    }


                }
            }
        }
    }
}
