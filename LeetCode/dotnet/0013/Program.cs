using System;

namespace _0013
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("III"));
            Console.WriteLine(RomanToInt("IV"));
            Console.WriteLine(RomanToInt("IX"));
            Console.WriteLine(RomanToInt("LVIII"));
            Console.WriteLine(RomanToInt("MCMXCIV"));
        }
        public static int RomanToInt(String s)
        {
            int output = 0;
            bool includedBefore = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (includedBefore)
                {
                    includedBefore = false;
                    continue;
                }
                if (s[i] == 'I')
                {
                    if ((i != s.Length - 1) && (s[i + 1] == 'V'))
                    {
                        output = output + 4;
                        includedBefore = true;
                    }
                    else if ((i != s.Length - 1) && (s[i + 1] == 'X'))
                    {
                        output = output + 9;
                        includedBefore = true;
                    }
                    else
                    {
                        output = output + 1;
                        includedBefore = false;
                    }
                }

                if (s[i] == 'V')
                {
                    output = output + 5;
                    includedBefore = false;
                }
                
                if (s[i] == 'X')
                {
                    if ((i != s.Length - 1) && (s[i + 1] == 'L'))
                    {
                        output = output + 40;
                        includedBefore = true;
                    }
                    else if ((i != s.Length - 1) && (s[i + 1] == 'C'))
                    {
                        output = output + 90;
                        includedBefore = true;
                    }
                    else
                    {
                        output = output + 10;
                        includedBefore = false;
                    }
                }

                if (s[i] == 'L')
                {
                    output = output + 50;
                    includedBefore = false;
                }

                if (s[i] == 'C')
                {
                    if ((i != s.Length - 1) && (s[i + 1] == 'D'))
                    {
                        output = output + 400;
                        includedBefore = true;
                    }
                    else if ((i != s.Length - 1) && (s[i + 1] == 'M'))
                    {
                        output = output + 900;
                        includedBefore = true;
                    }
                    else
                    {
                        output = output + 100;
                        includedBefore = false;
                    }
                }

                if (s[i] == 'D')
                {
                    output = output + 500;
                    includedBefore = false;
                }

                if (s[i] == 'M')
                {
                    output = output + 1000;
                    includedBefore = false;
                }
            }
            return output;
        }
    }
}
