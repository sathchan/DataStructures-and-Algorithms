using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AlgorithmsLibrary
{
    public class MostCommonWord
    {
        public string Main(string paragraph, string[] banned)
        {
            Dictionary<string, int> paraWords = new Dictionary<string, int>();
            string[] splitWords = paragraph.Split(' ');
            char[] punctations = new char[] { '!', '?', ',', ';', '.', '\''};

            foreach (var word in splitWords)
            {
                //exclude the punctionation/special char & lower case
                string modifiedword = new string(word.ToLower().Where(c => !punctations.Contains(c)).ToArray());
                
                if (paraWords.ContainsKey(modifiedword))
                {
                    paraWords[modifiedword]++;
                }
                else
                {
                    paraWords.Add(modifiedword, 1);
                }
            }

            if (banned == null || banned.Count() == 0) return paraWords.OrderByDescending(key => key.Value).First().Key;

            //order by largest count
            foreach (KeyValuePair<string, int> paraWord in paraWords.OrderByDescending(key => key.Value))
            {
                bool isMatchedWithBannedWord = false;
                foreach (var word in banned)
                {
                    if (string.Equals(paraWord.Key, word, StringComparison.OrdinalIgnoreCase)) isMatchedWithBannedWord = true; ;
                }

                if (!isMatchedWithBannedWord) return paraWord.Key;
            }

            return string.Empty;

        }
    }
}
