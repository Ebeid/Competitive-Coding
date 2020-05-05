using System;

namespace _0014
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = new string[] {"flower","flow","flight"};
            Console.WriteLine( longestCommonPrefix(input));
        }

        public static string longestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";
            string lcp = findShorteststring(strs);
            bool mismatchFound = false;
            while (lcp.Length > 0)
            {
                mismatchFound = false;
                foreach (string str in strs)
                {
                    if ((!str.Equals(lcp)) && (!str.StartsWith(lcp)))
                    {
                        mismatchFound = true;
                        break;
                    }
                }
                if (mismatchFound)
                {
                    lcp = lcp.Substring(0, lcp.Length - 1);
                }
                else
                {
                    return lcp;
                }
            }
            return "";
        }

        public static string findShorteststring(string[] strs)
        {
            string shorteststring = strs[0];
            foreach(string str in strs)
            {
                if (shorteststring.Length > str.Length)
                    shorteststring = str;
            }
            return shorteststring;
        }
    }
}
