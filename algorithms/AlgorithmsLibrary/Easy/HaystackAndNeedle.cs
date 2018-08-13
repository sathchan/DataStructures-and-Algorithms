using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class HaystackAndNeedle
    {
        public int Main(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle)) return 0;
            if (string.IsNullOrEmpty(haystack)) return -1;
            int index = 0, indexCounter = 0;

            for (int i = 0; i < haystack.Length && indexCounter == 0; i++)
            {
                if (haystack[i] == needle[0])
                {
                    index = i; indexCounter++;
                    for (int j = 1, k = i + 1; j < needle.Length && k < haystack.Length; j++, k++)
                    {
                        if (haystack[k] != needle[j])
                        {
                            index = 0; indexCounter = 0;
                            break;
                        }
                        else indexCounter++;
                    }
                }
            }

            return (indexCounter == needle.Length) ? index : -1;
        }
    }
}
