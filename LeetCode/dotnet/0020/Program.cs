using System;
using System.Collections;

namespace _0020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("()"));
            Console.WriteLine(IsValid("()[]{}"));
            Console.WriteLine(IsValid("(]"));
            Console.WriteLine(IsValid("([)]"));
            Console.WriteLine(IsValid("{[]}"));
        }

        public static bool IsValid(String s)
        {
            if (s.Length == 0)
                return true;
            if (s.Length % 2 != 0)
                return false;
            Stack paranthesesVidisted = new Stack();
            foreach (char c in s.ToCharArray())
            {
                if (c.ToString().Equals("(") || c.ToString().Equals("{") || c.ToString().Equals("["))
                    paranthesesVidisted.Push(c.ToString());
                else
                {
                    if (c.ToString().Equals(")"))
                    {
                        if ((paranthesesVidisted.Count != 0) && (!paranthesesVidisted.Pop().Equals("(")))
                            return false;
                    }
                    else if (c.ToString().Equals("}"))
                    {
                        if ((paranthesesVidisted.Count != 0) && (!paranthesesVidisted.Pop().Equals("{")))
                            return false;
                    }
                    else if ((paranthesesVidisted.Count != 0) && (c.ToString().Equals("]")))
                    {
                        if (!paranthesesVidisted.Pop().Equals("["))
                            return false;
                    }
                }
            }
            if (paranthesesVidisted.Count != 0)
                return false;
            return true;
        }
    }
}
