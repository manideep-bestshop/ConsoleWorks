using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    internal class SumOfRowsColumns
    {
        static void Main()
        {
            int i, j, n;
            int[,] arr1 = new int[10, 10]; 
            int[] rsum = new int[10]; 
            int[] csum = new int[10]; 

            Console.Write("\n\nFind sum of row and column of a Matrix:\n");
         
            Console.Write("Input the size of the square matrix : ");
            n = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine()); 
                }
            }

            Console.Write("The matrix is :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}  ", arr1[i, j]); 
                }
                Console.Write("\n");
            }

            for (i = 0; i < n; i++)
            {
                rsum[i] = 0; 
                for (j = 0; j < n; j++)
                {
                    rsum[i] += arr1[i, j]; 
                }
            }

            
            for (i = 0; i < n; i++)
            {
                csum[i] = 0; 
                for (j = 0; j < n; j++)
                {
                    csum[i] += arr1[j, i];
                }
            }

            Console.Write("The sum of row and column of the matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}    ", arr1[i, j]); 
                }
                Console.Write("{0}    ", rsum[i]); 
                Console.Write("\n");
            }

            
            for (j = 0; j < n; j++)
            {
                Console.Write("{0}   ", csum[j]);
            }
            Console.Write("\n\n");
        }
    }
}
