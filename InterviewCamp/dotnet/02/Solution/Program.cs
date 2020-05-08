using System;
using System.Collections;
using System.Collections.Generic;
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
        public static Tuple<int, int> allUnique(string input) 
        {    
            if (String.IsNullOrWhiteSpace(input)) 
            {        
                return null;    
            }    

            Dictionary<char, int> map = new Dictionary<char, int>();
            Tuple<int, int> result = new Tuple<int, int>(0,0);
            int start = 0, end = 0, longest = 1;    
            map.Add(input[0], 0);    
            while (end < input.Length - 1) 
            {        
                // expand end pointer        
                end++;        
                char toAdd = input[end];        
                if (map.ContainsKey(toAdd) && map[toAdd] >= start) 
                {            
                    start = map[toAdd] + 1;        
                }  
                map[toAdd] = end;        
                // update result        
                if (end - start + 1 > longest) 
                {            
                    longest = end - start + 1;            
                    result = new Tuple<int, int>(start, end);      
                }    
            }    
            return result;
        }
        //  ---------------------------------------- Problem 4 --------------------------------------------------
        public static Tuple<int, int> zeroSumSubarray(int[] a) 
        {    
            if (a == null || a.Length == 0)        
                return null;    
            int sum = 0;    
            Dictionary<int, int> map = new Dictionary<int, int>();  
            for (int i = 0; i < a.Length; i++) 
            {        
                sum += a[i];        
                if (sum == 0) 
                {            
                    return new Tuple<int, int>(0,i);        
                }        
                if (map.ContainsKey(sum)) 
                {            
                    return new Tuple<int, int>(map[sum] + 1, i);
                }        
                map.Add(sum, i);   
            }    
            return null; // not found
        }
    }
}
