# Problems
1. Level: Easy. Given an array of numbers, replace each even number with twoof the same number. e.g, [1,2,5,6,8, , , ,] -> [1,2,2,5,6,6,8,8].Assume that the array has the exact amount of space to accommodate the result.
2. Level: Easy. Given a sentence, reverse the words of the sentence.For example,"i live in a house" becomes "house a in live i"
3. Level: Easy. Given an array, reverse the order of its elements.For example, [3,5,2,5,2,3,9] → [9,3,2,5,2,5,3]
4. Level: Easy. 2 Sum Problem: Given a sorted array of integers, find two numbers in the array that sumto a given integer target. For example, if a = [1,2,3,5,6,7] and target = 11, the answer will be 5 and 6.
5. Level: Easy. Given a sorted array in non-decreasing order, return an array of squares of each number, also in non-decreasing order. For example:[-4,-2,-1,0,3,5] -> [0,1,4,9,16,25].
6. Level: Medium. Given an array of integers, find the shortest sub array, that if sorted, results in the entire array being sorted. For example:[1,2,4,5,3,5,6,7] --> [4,5,3] - If you sort from indices 2 to 4, the entire array is sorted.[1,3,5,2,6,4,7,8,9] --> [3,5,2,6,4] -  If you sort from indices 1 to 5, the entire array is sorted.
7. Level: Easy. You are given an array of integers. Rearrange the array so that all zeroes are at the beginning of the array.For example,a = [4,2,0,1,0,3,0] -> [0,0,0,4,1,2,3]
8. Level: Easy. You are given an array of integers. Rearrange the array so that all zeroes are at the end of the array.For example,a = [4,2,0,1,0,3,0] -> [4,1,2,3,0,0,0]
9. Level: Medium. You are given an array of integers and a pivot. Rearrange the array in the following order:[all elements less than pivot, elements equal to pivot, elements greater than pivot]For example,a = [5,2,4,4,6,4,4,3] and pivot = 4 --> result = [3,2,4,4,4,4,5,6]
10. Level: Medium. You're given a list of Marbles. Each marble can have one of 3 colors (Red, White or Blue). Arrange the marbles in order of the colors (Red -> White -> Blue).Colors are represented as follows:
0 - Red
1 - White
2 - Blue

## .Net Core commands to create this solution

1. Create solution in the current directory
```
dotnet new sln -o .
```
2. Create a new class library project Solution.csproj in the Solution folder
```
dotnet new classlib -o Solution
```
3. Add the Solution.csproj class library project to the solution
```
dotnet sln add ./Solution/Solution.csproj
```
4. Create the Solution.Tests xunit test project in the Solution.Tests directory
```
dotnet new xunit -o Solution.Tests
```
5. Add the test project to the solution 
```
dotnet sln add ./Solution.Tests/Solution.Tests.csproj
```
6. Add the Solution.csproj class library as a dependency to the Solution.Tests.csproj project
```
dotnet add ./Solution.Tests/Solution.Tests.csproj reference ./Solution/Solution.csproj
```

## Run tests
```
dotnet test
```