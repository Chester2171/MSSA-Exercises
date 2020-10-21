using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Sources;

namespace Scrabble
{
    class Program
    {
        
        
        public static int scrabble(string input)
        {
            //The numbers are not the exact same as scrabble, but they are from the graphic in class.
            int score = 0;
            foreach(char letter in input)
            {
                switch(letter)
                {
                    case 'a':
                    case 'e':
                    case 'o':
                    case 's':
                    case 'r':
                    case 'i':
                    case 'l':
                    case 'n':
                    case 't':
                    case 'u':
                        score += 1;
                        break;
                    case 'd':
                    case 'g':
                        score += 2;
                        break;
                    case 'b':
                    case 'c':
                    case 'm':
                    case 'p':
                        score += 3;
                        break;
                    case 'f':
                    case 'h':
                    case 'v':
                    case 'w':
                    case 'y':
                        score += 4;
                        break;
                    case 'k':
                        score += 5;
                        break;
                    case 'j':
                    case 'x':
                        score += 8;
                        break;
                    case 'q':
                    case 'z':
                        score += 10;
                        break;
                }
            }
            return score;
        }
        public static int scrabbleTheRightWay(string input)
        {
            string word = input.ToUpper();
            int result = 0;
            Dictionary<char, int> scrabbleValues = new Dictionary<char, int>();
            scrabbleValues.Add('A', 1);
            scrabbleValues.Add('B', 3);
            scrabbleValues.Add('C', 3);
            scrabbleValues.Add('D', 2);
            scrabbleValues.Add('E', 1);
            scrabbleValues.Add('F', 4);
            scrabbleValues.Add('G', 2);
            scrabbleValues.Add('H', 4);
            scrabbleValues.Add('I', 1);
            scrabbleValues.Add('J', 8);
            scrabbleValues.Add('K', 5);
            scrabbleValues.Add('L', 1);
            scrabbleValues.Add('M', 3);
            scrabbleValues.Add('N', 1);
            scrabbleValues.Add('O', 1);
            scrabbleValues.Add('P', 3);
            scrabbleValues.Add('Q', 10);
            scrabbleValues.Add('R', 1);
            scrabbleValues.Add('S', 1);
            scrabbleValues.Add('T', 1);
            scrabbleValues.Add('U', 1);
            scrabbleValues.Add('V', 4);
            scrabbleValues.Add('W', 4);
            scrabbleValues.Add('X', 8);
            scrabbleValues.Add('Y', 4);
            scrabbleValues.Add('Z', 10);

            for (int i = 0; i < word.Length; i++)
            {
                result += scrabbleValues[word[i]];
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(scrabbleTheRightWay("mssa"));
            Console.WriteLine(scrabble("mssa"));
        }
    }
}
