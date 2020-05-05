# Solution for problem 43 

Project initialized using dotnet core CLI:
```
dotnet new console
```

**Original problem** : Multiply Strings https://leetcode.com/problems/multiply-strings  

Given two non-negative integers num1 and num2 represented as strings, return the product of num1 and num2, also represented as a string.

**Example 1** :
```
Input: num1 = "2", num2 = "3"
Output: "6"
```
**Example 2** :
```
Input: num1 = "123", num2 = "456"
Output: "56088"
```

## Solution

```
public class Solution {
        public string Multiply(string num1, string num2)
        {
            int[] num1Array = new int[num1.Length];
            int[] num2Array = new int[num2.Length];

            int i = 0;
            foreach(char c in num1.ToCharArray())
                num1Array[i++] = int.Parse(c.ToString());

            i= 0;
            foreach(char c in num2.ToCharArray())
                num2Array[i++] = int.Parse(c.ToString());

            string result = "";
            foreach(int j in multiply(num1Array, num2Array))
                result = result + j.ToString();

            return result;
        }

        public int[] multiply(int[] a, int[] b) 
        {    
            if (a == null || b == null) {        
                throw new ArgumentException("Input is null");    
            }    
            int[] result = {0};    
            int zeroCount = 0; // number of zeroes to add to the end    
            for (int i = a.Length - 1; i >= 0; i--) 
            {        
                int[] product = new int[1 + b.Length + zeroCount];        
                int carry = 0;        
                for (int j = b.Length - 1; j >= 0; j--) 
                {            
                    int p = a[i] * b[j] + carry;            
                    carry = p / 10;            
                    product[j + 1] = p % 10;       
                }        
                product[0] = carry;      
                result = add(result, product);        
                zeroCount++;    
            }    
            return result;
        }
        
        public int[] add(int[] a, int[] b) 
        {    
            if (a == null || b == null) {        
                throw new ArgumentException("Input is null");    
            }    
            int[] larger = a.Length > b.Length ? a : b;    
            int[] smaller = larger == a ? b : a;    
            smaller = resizeWithZeroes(smaller, larger.Length);    
            int[] result = new int[1 + larger.Length ];    
            int carry = 0;    
            for (int i = larger.Length - 1; i >= 0; i--) 
            {        
                int sum = larger[i] + smaller[i] + carry;        
                carry = sum / 10;        
                result[i+1] = sum % 10;    
            }    
            result[0] = carry;    
            result = trimBeginningZeroes(result);    
            return result;
        }

        public int[] resizeWithZeroes(int[] a, int size) 
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

        public int[] trimBeginningZeroes(int[] a) 
        {    
            int i = 0;    
            while (i < a.Length && a[i] == 0)        
                i++;    
            if (i == a.Length)        
                return new int[1]; // return [0]
            int[] result = new int[a.Length-i];  
            Array.Copy(a, i, result, 0, a.Length-i);  
            return result;
        }
}
```