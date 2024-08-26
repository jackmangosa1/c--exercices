namespace StringMixerMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            ;
            Program program = new Program();
            string result = program.MixStrings("aaa", "BBB");
            Console.WriteLine(result);


        }

        string MixStrings(string str1, string str2)
        {
            int maxLength = Math.Max(str1.Length, str2.Length);
            char[] result = new char[str1.Length + str2.Length];

            int index = 0;
            for (int i = 0; i < maxLength; i++)
            {
                if (i < str1.Length)
                {
                    result[index++] = str1[i];
                }
                if (i < str2.Length)
                {
                    result[index++] = str2[i];
                }
            }

            return new string(result);
        }
    }
}
