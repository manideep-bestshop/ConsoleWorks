using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExamples
{
    internal class _2DArray
    {
        static void Main()
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 6, 7, 8 } };
            Console.WriteLine("Legth  :"+arr.Length);
            Console.WriteLine("Rows :"+arr.GetLength(0));
            Console.WriteLine("Cols :" + arr.GetLength(0));

            for(int r=0; r<arr.GetLength(0); r++)
            {
                for(int c=0; c<arr.GetLength(1); c++)
                {
                    Console.Write(arr[r,c]+" ");
              
                }
                Console.WriteLine();
            }
        }
    }
}
