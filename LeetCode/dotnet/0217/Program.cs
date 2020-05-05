using System;
using System.Collections.Generic;

namespace _0217
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContainsDuplicate(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(ContainsDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));
        }
        public static bool ContainsDuplicate(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; ++i)
            {
                if (nums[i] == nums[i + 1]) return true;
            }
            return false;
        }
    }
}
