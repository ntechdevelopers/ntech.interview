using System;

namespace SumLargeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number 1: ");
            string number1 = Console.ReadLine();
            Console.WriteLine("Input number 2: ");
            string number2 = Console.ReadLine();

            // Check maxLength 2 string
            int maxLength = number1.Length > number2.Length 
                                    ? number1.Length + 1 
                                    : number2.Length + 1;

            // Convert input to array integer
            int[] arrayNumber1 = ConvertToArrayInt(number1, maxLength);
            int[] arrayNumber2 = ConvertToArrayInt(number2, maxLength);

            int[] outputArrayNumber = new int[maxLength];
            int div = 0;
            int outputNumber = 0;
            for (int i = maxLength - 1; i >= 0; i--)
	        {
                outputNumber = arrayNumber1[i] + arrayNumber2[i] + div;
                outputArrayNumber[i] = outputNumber % 10;
                div = outputNumber / 10;
            }

            Console.WriteLine(string.Format("number1 : {0}", string.Join(string.Empty, arrayNumber1)));
            Console.WriteLine("+");
            Console.WriteLine(string.Format("number2 : {0}", string.Join(string.Empty, arrayNumber2)));
            Console.WriteLine("=");
            Console.WriteLine(string.Format("Result  : {0}", string.Join(string.Empty, outputArrayNumber)));

            Console.ReadLine();
        }

        static int[] ConvertToArrayInt(string inputString, int maxLength)
        {
            int[] arrayInt = new int[maxLength];
            for (int i = 0; i < inputString.Length; i++) 
            {
                arrayInt[maxLength - inputString.Length + i] = int.Parse(inputString[i].ToString());
            }
            return arrayInt;
        }
    }
}
