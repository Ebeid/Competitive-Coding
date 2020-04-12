using System;

namespace _0009
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2147483647;
            Console.WriteLine(IsPalindrome(x));
        }
        public static bool IsPalindrome(int x)
        {
            if(x < 0)
                return false;
            int y = reverse(x);
            return (x == x);
        }

        public static int reverse(int input)
        {
            try
            {
                char[] inputArray;
                if (input > 0)
                {
                    inputArray = input.ToString().ToCharArray();
                    Array.Reverse(inputArray);
                    Console.WriteLine(new string(inputArray));
                    return Int32.Parse(new string(inputArray));
                }
                else
                {
                    inputArray = input.ToString().Substring(1).ToCharArray();
                    Array.Reverse(inputArray);
                    return (-1 * Int32.Parse(new string(inputArray)));
                }
            }
            catch { return 0; }
        }
    }
}
