using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayLowerTriangularMatrix
{
    internal class Program
    {
        int x;
        static void Main(string[] args)
        {
            int m, n, i, j;
            Console.Write("Enter number of Rows and columns of Matrices A and B:");
            m=Convert.ToInt32(Console.ReadLine());
            n= Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[10, 10];
            Console.Write("\n Enter The First Matrix");
            for(i=0;i<m;i++)
            {
                for(j=0;j<n;j++)
                {
                    A[i,j]= Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("\n Matrix A:");
            for(i=0;i<m; i++)
            {
                for(j=0;j<n; j++)
                {
                    Console.Write(A[i,j]+"\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("\n Setting Zero to illustrate "+"lower Triangular Matrix\n");
            for (i = 0; i < m; i++)
            {
                Console.Write("\n");
                for(j=0;j<3;j++)
                {
                    if(i>=j)
                    {
                        Console.Write(A[i,j]+"\t");
                    }
                    else 
                    {
                        Console.Write("0\t");
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
