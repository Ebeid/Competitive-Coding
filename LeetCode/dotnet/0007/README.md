# Solution for problem 0007 

Project initialized using dotnet core CLI:
```
dotnet new console
```

**Original problem** : Reverse Integer https://leetcode.com/problems/reverse-integer 

Given a 32-bit signed integer, reverse digits of an integer.

**Example 1** :
```
Input: 123
Output: 321
```
**Example 2** :
```
Input: -123
Output: -321
```
**Example 3** :
```
Input: 120
Output: 21
```

## Brute force accepted solution

```
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