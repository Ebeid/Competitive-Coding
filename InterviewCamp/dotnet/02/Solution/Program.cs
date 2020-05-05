using System;

namespace Solution
{
    public class Program
    {
        //  ---------------------------------------- Problem 1 --------------------------------------------------
        public static int maximumSumSubarrayBruteForce(int[] a) {    
            if (a == null || a.Length == 0)        
                throw new ArgumentException("Input array is empty or null");    
            int maxSum = a[0];    
            for (int i = 0; i < a.Length; i++) 
            {        
                int sum = 0;        
                for (int j = i; j < a.Length; j++) 
                {            
                    sum = sum + a[j];            
                    maxSum = Math.Max(maxSum, sum);        
                }    
            }    
            return maxSum;
        }
        // Kadane's algorithm solution
        public static int maximumSumSubarray(int[] a) 
        {    
            if (a == null || a.Length == 0)        
                throw new ArgumentException("Input array is empty or null");
            int maxSum = a[0], maxEndingHere = a[0];    
            for (int i = 1; i < a.Length; i++) 
            {        
                maxEndingHere = Math.Max(maxEndingHere + a[i], a[i]);        
                maxSum = Math.Max(maxSum, maxEndingHere);    
            }    
            return maxSum;
        }
        //  ---------------------------------------- Problem 2 --------------------------------------------------
        public static Tuple<int, int> subarraySum(int[] a, int target) 
        {    
            if (a == null || a.Length == 0)        
                return null;    
            int start = 0, end = 0, sum = a[0];    
            while (start < a.Length) 
            {        
                if (start > end) { // start inched forward, bring end back to start            
                    end = start;            
                    sum = a[start];        
                }        
                if (sum < target) { // expand to right            
                    if (end == a.Length - 1)                
                        break; // reached end, cannot expand further           
                    end++;            
                    sum = sum + a[end];        
                } else if (sum > target) { // contract from left            
                    sum = sum - a[start];            
                    start++;        
                } else {            
                    return new Tuple<int, int> (start, end);        
                }    
            }    
            return null;
        }
        //  ---------------------------------------- Problem 3 --------------------------------------------------

    }

}
