# Problems
1. Level: Easy. Given an array of integers, find the contiguous subarray (with at least 1 element) with the maximum sum. The array can contain both negative and positive integers. 
    1. The same as [Problem 53 on LeetCode](https://leetcode.com/problems/maximum-subarray)
2. Level: Medium. Given an array of positive integers, find a subarray that sums to a given number X.For e.g, input = [1,2,3,5,2] and X=8, Result = [3,5] (indexes 2,3)
    1. Similar to [Problem 56 on LeetCode](https://leetcode.com/problems/subarray-sum-equals-k)
3. Level: Medium. Given a String, find the longest substring with unique characters.For example: "whatwhywhere" --> "atwhy" 
    1. Similar to [Problem 3 on LeetCode](https://leetcode.com/problems/longest-substring-without-repeating-characters)
4. Level: Medium. Given an array of integers, both -ve and +ve, find a contiguous subarray that sums to 0.For example: [2,4,-2,1,-3,5,-3] --> [4,-2,1,-3]

## .Net Core commands to create this solution

1. Create solution in the current directory ``` dotnet new sln -o . ```
2. Create a new class library project Solution.csproj in the Solution folder ```dotnet new classlib -o Solution```
3. Add the Solution.csproj class library project to the solution ```dotnet sln add ./Solution/Solution.csproj```
4. Create the Solution.Tests xunit test project in the Solution.Tests directory ```dotnet new xunit -o Solution.Tests```
5. Add the test project to the solution ```dotnet sln add ./Solution.Tests/Solution.Tests.csproj```
6. Add the Solution.csproj class library as a dependency to the Solution.Tests.csproj project ```dotnet add ./Solution.Tests/Solution.Tests.csproj reference ./Solution/Solution.csproj```

**Run tests** ```dotnet test```