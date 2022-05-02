using System;
using System.Collections.Generic;
using System.Linq;

namespace CountChars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter input string: ");
            string message = Console.ReadLine();

            var preString = message.Replace(" ", string.Empty);
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char ch in preString)
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch] = dict[ch] + 1;
                }
                else
                {
                    dict.Add(ch, 1);
                }
            }
            var output = dict.OrderByDescending(x => x.Value).First().Key;
            Console.WriteLine("Output: " + output);

            foreach (var item in dict.Keys)
            {
                Console.WriteLine(item + ": " + dict[item]);
            }
            Console.ReadKey();
        }
    }
}
