using System;
using System.Text;

namespace _0007
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1534236469;
            Console.WriteLine(reverse(input));
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
