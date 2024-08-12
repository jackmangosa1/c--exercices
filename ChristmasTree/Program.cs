namespace ChristmasTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char star = '*';
            char space = ' ';
            int height = 4;
            int width = height * 2 - 1;
           for (int i = 1; i <= height; i++)
                {
                    for (int j = 1; j <= width; j++)
                    {
                        if (j >= height - i + 1 && j <= height + i - 1)
                        {
                            Console.Write(star);
                        }
                        else
                        {
                            Console.Write(space);
                        }
                    }
                    Console.WriteLine();
                }
        }
    }
}
