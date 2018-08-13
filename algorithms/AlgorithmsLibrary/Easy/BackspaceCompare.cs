using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsLibrary
{
    public class BackspaceCompare
    {
        public bool Main(string S, string T)
        {
            if (string.IsNullOrEmpty(S) || string.IsNullOrEmpty(T)) return true;

            S = RemoveBackspaceAndChar(S);
            T = RemoveBackspaceAndChar(T);

            return S.Equals(T, StringComparison.OrdinalIgnoreCase);
        }

        public string RemoveBackspaceAndChar(string str)
        {
            while (str.Contains('#'))
            {
                int index = str.IndexOf('#');

                str =  (index == 0) ? str.Remove(index, 1) : str.Remove(index - 1, 2);              
            }

            return str;            
        }
    }
}
