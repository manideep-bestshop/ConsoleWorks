using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExamples
{
    internal class DeepCopy
    {
        static void Main()
        {
            int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] numbers2 = new int [ numbers1.Length ];

            numbers1.CopyTo(numbers2, 0); //Deep Copy-
            numbers2[2] = 44;

            Console.WriteLine("1st Array :");
            foreach (int i in numbers1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("2st Array : After clone");
            foreach (int i in numbers2)
                Console.WriteLine(i);


        }
    }
}
