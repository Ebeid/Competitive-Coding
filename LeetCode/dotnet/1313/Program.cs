using System;
using System.Collections.Generic;

namespace _1313
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(int i in DecompressRLElist(new int[]{1,2,3,4}))
                Console.Write(i);
        }
        public static int[] DecompressRLElist(int[] nums)
        {
            List<int> decoded = new List<int>();
            for (int i = 0; i < nums.Length; i = i + 2)
            {
                for (int j = 0; j < nums[i]; j++)
                    decoded.Add(nums[i + 1]);
            }
            return decoded.ToArray();
        }
    }
}
