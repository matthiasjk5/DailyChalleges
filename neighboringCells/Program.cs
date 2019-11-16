//Given a rectangular matrix consisting of zeroes, replace each zero with the number of neighboring cells for that cell.
//Example
//For
//matrix = [[0, 0, 0],
//          [0, 0, 0],
//          [0, 0, 0]]
//the output should be
//neighboringCells(matrix) = [[2, 3, 2],
//                            [3, 4, 3],
//                            [2, 3, 2]]
using System;

namespace neighboringCells
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] matrix = new int[3, 3];
            int[][] matrix = new int[1][];
            int[,] matrix2 = new int[3, 4];
            matrix[0] = new int[5];
            Console.WriteLine(matrix.Length);
            Console.WriteLine(matrix2.Length);
            //int[,] matrix = new int[3, 4];
            //neighboringCells(matrix);
            //Console.WriteLine(matrix.GetLength(0));

        }

        static int[][] neighboringCells(int[][] matrix)
        {
            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                int count = 0; // how many neighbors does each cell have?

                if (i - 1 >= 0) count++;
                if (i + 1 < row) count++;

                for (int j = 0; j < column; j++)
                {
                    if (j - 1 >= 0) count++;
                    if (j + 1 < column) count++;

                    matrix[i][j] = count;
                }
            }
            return matrix;
        }

    }
}
