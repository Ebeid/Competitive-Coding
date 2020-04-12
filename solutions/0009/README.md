# Solution for problem 0009 

Project initialized using dotnet core CLI:
```
dotnet new console
```

**Original problem** : Palindrome Number https://leetcode.com/problems/palindrome-number

Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.

**Example 1** :
```
Input: 121
Output: true
```
**Example 2** :
```
Input: -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
```
**Example 3** :
```
Input: 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
```

## Brute force accepted solution

```
        public static bool IsPalindrome(int x)
        {
            if(x < 0)
                return false;
            int y = reverse(x);
            return (x == x);
        }

        public static int reverse(int input)
        {
            try
            {
                char[] inputArray;
                if (input > 0)
                {
                    inputArray = input.ToString().ToCharArray();
                    Array.Reverse(inputArray);
                    Console.WriteLine(new string(inputArray));
                    return Int32.Parse(new string(inputArray));
                }
                else
                {
                    inputArray = input.ToString().Substring(1).ToCharArray();
                    Array.Reverse(inputArray);
                    return (-1 * Int32.Parse(new string(inputArray)));
                }
            }
            catch { return 0; }
        }
```
