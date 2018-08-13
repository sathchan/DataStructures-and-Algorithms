using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class LongestSubStringWithoutRepeatingChar
    {
        public int Main(string s)
        {
            if (s.Length == 0) return 0;
            Dictionary<Char, int> map = new Dictionary<char, int>();
            int max = 0;
            for (int i = 0, j = 0; i < s.Length; ++i)
            {
                if (map.ContainsKey(s[i]))
                {
                    int value = 0;
                    map.TryGetValue(s[i], out value);

                    j = Math.Max(j, value + 1);
                }
                map[s[i]] = i;
                max = Math.Max(max, i - j + 1);
            }
            return max;
        }
    }
}
