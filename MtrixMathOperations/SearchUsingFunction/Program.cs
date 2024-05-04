using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchUsingFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Number of Elements (size) of array ");
            string s = Console.ReadLine();
            int x = Int32.Parse(s);
            int[] a = new int[x];
            Console.WriteLine($"Enter {x} Array Elements :");
            for (int i = 0; i < x; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
            Array.Sort(a);
            Console.WriteLine("Sorted Array : ");
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("{0}", a[i]);
            }
            Console.WriteLine("Enter the Element to be Searched : ");
            string s3 = Console.ReadLine();
            int x2 = Int32.Parse(s3);
            int x3 = Array.BinarySearch(a, (Object)x2);
            Console.WriteLine("BinarySearch: " + x3);
            Console.WriteLine("Element {0} is {1}", x3, a[x3]);
            Console.Read();
        
    }
    }
}
