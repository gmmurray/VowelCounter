using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelCounter
{
    class VowelCounter
    {
        static void Main(string[] args)
        {
            string userInput = null;
            bool run = true;

            WriteLine("Enter word to be checked for vowels. Type \"exit\" to exit program.");
            while (run)
            {
                userInput = ReadLine();
                if (userInput == "exit")
                {
                    run = false;
                }
                else
                {
                    char[] inputArr = userInput.ToArray();
                    CheckVowels(inputArr, userInput);
                }
            }
        }

        public static void CheckVowels(char[] inputArray, string userString)
        {
            int numVowels = 0;
            string vowelsFound = null;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (IsVowel(inputArray[i]))
                {
                    numVowels++;
                    vowelsFound += inputArray[i];
                }
            }

            if (numVowels == 1)
            {
                WriteLine("The word {0} contains {1} vowel: {2}",  userString, numVowels, vowelsFound);
            }
            else
            {
                WriteLine("The word {0} contains {1} vowels: {2}", userString, numVowels, vowelsFound);
            }
        }

        public static bool IsVowel(char letter)
        {
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'y')
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
