using System;
using System.Collections;
using System.Collections.Generic;
namespace _0001
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = TwoSum(nums, target);
            foreach (int i in result)
                Console.WriteLine(i);

            Console.ReadLine();
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            ArrayList result = new ArrayList();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if ((i != j) && (nums[i] + nums[j] == target))
                    {
                        if (!result.Contains(i) && !result.Contains(j))
                        {
                            result.Add(i);
                            result.Add(j);
                        }
                    }
                }
            }
            return (int[])result.ToArray(typeof(int));
        }
    }
}
