using System;

namespace _0058
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLastWord("a "));
            Console.WriteLine(LengthOfLastWord("Hello World"));
        }

        public static int LengthOfLastWord(string s)
        {
            if (s.Length == 0)
                return 0;
            String[] words = s.Trim().Split(" ");
            if (words.Length == 0)
                return 0;
            else
                return words[words.Length - 1].Length;
        }
    }
}
