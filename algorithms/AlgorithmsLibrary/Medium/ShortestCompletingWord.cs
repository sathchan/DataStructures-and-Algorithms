using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class ShortestCompletingWord
    {
        public string Main(string licensePlate, string[] words)
        {
            String input = licensePlate.ToLower();
            int[] map = new int[26];
            foreach (char c in input.ToCharArray())
            {
                if (c - 'a' < 0 || c - 'a' > 25) continue;
                map[c - 'a']++;
            }
            int match = 0, length = 0;
            String res = "";
            foreach (String word in words)
            {
                int[] cur = new int[26];
                foreach (char c in word.ToCharArray())
                {
                    cur[c - 'a']++;
                }
                int count = 0;
                for (int i = 0; i < 26; i++)
                {
                    if (map[i] == 0 || cur[i] == 0) continue;
                    if (cur[i] >= map[i])
                    {
                        count += map[i];
                    }
                    else
                    {
                        count += cur[i];
                    }
                }
                if (count > match)
                {
                    match = count;
                    res = word;
                    length = word.Length;
                }
                else if (count == match)
                {
                    if (word.Length < length)
                    {
                        res = word;
                        length = word.Length;
                    }
                }
            }

            return res;
        }
    }
}
