using System.Collections.Generic;

namespace leetcode
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int length = s.Length, ans = 0;
            int start = 0;

            Dictionary<char, int> map = new Dictionary<char, int>();

            for (int i = 0; i < length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    if (map[s[i]] >= start)
                    {
                        start = map[s[i]];
                    }
                }

                ans = System.Math.Max(ans, i - start + 1);
                map[s[i]] = i + 1;
            }
            return ans;
        }
    }


}