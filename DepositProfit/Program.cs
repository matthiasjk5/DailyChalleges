using System;

namespace DepositProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(depositProfit(100, 1, 101));
        }

        static int depositProfit(int deposit, int rate, int threshold)
        {
            int year = 0;
            double balance = deposit;
            while (balance < threshold)
            {
                balance += balance * (rate / 100d);
                Console.WriteLine(balance);
                year++;
            }

            return year;
        }

    }
}
