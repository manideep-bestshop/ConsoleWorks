using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExamples
{
    internal class ShallowCopy
    {
        static void Main()
        {
            int[] arr3 = { 23, 34, 56, 43, 23, 56 };
            int[] arr4 = (int[])arr3.Clone(); // clone- create new memory for arr4 in heap

            arr4[3] = 11;

            Console.WriteLine("1st Array :");
            foreach (int i in arr3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("2st Array : After clone");
            foreach (int i in arr4)
                Console.WriteLine(i);
        }
    }
}
