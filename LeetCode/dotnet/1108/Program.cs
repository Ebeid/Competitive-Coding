using System;

namespace _1108
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DefangIPaddr("1.1.1.1"));
            Console.WriteLine(DefangIPaddr("255.100.50.0"));
        }

        public static string DefangIPaddr(string address)
        {
            return address.Replace(".","[.]");
        }
    }
}
