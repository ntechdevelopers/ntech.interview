using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeAndOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 2, 5, 7, 9 };
            int[] array2 = new int[] { 0, 1, 3, 4, 6, 8 };
            int[] arrayResult = new int[array1.Length + array2.Length];

            //index for result
            int n = 0;
            //index for array1
            int i = 0;
            //index for array2
            int j = 0;

            //until any one of arrays all elements are traversed
            while (i < array1.Length && j < array2.Length)
            {
                //comparing items of array1 and array2
                if (array1[i] < array2[j])
                {
                    //inserting array1 item since it is lower
                    arrayResult[n] = array1[i];
                    //incrementing i, because array1's item is traversed
                    i++;
                }
                else
                {
                    arrayResult[n] = array2[j];
                    j++;
                }
                //incrementing since one item has been inserted to result array
                n++;
            }
            //if any elements are left in array1, simply inserting all to result
            while (i < array1.Length)
            {
                arrayResult[n] = array1[i];
                i++;
                n++;
            }
            //if any elements are left in array2, simply inserting all to result
            while (j < array2.Length)
            {
                arrayResult[n] = array2[j];
                j++;
                n++;
            }

            //var arrayResult = array1.Union(array2).OrderBy(i => i);

            Console.WriteLine("Output: " + string.Join(",", arrayResult));
            Console.ReadKey();
        }
    }
}
