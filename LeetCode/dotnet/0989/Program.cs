using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _0989
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> result = AddToArrayForm(new int[] { 1, 2, 0, 0 }, 34);
            Console.WriteLine(String.Join(",", result));
        }

        public static IList<int> AddToArrayForm(int[] A, int K)
        {
            int[] B = new int[K.ToString().Length];
            int i = 0;
            foreach (char c in K.ToString().ToCharArray())
                B[i++] = int.Parse(c.ToString());

            List<int> result = new List<int>();
            return add(A, B).ToList();
        }

        public static int[] add(int[] a, int[] b)
        {
            if (a == null || b == null)
            {
                throw new ArgumentException("Input is null");
            }
            int[] larger = a.Length > b.Length ? a : b;
            int[] smaller = larger == a ? b : a;
            smaller = resizeWithZeroes(smaller, larger.Length);
            int[] result = new int[1 + larger.Length];
            int carry = 0;
            for (int i = larger.Length - 1; i >= 0; i--)
            {
                int sum = larger[i] + smaller[i] + carry;
                carry = sum / 10;
                result[i + 1] = sum % 10;
            }
            result[0] = carry;
            result = trimBeginningZeroes(result);
            return result;
        }
        public static int[] resizeWithZeroes(int[] a, int size)
        {
            if (size < a.Length)
                throw new ArgumentException("We can't shrink the array");
            int[] result = new int[size];
            int aIndex = a.Length - 1, resultIndex = result.Length - 1;
            while (aIndex >= 0)
            {
                result[resultIndex] = a[aIndex];
                resultIndex--;
                aIndex--;
            }
            return result;
        }

        public static int[] trimBeginningZeroes(int[] a)
        {
            int i = 0;
            while (i < a.Length && a[i] == 0)
                i++;
            if (i == a.Length)
                return new int[1]; // return [0]
            int[] result = new int[a.Length - i];
            Array.Copy(a, i, result, 0, a.Length - i);
            return result;
        }
    }
}
