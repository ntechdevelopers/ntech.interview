using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter input string: ");
            string inputString = Console.ReadLine();

            // Check input empty
            if (string.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine($"Input string is null.");
            }

            // Way 1:
            //string reverseString = string.Empty;
            //for (int i = inputString.Length - 1; i >= 0; i--)
            //{
            //    reverseString += inputString[i];
            //}

            // Way 2:
            char[] inputArray = inputString.ToCharArray();
            Array.Reverse(inputArray);
            string reverseString = new string(inputArray);


            Console.WriteLine($"Output reverse string {inputString} is: {reverseString}");
            Console.ReadKey();
        }
    }
}
