using System;
using System.Linq;

namespace Inteview2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             4.	How to check if two Strings (words) are Anagrams?
            a.	Two words are anagrams of each other if they contain the same number of characters and the same characters. 
            EX:  
            i.	race, care
            ii.	knee, keen
             */
            string inputString1 = null;
            string inputString2 = null;

            Function(inputString1, inputString2);

            Console.ReadLine();
        }

        private static void Function(string inputString1, string inputString2)
        {
            var array1 = inputString1?.ToCharArray()?.ToList();
            var array2 = inputString2?.ToCharArray()?.ToList();
            var count1 = array1?.Count() ?? 0;
            var count2 = array2?.Count() ?? 0;

            if (count1 != count2)
            {
                Console.WriteLine("Output: " + false);
                return;
            }

            if (count1 == 0 && count2 == 0)
            {
                Console.WriteLine("Output: " + true);
                return;
            }

            array1.Sort();
            array2.Sort();

            var output = true;
            for (int i = 0; i < array1.Count(); i++)
            {
                if (array1[i] != array2[i])
                {
                    output = false;
                    break;
                }
            }

            Console.WriteLine("Output: " + output);
        }
    }
}
