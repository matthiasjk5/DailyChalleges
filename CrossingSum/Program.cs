//Given a rectangular matrix and integers a and b, consider the union of the ath row and the bth(both 0-based) column of the matrix(i.e.all cells that belong either to the ath row or to the bth column, or to both). Return sum of all elements of that union.

using System;

namespace CrossingSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[][] {
                new int[] { 1, 1, 1, 1 },
                new int[] { 2, 2, 2, 2, },
                new int[] { 3, 3, 3, 3 }
            };

            //Console.WriteLine("GetLength(0): " + matrix.GetLength(0));
            //Console.WriteLine("GetLength(1): " + matrix.GetLength(1));
            Console.WriteLine(crossingSum(matrix, 1, 3));

        }

        static int crossingSum(int[][] matrix, int a, int b)
        {
            int result = 0;
            //sum values in row[a]
            for (int i = 0; i < matrix[0].Length; i++)
            {
                result += matrix[a][i];
            }

            // sum values in column[b]
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                result += matrix[i][b];
            }

            //subtract intersect value in matrix array
            result = result - matrix[a][b];

            return result;
        }

    }
}
