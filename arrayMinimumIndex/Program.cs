using System;

namespace arrayMinimumIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int arrayMinimumIndex(int[] inputArray)
        {
            int tempValue = int.MaxValue;
            int tempIndex = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] <= tempValue)
                {
                    tempValue = inputArray[i];
                    tempIndex = i;
                }
            }

            return tempIndex;
        }

    }
}
