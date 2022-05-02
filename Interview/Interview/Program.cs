using System;
using System.Collections.Generic;
using System.Linq;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             6.	Check if parentheses are balanced
                a.	(a+b) => Balance
                b.	(a+ b => unbalance
                c.	([a+b]*c) => balance
                d.	{}[]({}) balance

             */

            var inputString = "{}[]({})";
            Tuple<char, char> character12 = new Tuple<char, char>('(', ')');
            Tuple<char, char> characterab = new Tuple<char, char>('{', '}');
            Tuple<char, char> characterxy = new Tuple<char, char>('[', ']');

            // Check input string is null or empty
            if (string.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine("Input string is null.");
            }

            // Convert input string in input array
            char[] inputArray = inputString.ToCharArray();

            // Loop array 
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                var charI = inputArray[i];
                var j = i + 1;
                var charJ = inputArray[j];
                var count1 = 0;
                var count2 = 0;

                var counta = 0;
                var countb = 0;

                var countx = 0;
                var county = 0;

                if (charI == character12.Item1)
                {
                    count1 = AddDictionaryWithChar(dict, count1, character12.Item1);
                }
                if (charJ == character12.Item2)
                {
                    count2 = AddDictionaryWithChar(dict, count2, character12.Item2);
                }

                if (charJ == characterab.Item1)
                {
                    counta = AddDictionaryWithChar(dict, counta, characterab.Item1);
                }
                if (charJ == characterab.Item2)
                {
                    countb = AddDictionaryWithChar(dict, countb, characterab.Item2);
                }

                if (charJ == characterxy.Item1)
                {
                    countx = AddDictionaryWithChar(dict, countx, characterxy.Item1);
                }
                if (charJ == characterxy.Item2)
                {
                    county = AddDictionaryWithChar(dict, county, characterxy.Item2);
                }
            }

            dict.TryGetValue(character12.Item1, out int countCharacter1);
            dict.TryGetValue(character12.Item2, out int countCharacter2);

            dict.TryGetValue(characterab.Item1, out int countCharactera);
            dict.TryGetValue(characterab.Item2, out int countCharacterb);

            dict.TryGetValue(characterxy.Item1, out int countCharacterx);
            dict.TryGetValue(characterxy.Item2, out int countCharactery);

            if (countCharacter1 == countCharacter2 && countCharactera == countCharactera && countCharacterx == countCharacterx)
            {
                Console.WriteLine("Output: Balance");
            }
            else
            {
                Console.WriteLine("Output: unbalance");
            }

            Console.ReadKey();
        }
        public static int AddDictionaryWithChar(Dictionary<char, int>  dict, int count, char character)
        {
            count++;
            if (dict.ContainsKey(character))
            {
                dict[character] = count;
            }
            else
            {
                dict.Add(character, count);
            }

            return count;
        }
    }
}
