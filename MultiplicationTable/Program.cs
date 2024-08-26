namespace MultiplicationTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            int column = 1;
            int row = 1;
            while (column <= 10)
            {
                while (row <= 10)
                {
                    Console.Write($"{column * row}\t");
                    row++;
                }
                Console.WriteLine();
                row = 1;
                column++;
            }
        }
    }
}
