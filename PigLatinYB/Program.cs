using System;

namespace PigLatinYB
{
    class Program
    {

        static void Main(string[] args)
        {
            bool keepGoing = true;
            while (keepGoing)
            {

                //user input
                Console.WriteLine("Please enter a word to translate into Pig Latin.");

                string word = Console.ReadLine().Trim().ToLower();
                Console.WriteLine(VowelWord(word));

                Console.WriteLine("Type y to continue or anything else to exit.");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    keepGoing = true;
                }else
                {
                    Console.WriteLine("Goodbye");
                    keepGoing = false;
                }
            }
        }
        //method
        public static string VowelWord(string x)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (char y in vowels)
            {
                if (x[0] == y)
                {
                    return x + "way";
                }
            }
            int firstVowel = x.IndexOfAny(vowels);
            string firstPart = x.Substring(0, firstVowel);
            string restOfWord = x.Substring(firstVowel);
            return restOfWord + firstPart + "ay";
        }
    }
}

