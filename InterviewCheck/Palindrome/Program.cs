using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString, reverseString = string.Empty;
            Console.Write("Enter input string: ");
            inputString = Console.ReadLine();

            if (inputString != null)
            {
                // Convert reverse input string
                for (int i = inputString.Length - 1; i >= 0; i--)
                {
                    reverseString += inputString[i].ToString();
                }

                // Compare 2 string
                if (reverseString == inputString)
                {
                    Console.WriteLine("String is Palindrome Input = {0} and Output= {1}", inputString, reverseString);
                }
                else
                {
                    Console.WriteLine("String is not Palindrome Input = {0} and Output= {1}", inputString, reverseString);
                }
            }

            Console.ReadLine();
        }
    }
}
