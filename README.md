# LeetCode.Net

This repo contains the LeetCode Problem Solutions in .Net Core. I have the ambitious gaol of solving all the problems on LeetCode within 2020.

## How I initialized this repo projects abd sub-directories 

Created initRepo.sh with the below content:

```
#!/bin/bash
for i in $(seq -f "%04g" 1 1500)
do
  echo "Creating directory $i "
  mkdir -p $i
  cd $i
  echo "Solution for problem $i" > README.md
  eval "dotnet new console"
  cd ..
done
```

make initRepo.sh executable

```
chmod 755 initRepo.sh
```
These are the problems that I solved so far:

| No. | Problem Name | Difficulty | Solution |
|-----|--------------|------------|----------|
| 1 | [Two Sum](https://leetcode.com/problems/two-sum/) | Easy | [Solution](0001/README.md) |
| 7 | [Reverse Integer](https://leetcode.com/problems/reverse-integer) | Easy | [Solution](0007/README.md) |
| 9 | [Palindrome Number](https://leetcode.com/problems/palindrome-number) | Easy | [Solution](0009/README.md) |
| 13 | [Roman to Integer](https://leetcode.com/problems/roman-to-integer) | Easy | [Solution](0013/README.md) |
| 14 | [Longest Common Prefix](https://leetcode.com/problems/longest-common-prefix) | Easy | [Solution](0014/README.md) |
| 20 | [Valid Parentheses](https://leetcode.com/problems/valid-parentheses) | Easy | [Solution](0020/README.md) |
| 58 | [Length of Last Word](https://leetcode.com/problems/length-of-last-word) | Easy | [Solution](0058/README.md) |
| 217 | [Contains Duplicate](https://leetcode.com/problems/contains-duplicate) | Easy | [Solution](0217/README.md) |
| 344 | [Reverse String](https://leetcode.com/problems/reverse-string) | Easy | [Solution](0344/README.md) |
| 771 | [Jewels and Stones](https://leetcode.com/problems/jewels-and-stones) | Easy | [Solution](0771/README.md) |
| 1108 | [Defanging an IP Address](https://leetcode.com/problems/defanging-an-ip-address) | Easy | [Solution](1108/README.md) |
| 1281 | [Subtract the Product and Sum of Digits of an Integer](https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer) | Easy | [Solution](1281/README.md) |
| 1295 | [Find Numbers with Even Number of Digits](https://leetcode.com/problems/find-numbers-with-even-number-of-digits) | Easy | [Solution](1295/README.md) |
| 1313 | [Decompress Run-Length Encoded List](https://leetcode.com/problems/decompress-run-length-encoded-list) | Easy | [Solution](1313/README.md) |