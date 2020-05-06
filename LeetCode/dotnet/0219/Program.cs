using System;
using System.Collections.Generic;

namespace _0219
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1 }, 3));
            Console.WriteLine(ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1));
            Console.WriteLine(ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1, 2, 3 }, 2));
        }

        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if((nums.Length < 2)||(k < 1))
                return false;
            HashSet<int> seen = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(!seen.Add(nums[i])) // Keep track of the last Kth seen elements
                    return true;
                if(i>=k)
                    seen.Remove(nums[i-k]); // Remove any elements furthest than K
            }
            return false;
        }
    }
}
