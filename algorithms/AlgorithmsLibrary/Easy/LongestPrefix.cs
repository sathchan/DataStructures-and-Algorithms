using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class LongestPrefix
    {
        public string Main(string[] strs)
        {
            if (strs == null || strs.Length == 0) return string.Empty;

            string strComparison = strs[0];
            StringBuilder strPrefix = new StringBuilder();

            for (int i = 1; i < strs.Length; i++)
            {
                int j = 0; strPrefix.Clear();
                foreach (var str2Char in strs[i])
                {
                    if ( (!string.IsNullOrEmpty(strComparison)) && j < strComparison.Length && str2Char == strComparison[j] )
                    {
                        strPrefix.Append(str2Char);
                        j++;
                    }
                    else
                    {
                        break;
                    }
                }

                strComparison = (string.Equals(strComparison, strPrefix)) ? strComparison : strPrefix.ToString();
            }

            return strComparison;
        }
    }
}
