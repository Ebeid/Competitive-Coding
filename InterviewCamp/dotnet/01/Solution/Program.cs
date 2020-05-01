using System;
using System.Text;

namespace Solution
{
    public class Program
    {
        //  ---------------------------------------- Problem 1 --------------------------------------------------
        //This solution will only work if empty slots are exactly equal needed ones.
        public static int[] cloneEvenNumbers_1(int[] a)
        {
            if (a == null || a.Length == 0)
                return a;
            int end = a.Length, i = getLastNumber(a);
            while (i >= 0)
            {
                if (a[i] % 2 == 0)
                    a[--end] = a[i];
                a[--end] = a[i];
                i--;
            }
            return a;
        }
        //This solution will work if empty slots are greater than needed ones.
        public static int[] cloneEvenNumbers_2(int[] a)
        {
            if (a == null || a.Length == 0)
                return a;
            int i = getLastNumber(a);
            int end = i + getCountOfEvenNumbers(a) + 1;
            while (i >= 0)
            {
                if (a[i] % 2 == 0)
                    a[--end] = a[i];
                a[--end] = a[i];
                i--;
            }
            return a;
        }
        public static int getCountOfEvenNumbers(int[] a)
        {
            int result = 0;
            foreach (int i in a)
            {
                if (i % 2 == 0)
                    result++;
            }
            return result;
        }

        public static int getLastNumber(int[] a)
        {
            int i = a.Length - 1;
            while (i >= 0 && a[i] == -1)
                i--;
            return i;
        }

        public static void printArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }
        //  ---------------------------------------- Problem 2 --------------------------------------------------
        public static String reverseWords(String s)
        {
            StringBuilder sb = new StringBuilder();
            int currentWordEnd = s.Length;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i].Equals(' '))
                    append(sb, s.Substring(i + 1, currentWordEnd - (i + 1)));
                currentWordEnd = i;
            }
            sb.Append(s.Substring(0, currentWordEnd));
            return sb.ToString();
        }

        public static void append(StringBuilder sb, string s)
        {
            if (sb.Length > 0)
            {
                sb.Append(' ');
            }
            sb.Append(s);
        }
        //  ---------------------------------------- Problem 3 --------------------------------------------------
        public static void reverse(int[] a)
        {
            if (a == null)
                return;
            int start = 0, end = a.Length - 1;
            while (start < end)
            {
                swap(a, start, end);
                start++;
                end--;
            }
        }

        public static void swap(int[] a, int start, int end)
        {
            int temp = a[start];
            a[start] = a[end];
            a[end] = temp;
        }
        //  ---------------------------------------- Problem 4 --------------------------------------------------
        public static Tuple<int, int> twoSum(int[] a, int target)
        {
            if (a == null)
                return null;
            int start = 0, end = a.Length - 1;
            while (start < end)
            {
                int sum = a[start] + a[end];
                if (sum < target)
                    start++;
                else if (sum > target)
                    end--;
                else
                    return new Tuple<int, int>(a[start], a[end]);
            }
            return null;
        }
        //  ---------------------------------------- Problem 5 --------------------------------------------------
        public static int[] squares(int[] a)
        {
            if (a == null)
                return null;
            int start = 0, end = a.Length - 1;
            int[] result = new int[a.Length];
            int resultIndex = result.Length - 1;
            while (start <= end)
            {
                if (Math.Abs(a[start]) > Math.Abs(a[end]))
                {
                    result[resultIndex] = (int)Math.Pow(a[start], 2);
                    start++;
                }
                else
                {
                    result[resultIndex] = (int)Math.Pow(a[end], 2);
                    end--;
                }
                resultIndex--;
            }
            return result;
        }
        //  ---------------------------------------- Problem 6 --------------------------------------------------
        public static Tuple<int, int> shortestUnsortedSubarray(int[] a)
        {
            if ((a == null) || (a.Length == 0))
                return null;
            int start, end;
            // find dip    
            for (start = 0; start < a.Length - 1; start++)
            {
                if (a[start + 1] < a[start])
                    break;
            }
            // no dip found, array is already sorted    
            if (start == (a.Length - 1))
                return null;

            // find bump    
            for (end = a.Length - 1; end > 0; end--)
            {
                if (a[end - 1] > a[end])
                    break;
            }

            // find min and max of a[start..end]    
            int max = int.MinValue, min = int.MaxValue;
            for (int k = start; k <= end; k++)
            {
                if (a[k] > max)
                    max = a[k];

                if (a[k] < min)
                    min = a[k];
            }

            // expand start and end outward    
            while (start > 0 && a[start - 1] > min)
            {
                start--;
            }
            while (end < (a.Length - 1) && a[end + 1] < max)
            {
                end++;
            }
            return new Tuple<int, int>(start, end);
        }
        //  ---------------------------------------- Problem 7 --------------------------------------------------
        public static void moveZeroesToBeginning(int[] a)
        {
            //Console.Write(">> : ");
            //printArray(a);
            int boundary = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    swap(a, i, boundary);
                    //Console.Write(i + "  : ");
                    //printArray(a);        
                    boundary += 1;
                }
            }
            //Console.Write("<< : ");
            //printArray(a);
        }
        //  ---------------------------------------- Problem 8 --------------------------------------------------
        public static void moveZeroesToEnd(int[] a)
        {
            //Console.Write(">> : ");
            //printArray(a);
            int boundary = a.Length - 1;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (a[i] == 0)
                {
                    swap(a, i, boundary);
                    //Console.Write(i + "  : ");
                    //printArray(a);           
                    boundary--;
                }
            }
            //Console.Write("<< : ");
            //printArray(a);
        }
        //  ---------------------------------------- Problem 9 --------------------------------------------------
        public static void dutchNationalFlag(int[] a, int pivot)
        {
            //Console.Write(">> : ");
            //printArray(a);
            int low_boundary = 0, high_boundary = a.Length - 1;
            int i = 0;
            while (i <= high_boundary)
            {
                if (a[i] < pivot)
                {
                    swap(a, i, low_boundary);
                    low_boundary++;
                    i++;
                }
                else if (a[i] > pivot)
                {
                    swap(a, i, high_boundary);
                    high_boundary--;
                }
                else
                {
                    i++;
                }
                //Console.Write(i + "  : ");
                //printArray(a);  
            }
            //Console.Write("<< : ");
            //printArray(a);
        }
        //  ---------------------------------------- Problem 10 --------------------------------------------------
        public static void redWhiteBlue(int[] a)
        {
            if (a == null)
                return;
            int low_boundary = 0, high_boundary = a.Length - 1;
            int i = 0;
            while (i <= high_boundary)
            {
                if (a[i] == 0) // Red Marble
                {
                    swap(a, i, low_boundary);
                    low_boundary++;
                    i++;
                }
                else if (a[i] == 2) // Blue Marble
                {
                    swap(a, i, high_boundary);
                    high_boundary--;
                }
                else if (a[i] == 1) // White Marble
                {
                    i++;
                }
                else
                {
                    throw new ArgumentException("Unknown Color: " + a[i]);
                }
            }
        }

    //  ---------------------------------------- Problem 11 --------------------------------------------------

    } // End of Class Program


} // End of namespace Solution