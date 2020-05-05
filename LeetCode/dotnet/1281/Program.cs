using System;

namespace _1281
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SubtractProductAndSum(234));
            Console.WriteLine(SubtractProductAndSum(4421));
        }
        public static int SubtractProductAndSum(int n)
        {
            int sum = 0;
            int multiply = 1;
            foreach(char c in n.ToString().ToCharArray())
            {
                sum = sum + int.Parse(c.ToString()) ;
                multiply = multiply * int.Parse(c.ToString());
            }
            return multiply - sum;
        }
    }
}
