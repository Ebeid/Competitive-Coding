using System;
using System.Collections;

namespace _0560
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SubarraySum(new int[] { 1 }, 1));
            Console.WriteLine(SubarraySum(new int[] { 1, 1, 1 }, 2));
            Console.WriteLine(SubarraySum(new int[] { 1, 2, 3 }, 3));
            Console.WriteLine(SubarraySum(new int[] { 1, 2, 1, 2, 1 }, 3));
            Console.WriteLine(SubarraySum(new int[] { -1,-1,1 }, 0));
        }

        public static int SubarraySum(int[] a, int target)
        {
            if (a == null || a.Length == 0)
                return 0;
            if (a.Length == 1)
                return a[0] == target ? 1:0;
            
            int start = 0, end = 0, sum = a[0];
            int result = 0;
            while (start < a.Length) 
            {        
                if (start > end) { // start inched forward, bring end back to start            
                    end = start;            
                    sum = a[start];        
                }        
                if (sum < target) { // expand to right            
                    if (end == a.Length - 1) {               
                        if(a[start] < 0){
                            sum = sum -a[start];
                            start++;
                        } else
                            break; // reached end, cannot expand further    
                    }       
                    //end++;            
                    //sum = sum + a[end];        
                } else if (sum > target) { // contract from left            
                    sum = sum - a[start];            
                    start++;        
                } else {
                    Console.WriteLine(target + " " + result + " " + sum + " " + start + " " + end);      
                    result++;
                    start++;
                    end = start;
                    if(start == a.Length)
                        return result;
                    else
                        sum = a[start];
                }    
            }    
            return result;
        }
    }
}
