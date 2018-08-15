using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class PartitionLabels
    {
        public List<int> Main(String S)
        {
            if (S == null || S.Length == 0)
            {
                return null;
            }
            List<int> list = new List<int>();
            int[] map = new int[26];  

            for (int i = 0; i < S.Length; i++)
            {
                map[S[i] - 'a'] = i;
            }
            
            int last = 0;
            int start = 0;
            for (int i = 0; i < S.Length; i++)
            {
                last = Math.Max(last, map[S[i] - 'a']);
                if (last == i)
                {
                    list.Add(last - start + 1);
                    start = last + 1;
                }
            }

            return list;
        }
    }
}
