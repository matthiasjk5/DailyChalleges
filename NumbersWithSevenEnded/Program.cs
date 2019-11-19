using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersWithSevenEnded
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1, 2, 77, 99 };
        }

        public static List<int> DropElementsWithSeven(List<int> nums)
        {
            return nums.Where(nums => nums % 10 == 7).ToList();
        }
    }
}
