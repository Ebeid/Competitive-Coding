using System;
using System.Collections.Generic;
using System.Collections;

namespace _0697
{
    class Program
    {
        static void Main(string[] args)
        {
            FindShortestSubArray(new int[] {1,2,2,3,1,4,2}); // 6
            FindShortestSubArray(new int[] {1,1}); // 2
            FindShortestSubArray(new int[] {1,2,1}); // 3
        }

        public static int FindShortestSubArray(int[] nums)
        {
            if(nums.Length == 1)
                return 1;
            Dictionary<int, int> frequencies = new Dictionary<int, int>();
            Dictionary<int, int> ends = new Dictionary<int, int>();
            int maxFrequency = 0;
            int maxFrequencyItem = nums[0];
            int minLength = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!frequencies.ContainsKey(nums[i]))
                {
                    frequencies.Add(nums[i], 1);
                    ends.Add(nums[i], i);
                    if(i == 0)
                        ends[nums[i]]++;
                }
                else
                {
                    frequencies[nums[i]]++;
                    if (frequencies[nums[i]] > maxFrequency){
                        maxFrequency = frequencies[nums[i]];
                        maxFrequencyItem = nums[i];
                    }
                    ends[nums[i]] = i;
                }
            }
            minLength = (frequencies.Keys.Count == 1) ? nums.Length : ends[maxFrequencyItem];
            printDictionary(frequencies);
            Console.WriteLine("-----");
            printDictionary(ends);
            Console.WriteLine(minLength);
            return minLength;
        }
        public static void printDictionary(Dictionary<int, int> a)
        {
            foreach (KeyValuePair<int, int> p in a)
                Console.WriteLine(p.Key + " - " + p.Value);
        }
    }
}
