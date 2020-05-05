using System;

namespace _0053
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { -2,1,-3,4,-1,2,1,-5,4 };
            int actualOutput = maximumSumSubarrayBruteForce(input);
            Console.WriteLine(actualOutput);
        }

        public static int maximumSumSubarrayBruteForce(int[] a)
        {
            if (a == null || a.Length == 0)
                throw new ArgumentException("Input array is empty or null");
            int maxSum = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < a.Length; j++)
                {
                    sum = sum + a[j];
                    maxSum = Math.Max(maxSum, sum);
                }
            }
            return maxSum;
        }
        // Kadane's algorithm solution
        public static int maximumSumSubarray(int[] a)
        {
            if (a == null || a.Length == 0)
                throw new ArgumentException("Input array is empty or null");
            int maxSum = a[0], maxEndingHere = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                maxEndingHere = Math.Max(maxEndingHere + a[i], a[i]);
                maxSum = Math.Max(maxSum, maxEndingHere);
            }
            return maxSum;
        }
    }
}
