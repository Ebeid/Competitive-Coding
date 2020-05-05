using System;

namespace _0771
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumJewelsInStones("aA", "aAAbbbb"));
            Console.WriteLine(NumJewelsInStones("z", "ZZ"));
        }
        public static int NumJewelsInStones(string J, string S)
        {
            int n = 0;
            foreach(char c in S.ToCharArray())
            {
                if (J.Contains(c.ToString()))
                    n++;
            }
            return n;
        }
    }
}
