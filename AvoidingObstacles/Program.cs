//You are given an array of integers representing coordinates of obstacles situated on a straight line.
//Assume that you are jumping from the point with coordinate 0 to the right.You are allowed only to make jumps of the same length represented by some integer.
//Find the minimal length of the jump enough to avoid all the obstacles.

using System;

namespace AvoidingObstacles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 5, 3, 6, 7, 9 };
            Array.Sort(inputArray);
            //foreach (int i in inputArray)
            //{
            //    Console.WriteLine(i);
            //}
            Console.WriteLine(AvoidObstacles(inputArray));
        }

        static int AvoidObstacles(int[] inputArray)
        {
            int jump = 2;
            bool isMinJump = false;
            while (!isMinJump)
            {
                isMinJump = true;
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] % jump == 0)
                    {
                        jump++;
                        isMinJump = false;
                        break;
                    }
                }
            }
            return jump;
        }
    }
}
