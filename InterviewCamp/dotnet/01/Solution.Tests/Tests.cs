using System;
using Xunit;

namespace Solution.Tests
{
    public class Tests
    {
        //  ---------------------------------------- Problem 1 --------------------------------------------------
        [Fact]
        public void WhenEmptySlotsEqualNeedSlots_ShouldSucceed_1()
        {
            int[] input = new int[] { 1, 2, 5, 6, 8, -1, -1, -1 };
            int[] actualOutput = Program.cloneEvenNumbers_1(input);
            int[] expectedOutput = new int[] { 1, 2, 2, 5, 6, 6, 8, 8 };

            for (int i = 0; i < input.Length; i++)
            {
                Assert.Equal(actualOutput[i], expectedOutput[i]);
            }
        }
        /*
        [Fact]
        public void WhenEmptySlotsGreaterThanNeedSlots_ShouldSucceed_1()
        {
            int[] input = new int[] { 1, 2, 5, 6, 8, -1, -1, -1, -1 };
            int[] actualOutput = Program.cloneEvenNumbers_1(input);
            int[] expectedOutput = new int[] { 1, 2, 2, 5, 6, 6, 8, 8 };

            for (int i = 0; i < input.Length; i++)
            {
                Assert.Equal(actualOutput[i], expectedOutput[i]);
            }
        }
        */
        [Fact]
        public void WhenEmptySlotsEqualNeedSlots_ShouldSucceed_2()
        {
            int[] input = new int[] { 1, 2, 5, 6, 8, -1, -1, -1 };
            int[] actualOutput = Program.cloneEvenNumbers_2(input);
            int[] expectedOutput = new int[] { 1, 2, 2, 5, 6, 6, 8, 8 };

            for (int i = 0; i < input.Length; i++)
            {
                Assert.Equal(actualOutput[i], expectedOutput[i]);
            }
        }

        [Fact]
        public void WhenEmptySlotsGreaterThanNeedSlots_ShouldSucceed_2()
        {
            int[] input = new int[] { 1, 2, 5, 6, 8, -1, -1, -1, -1 };
            int[] actualOutput = Program.cloneEvenNumbers_2(input);
            int[] expectedOutput = new int[] { 1, 2, 2, 5, 6, 6, 8, 8, -1 };

            for (int i = 0; i < input.Length; i++)
            {
                Assert.Equal(actualOutput[i], expectedOutput[i]);
            }
        }

        //  ---------------------------------------- Problem 2 --------------------------------------------------

        [Fact]
        public void WhenNoTrailingSpaces_ShouldSucceed()
        {
            string input = "i live in a house";
            string actualOutput = Program.reverseWords(input);
            string expectedOutput = "house a in live i";
            AssemblyLoadEventArgs.Equals(actualOutput, expectedOutput);
        }

        [Fact]
        public void WhenTrailingSpaces_ShouldSucceed_1()
        {
            string input = "i live in a house";
            string actualOutput = Program.reverseWords(input);
            string expectedOutput = "house a in live i    ";
            AssemblyLoadEventArgs.Equals(actualOutput, expectedOutput);
        }
        [Fact]
        public void WhenTrailingSpaces_ShouldSucceed_2()
        {
            string input = "i live in a house    ";
            string actualOutput = Program.reverseWords(input);
            string expectedOutput = "    house a in live i";
            AssemblyLoadEventArgs.Equals(actualOutput, expectedOutput);
        }

        //  ---------------------------------------- Problem 3 --------------------------------------------------
        [Fact]
        public void Problem3()
        {
            int[] input = new int[] { 3, 5, 2, 5, 2, 3, 9 };
            Program.reverse(input);
            int[] expectedOutput = new int[] { 9, 3, 2, 5, 2, 5, 3 };

            for (int i = 0; i < input.Length; i++)
            {
                Assert.Equal(input[i], expectedOutput[i]);
            }
        }
        //  ---------------------------------------- Problem 4 --------------------------------------------------
        [Fact]
        public void Problem4()
        {
            int[] input = new int[] { 1, 2, 3, 5, 6, 7 };
            Tuple<int, int> actualOutput = Program.twoSum(input, 11);
            Tuple<int, int> expectedOutput = new Tuple<int, int>(5, 6);

            Assert.Equal(actualOutput.Item1, expectedOutput.Item1);
            Assert.Equal(actualOutput.Item2, expectedOutput.Item2);
        }
        //  ---------------------------------------- Problem 5 --------------------------------------------------
        [Fact]
        public void Problem5_1()
        {
            int[] input = new int[] { 1,2,4,5,3,5,6};
            Tuple<int, int> actualOutput = Program.shortestUnsortedSubarray(input);
            Tuple<int, int> expectedOutput = new Tuple<int, int>(2,4);

            Assert.Equal(actualOutput.Item1, expectedOutput.Item1);
            Assert.Equal(actualOutput.Item2, expectedOutput.Item2);
        }

        [Fact]
        public void Problem5_2()
        {
            int[] input = new int[] { 1,3,5,2,6,4,7,8,9};
            Tuple<int, int> actualOutput = Program.shortestUnsortedSubarray(input);
            Tuple<int, int> expectedOutput = new Tuple<int, int>(1,5);

            Assert.Equal(actualOutput.Item1, expectedOutput.Item1);
            Assert.Equal(actualOutput.Item2, expectedOutput.Item2);
        }

        //  ---------------------------------------- Problem 7 --------------------------------------------------
        [Fact]
        public void Problem7()
        {
            int[] input = new int[] { 4,2,0,1,0,3,0 };
            Program.moveZeroesToBeginning(input);
            int[] expectedOutput = new int[] { 0,0,0,1,2,3,4 };

            for (int i = 0; i < input.Length; i++)
            {
                Assert.Equal(input[i], expectedOutput[i]);
            }
        }
        //  ---------------------------------------- Problem 8 --------------------------------------------------
        [Fact]
        public void Problem8()
        {
            int[] input = new int[] { 4,2,0,1,0,3,0 };
            Program.moveZeroesToEnd(input);
            int[] expectedOutput = new int[] { 4,2,3,1,0,0,0 };

            for (int i = 0; i < input.Length; i++)
            {
                Assert.Equal(input[i], expectedOutput[i]);
            }
        }
        //  ---------------------------------------- Problem 9 --------------------------------------------------
        [Fact]
        public void Problem9()
        {
            int[] input = new int[] { 4,1,4,3,5 };
            Program.dutchNationalFlag(input,4);
            int[] expectedOutput = new int[] { 1,3,4,4,5 };

            for (int i = 0; i < input.Length; i++)
            {
                Assert.Equal(input[i], expectedOutput[i]);
            }
        }
        //  ---------------------------------------- Problem 10 --------------------------------------------------
        [Fact]
        public void Problem10()
        {
            int[] input = new int[] { 1,0,1,2,1,0,1,2 };
            Program.redWhiteBlue(input);
            int[] expectedOutput = new int[] { 0,0,1,1,1,1,2,2 };

            for (int i = 0; i < input.Length; i++)
            {
                Assert.Equal(input[i], expectedOutput[i]);
            }
        }
    }
}