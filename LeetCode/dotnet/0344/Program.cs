using System;

namespace _0344
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = "Hello World!".ToCharArray();
            ReverseString(s);
            foreach(char c in s)
                Console.Write(c);
        }
        public static void ReverseString(char[] s)
        {
            if ((s == null) || (s.Length == 1))
                return;
            char temp;
            for (int i = 0; i < s.Length / 2; i++)
            {
                temp = s[i];
                s[i] = s[s.Length - i - 1];
                s[s.Length - i - 1] = temp;
            }
        }
    }
}
