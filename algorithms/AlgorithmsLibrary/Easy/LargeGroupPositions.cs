using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class LargeGroupPositions
    {
        public IList<IList<int>> Main(string S)
        {
            int i = 0, j = 0, N = S.Length;
            IList<IList<int>> res = new List<IList<int>>();
            while (j < N)
            {
                while (j < N && S[j] == S[i]) ++j;
                if (j - i >= 3)
                {
                    List<int> values = new List<int>();
                    values.Add(i);
                    values.Add(j - 1);
                    res.Add(values);
                }                    
                i = j;
            }
            return res;
        }
    }
}
