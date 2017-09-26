using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            bool goAgain = true;
            while (goAgain == true)
            {
                    Console.WriteLine("Enter a word to be translated");
                    string word = Console.ReadLine();
                    word = word.ToLower();
                    char space = ' ';
                    string[] translatedWords = word.Split(space);
                    for (int i = 0; i < translatedWords.Length; i++)
                    {
                        int parseHere = RangeOfVowel(translatedWords[i]);
                        if (translatedWords[i] == "")
                        {
                            Console.WriteLine("Text was not entered");
                        }
                        if (parseHere == 0)
                        {
                            Console.Write(translatedWords[i] + "way ");
                        }
                        else if (parseHere < 0)
                        {
                            Console.Write(translatedWords[i]);
                        }
                        else
                        {
                            string replacedLetters = translatedWords[i].Substring(0, parseHere);
                            Console.Write(translatedWords[i].Substring(parseHere) + replacedLetters + "ay ");
                        }

                    }
                    Console.WriteLine();
                    goAgain = DoAgain();
            }
        }

        
        public static int RangeOfVowel(string input)
        {
            int indexLocation;
            if (input.Contains("a") == true)
            {
                indexLocation = input.IndexOf("a");

                return indexLocation;

            }
            if (input.Contains("e") == true)
            {
                indexLocation = input.IndexOf("e");
                return indexLocation;

            }
            if (input.Contains("i") == true)
            {
                indexLocation = input.IndexOf("i");
                return indexLocation;

            }
            if (input.Contains("o") == true)
            {
                indexLocation = input.IndexOf("o");
                return indexLocation;

            }
            else
            {
                indexLocation = input.IndexOf("u");
                return indexLocation;

            }

        }
        public static bool DoAgain()
        {
            string repeat;
            Console.WriteLine("Continue? Y or N");
            repeat = Console.ReadLine();
            repeat = repeat.ToLower();
            bool goAgain;
            if (repeat == "y")
            {
                goAgain = true;
            }
            else if (repeat == "n")
            {
                goAgain = false;
            }
            else
            {
                Console.WriteLine("Sorry not an accurate input");
                goAgain = DoAgain();
            }
            return goAgain;
        }
        
    }
}

