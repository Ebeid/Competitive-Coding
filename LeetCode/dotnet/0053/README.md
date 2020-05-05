# Solution for problem 0053

Project initialized using dotnet core CLI:
```
dotnet new console
```

run using
```
dotnet run
```

**Original problem** : Maximum Subarray https://leetcode.com/problems/maximum-subarray/

Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.

**Example** :
```
Input: [-2,1,-3,4,-1,2,1,-5,4],
Output: 6
Explanation: [4,-1,2,1] has the largest sum = 6.
```

## Brute force accepted solution

```
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
```

## Kadane's algorithm solution

```
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
```