﻿using System;

namespace countTriangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        int depositProfit(int deposit, int rate, int threshold)
        {
            int year = 0;
            double balance = deposit;
            while (balance > threshold)
            {
                balance += balance * 0.2;
                year++;
                Console.WriteLine(balance);
            }

            return year;
        }

    }


}
