# Solution for problem 0001 

Original problem: https://leetcode.com/problems/two-sum/

Given an array of integers, return indices of the two numbers such that they add up to a specific target. 
You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:
Given nums = [2, 7, 11, 15], target = 9,
Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].


## Brute force accepted solution

```
        public int[] TwoSum(int[] nums, int target)
        {
            ArrayList result = new ArrayList();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if ((i != j) && (nums[i] + nums[j] == target))
                    {
                        if (!result.Contains(i) && !result.Contains(j))
                        {
                            result.Add(i);
                            result.Add(j);
                        }
                    }
                }
            }
            return (int[])result.ToArray(typeof(int));
        }
```