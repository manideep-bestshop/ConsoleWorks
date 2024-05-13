using System;
using System.Security.Cryptography;

namespace MatrixMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  create two matrices to addition

            int[,] MatrixA = { { 1, 2, 3 } };

            int[,] MatrixB = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            // Calculate dimensions of matrices
            int rowsOfMatrixA = MatrixA.GetLength(0);
            int colsOfMatrixA = MatrixA.GetLength(1);
            int rowsOfMatrixB=MatrixB.GetLength(0);
            int colsOfMatrixB = MatrixB.GetLength(1);

            // Check  multiplication is possible
            if (colsOfMatrixA != rowsOfMatrixB)
            {
                Console.WriteLine("multiplication is not possible. Number of columns in matrixA must be equal to the number of rows in matrix B");
                return;
            }

            // Create MatrixC 
            int[,] MatrixC = new int[rowsOfMatrixA, colsOfMatrixB];

            //  matrix multiplication
            for (int i = 0; i < rowsOfMatrixA; i++)
            {
                for (int j = 0; j < colsOfMatrixB; j++)
                {
                    for (int k = 0; k < colsOfMatrixA; k++)
                    {
                        MatrixC[i, j] += MatrixA[i, k] * MatrixB[k, j];
                    }
                }
            }


            // Print the resulting matrix C
            Console.WriteLine("Resulting Matrix C:");
            for (int i = 0; i < rowsOfMatrixA; i++)
            {
                for (int j = 0; j < colsOfMatrixB; j++)
                {
                    Console.Write(MatrixC[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
