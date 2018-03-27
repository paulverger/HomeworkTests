using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkTests
{
    public class TestMatrixProgs
    {
        public static void TestRotateMatrixCcw()
        {
            int[,] matrix = {{ 1,2,3,4,5},{6,7,8,9,10},{11,12,13,14,15},{16,17,18,19,20},
                              {21,22,23,24,25} };
            Console.WriteLine("Initial matrix:");
            for(int i=0;i<matrix.GetLength(0);i++)
            {
                for(int j=0;j<matrix.GetLength(1);j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
                Console.Write("\n");
            }

            matrix = MatrixProgs.RotateNxNMatrixCCW(matrix);

            Console.WriteLine("Matrix after rotation:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
                Console.Write("\n");
            }
        }

        public static void TestRotate()
        {
            int[] a1 = { 1, 2, 3, 4, 5 };
            int[] a2 = { 6, 7, 8, 9, 10 };
            int[] a3 = { 11, 12, 13, 14, 15 };
            int[] a4 = { 16, 17, 18, 19, 20 };
            int[] a5 = { 21, 22, 23, 24, 25 };
            int[][] matrix = { a1, a2, a3, a4, a5 };

            Console.WriteLine("Initial matrix:");
            for(int i=0;i<matrix.Length;i++)
            {
                for(int j=0;j<matrix[i].Length;j++)
                {
                    Console.Write(" " + matrix[i][j]);
                }
                Console.Write("\n");
            }

            matrix = MatrixProgs.rotate(matrix, matrix.Length);

            Console.WriteLine("Matrix after rotation:");
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(" " + matrix[i][j]);
                }
                Console.Write("\n");
            }


        }
    }
}
