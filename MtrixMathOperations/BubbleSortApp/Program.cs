using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = {3, 4, 2, 5, 1};
            int t;
            Console.WriteLine("The Array is:");
            for(int i=0; i<a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            for(int j=0;j<=a.Length-2; j++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }

                }
            }
            Console.WriteLine("The sorted Array:");
            foreach(int array in a)
            {
                Console.Write(array+"");
                Console.WriteLine();
            }
        }
        }
    }
