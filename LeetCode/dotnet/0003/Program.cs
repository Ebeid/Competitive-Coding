using System;
using System.Collections.Generic;

namespace _0003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
            Console.WriteLine(LengthOfLongestSubstring("bbbb"));
            Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
        }

        public static int LengthOfLongestSubstring(string s)
        {
            if (String.IsNullOrEmpty(s)) 
            {        
                return 0;    
            } 

            Dictionary<char, int> map = new Dictionary<char, int>();
            Tuple<int, int> result = new Tuple<int, int>(0,0);
            int start = 0, end = 0, longest = 1;    
            map.Add(s[0], 0);    
            while (end < s.Length - 1) 
            {        
                // expand end pointer        
                end++;        
                char toAdd = s[end];        
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
            return (result.Item2 - result.Item1)+1;
        }
    }
}
