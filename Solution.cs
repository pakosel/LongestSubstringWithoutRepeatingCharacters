using System.Collections.Generic;

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLength = 0;
        var strLen = s.Length;
        for(int i=0; i<strLen; i++)
        {
            var currentMax = FindLongest(s.Substring(i), out var reachedEnd);
            if(currentMax > maxLength)
                maxLength = currentMax;
            if(reachedEnd)
                break;
            if(maxLength > strLen - i)
                break;
        }
        return maxLength;
    }
    
    private int FindLongest(string s, out bool reachedEnd)
    {
        HashSet<char> visited = new HashSet<char>();
        reachedEnd = true;
        int maxLen = 0;
        for(int i=0; i<s.Length; i++)
        {
            var currChar = s[i];
            if(!visited.Contains(currChar))
            {
                visited.Add(currChar);
                maxLen++;
            }
            else
            {
                reachedEnd = false;
                break;
            }
        }
        return maxLen;
    }
}