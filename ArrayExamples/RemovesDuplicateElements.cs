using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    internal class RemovesDuplicateElements
    {
        static void Main()
        {
            object[] mixedArray = new object[8];
            mixedArray[0] = 25;
            mixedArray[1] = "mani";
            mixedArray[2] = false;
            mixedArray[3] = 25;
            mixedArray[4] = System.DateTime.Now;
            mixedArray[5] = 112.22;
            mixedArray[6] = "mani";
            mixedArray[7] = false;

            Console.WriteLine("Original array elements:");
            for (int i = 0; i < mixedArray.Length; i++)
            {
                Console.WriteLine(mixedArray[i]);
            }

            object[] result = test(mixedArray);

            Console.WriteLine("\nAfter removing duplicate elements from the said array:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        public static object[] test(object[] mixedArray)
        {
            return mixedArray.Distinct().ToArray();
        }
    }
    
}
