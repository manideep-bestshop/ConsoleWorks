using System;

namespace MtrixMathOperations
{
    internal class Program
    {
        
        static void Main(string[] args)
            {
                //  create two matrices to addition

                int[,] MatrixA = { { 1, 2, 3},{ 4,5,6} };

                int[,] MatrixB = { { 1, 2, 3 },{ 4 , 5, 6 } };

                 int rows=MatrixA.GetLength(0);
                 int cols=MatrixA.GetLength(1);

                 int[,] MatrixC = new int[rows, cols];

                //Matrix addition

                for (int i = 0; i < MatrixA.GetLength(0); i++)
                {
                    for (int j = 0; j < MatrixB.GetLength(1); j++)
                    {
                        MatrixC[i, j] = MatrixA[i, j] + MatrixB[i, j];
                    }
                }

            Console.WriteLine("Diplaying MatrixA");
            PrintMatrices(MatrixA);

            Console.WriteLine("Displaying MatrixB");
            PrintMatrices(MatrixB);

            Console.WriteLine("After Addition: Displaying MatrixC");
            PrintMatrices(MatrixC);
        }
        static void PrintMatrices(int[,] matrix)
        {
            int rows=matrix.GetLength(0);
            int cols=matrix.GetLength(1);

            for(int i = 0;i < rows;i++)
            {
                for(int j = 0;j < cols;j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        }

    }

