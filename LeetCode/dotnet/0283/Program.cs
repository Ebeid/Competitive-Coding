using System;

namespace _0283
{
    class Program
    {
        static void Main(string[] args)
        {
            MoveZeroes(new int[] {0,0,1});
            MoveZeroes(new int[] {0,1,0,3,12});
            MoveZeroes(new int[] {1,0});
            MoveZeroes(new int[] {4,2,4,0,0,3,0,5,1,0});
        }

        public static void MoveZeroes(int[] a)
        {
            if(a.Length == 1)
                return;
            int numOfShifts = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                    numOfShifts++;
                else
                {
                    shiftLeftArray(a, i, numOfShifts);
                    i = i- numOfShifts;
                    numOfShifts = 0;
                }
            }
        }
        public static void shiftLeftArray(int[] a, int start, int numOfShifts)
        {
            if(((start-numOfShifts)<0)|| (numOfShifts == 0))
                return;
            for (int i = start; i < a.Length; i++)
            {

                a[i-numOfShifts] = a[i];
                a[i] = 0;
            }
        }
        public static void printArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }
    }
}
