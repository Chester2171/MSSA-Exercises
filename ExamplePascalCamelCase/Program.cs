using System;

namespace Whiteborad
{
    class Program
    {
        public static string CamelCase(string[] input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i].ToLower();
                for (int j = 0; j < input[i].Length; j++)
                {
                    if((input[i][j] < 'a' || input[i][j] > 'z') && input[i][j] != ' ')
                    {
                        continue;
                    }
                    while(input[i][j] == ' ')
                    {
                        j++;
                        if(input[i][j] < 'a' || input[i][j] > 'z')
                        {
                            result += Char.ToUpper(input[i][j + 1]);
                        }
                    }
                    if (j == 0 && i != 0)
                    {
                        result += Char.ToUpper(input[i][0]);
                    }
                    else
                    {
                        result += input[i][j];
                    }
                }
            }
            return result;
        }
        public static string PascalCase(string[] input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i].ToLower();
                for (int j = 0; j < input[i].Length; j++)
                {
                    if (input[i][j] < 'a' || input[i][j] > 'z')
                    {
                        continue;
                    }
                    if (j == 0)
                    {
                        result += Char.ToUpper(input[i][0]);
                    }
                    else
                    {
                        result += input[i][j];
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CamelCase(new string[] { "hello", "RichaRd", "HOW", "aR!E", "yOu" }));
            Console.WriteLine(PascalCase(new string[] { "hello", "RichaRd", "HOW", "aR!E", "yOu" }));
        }
    }
}
