using System;

namespace BubbleSort
{
    class Program
    {
        public static int[] BubbleSort(int[] input)
        {
            
            for (int i = 0; i < input.Length; i++) //this is only to ensure that the loop runs until completion.
            {
                for (int j = 0; j < input.Length - 1; j++) //this is how we compare the values against each other and swap them.
                {
                    if (input[j] > input[j+1])
                    {
                        int temp = input[j+1]; // be sure to create a temp value or you will change your numbers and lose the previous number.
                        input[j+1] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;
        }
        
        
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 6, 1, 7, 3, 4, 9, 2, 5, 8 };
            Console.WriteLine(string.Join(", ", BubbleSort(array)));
        }
    }
}
