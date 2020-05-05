using System;

namespace _1295
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindNumbers( new int[]{12,345,2,6,7896} ));
            Console.WriteLine(FindNumbers( new int[]{555,901,482,1771} ));
        }
        public static int FindNumbers(int[] nums)
        {
            int result = 0;
            foreach(int num in nums)
            {
                if (num.ToString().Length % 2 == 0)
                    result++;
            }
            return result;
        }
    }
}
