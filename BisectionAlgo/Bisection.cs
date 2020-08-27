using System;
using System.Collections.Generic;
using System.Text;

namespace BisectionAlgo
{
    public class Bisection
    {
        public static void initiateBisection()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int search = 0;
            Console.WriteLine("Enter the number you would like to search: ");
            try
            {
                search = Convert.ToInt32(Console.ReadLine());
                if (search < 1 || search > 10)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a number between 1 and 10");
                initiateBisection();
            }
            bisection(search, array);

        }
        public static void bisection(int number, int[] arr)
        {
            int[] newArray;
            if (number == arr[(arr.Length - 1) / 2])
            {
                Console.WriteLine($" The " +
               $"computer says your number was {number}\n");
            }

            else if (number > arr[(arr.Length - 1) / 2])
            {
                newArray = new int[arr.Length / 2];

                int index = 0;
                for (int i = ((arr.Length - 1) / 2) + 1; i < arr.Length; i++)
                {
                    newArray[index] = arr[i];
                    index++;
                }

                Console.WriteLine($"The new array is {string.Join(", ", newArray)} since {number} is greater " +
                    $"than the {arr[(arr.Length - 1) / 2]} ");

                bisection(number, newArray);
            }
            else if (number < arr[(arr.Length - 1) / 2])
            {
                newArray = new int[(arr.Length - 1) / 2];
                int index = 0;
                for (int i = 0; i < (arr.Length - 1) / 2; i++)
                {
                    newArray[index] = arr[i];
                    index++;
                }

                Console.WriteLine($"The new array is {string.Join(", ", newArray)} since {number} is less than  " +
                    $"than the {arr[(arr.Length - 1) / 2]}");

                bisection(number, newArray);

            }
        }
    }
}
