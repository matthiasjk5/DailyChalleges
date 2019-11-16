using System;

namespace divNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(divNumber(3, 2, 49));
        }

        static int divNumber(int k, int l, int r)
        {
            int count = 0;
            for (int i = l; i <= r; i++)
            {
                int noDivisor = 0;
                for (int j = 1; j <= i; j++)
                {
                    if ((i % j) == 0)
                    {
                        noDivisor++;
                    }
                }

                if (noDivisor == k)
                {
                    count++;
                }
            }

            return count;
        }

    }
}
