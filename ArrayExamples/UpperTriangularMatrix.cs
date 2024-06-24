﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    internal class UpperTriangularMatrix
    {
        static void Main()
        {
            int i, j, n;
            int[,] arr1 = new int[50, 50];

            Console.Write("\n\nDisplay the upper triangular of a given matrix :\n");
            Console.Write("Input the size of the square matrix : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input elements in the first matrix :\n");
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
                    Console.Write("{0}  ", arr1[i, j]);

                Console.Write("\n");
            }

            Console.Write("\nSetting zero in upper triangular matrix\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    if (i >= j)
                        Console.Write("{0}  ", arr1[i, j]); 
                    else
                        Console.Write("{0}  ", 0);
                }
            }

        }
    }
}
