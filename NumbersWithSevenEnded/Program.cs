using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersWithSevenEnded
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = DropElementsWithSeven(new List<int>() { 1, 2, 77, 99 });
            
            foreach(int n in nums)
            {
                Console.WriteLine(n);
            }
            
            
        }

        static List<int> DropElementsWithSeven(List<int> nums)
        {
            return nums.Where(nums => nums % 10 == 7).ToList();
        }
    }
}
