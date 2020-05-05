# Solution for problem 58

Project initialized using dotnet core CLI:
```
dotnet new console
```

**Original problem** : Length of Last Word https://leetcode.com/problems/length-of-last-word   

Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word (last word means the last appearing word if we loop from left to right) in the string.

If the last word does not exist, return 0.

Note: A word is defined as a maximal substring consisting of non-space characters only.

**Example** :
```
Input: "Hello World"
Output: 5
```

## Solution

```
    public int LengthOfLastWord(string s) {
            if (s.Length == 0)
                return 0;
            String[] words = s.Trim().Split(" ");
            if (words.Length == 0)
                return 0;
            else
                return words[words.Length - 1].Length;
    }
```