using System;
using Xunit;

namespace Solution.Tests
{
    public class Tests
    {
        //  ---------------------------------------- Problem 1 --------------------------------------------------
        [Fact]
        public void Problem1_Bruteforce()
        {
            int[] input = new int[] { 1, 2, -1, 2, -3, 2, -5 };
            int actualOutput = Program.maximumSumSubarrayBruteForce(input);
            int expectedOutput = 4;
            Assert.Equal(actualOutput, expectedOutput);
        }
        [Fact]
        public void Problem1_Kadane()
        {
            int[] input = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int actualOutput = Program.maximumSumSubarrayBruteForce(input);
            int expectedOutput = 6;
            Assert.Equal(actualOutput, expectedOutput);
        }
        //  ---------------------------------------- Problem 2 --------------------------------------------------
        [Fact]
        public void Problem2()
        {
            int[] input = new int[] { 1, 2, 3, 5, 2 };
            Tuple<int, int> actualOutput = Program.subarraySum(input, 8);
            Assert.Equal(actualOutput.Item1, 2);
            Assert.Equal(actualOutput.Item2, 3);
        }
        //  ---------------------------------------- Problem 3 --------------------------------------------------
        [Fact]
        public void Problem3()
        {
            Tuple<int, int> actualOutput = Program.allUnique("whatwhywhere"); //atwhy
            Assert.Equal(actualOutput.Item1, 2);
            Assert.Equal(actualOutput.Item2, 6);
        }
        //  ---------------------------------------- Problem 4 --------------------------------------------------
        [Fact]
        public void Problem4()
        {
            Tuple<int, int> actualOutput = Program.zeroSumSubarray(new int[] {2,4,-2,1,-3,5,-3});
            Assert.Equal(actualOutput.Item1, 1);
            Assert.Equal(actualOutput.Item2, 4);
        }
    }
}
