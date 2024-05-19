using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BoxingUnBoxing
{
    internal class ArrayExample
    {
        static void Main()
        {
            int[] arr = { 1, 29, 93, 4, 75, 6, 7, 38 };
            Console.WriteLine("Array Length :"+arr.Length);

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

            int[] arr1 = new int[4];
            int[] arr2 = new int[] { 1, 29 };

             foreach(int i in arr1)
            {
                Console.WriteLine(i);
            }

            foreach(int i in arr2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
