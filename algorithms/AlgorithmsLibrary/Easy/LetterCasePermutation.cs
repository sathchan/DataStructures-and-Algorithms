using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    /*
     * Input: S = "a1b2"
     * Output: ["a1b2", "a1B2", "A1b2", "A1B2"]
     * */
    public class LetterCasePermutation
    {
        public List<String> Main(String S)
        {
            List<String> list = new List<string>();
            if (S == null || S.Length == 0)
            {
                list.Add("");
                return list;
            }
            List<String> results = Main(S.Substring(1));
            foreach (String result in results)
            {
                if (char.IsLetter(S[0]))
                {
                    list.Add(S.Substring(0, 1).ToLower() + result);
                    list.Add(S.Substring(0, 1).ToUpper() + result);
                }
                else
                {
                    list.Add(S.Substring(0, 1) + result);
                }
            }
            return list;
        }        
    }
}
