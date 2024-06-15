using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 23, 45, 67, 89, 34 };
            int[] arr2 = arr1; //reference copy-memory created once in Heap and arr2 work like alias for arr1

            Console.WriteLine("1st Array :");

            foreach(int i in arr1)
                Console.WriteLine(i);

            Console.WriteLine("2st Array :");

            foreach (int i in arr2)
                Console.WriteLine(i);
        }
    }
}
