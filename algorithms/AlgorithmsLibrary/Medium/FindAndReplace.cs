using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class FindAndReplace
    {
        public IList<string> Main(string[] words, string pattern)
        {
            Dictionary<char, int> patternDict = new Dictionary<char, int>();
            StringBuilder patternText = new StringBuilder();
            int index = 0; List<string> result = new List<string>();

            foreach (var item in pattern.ToCharArray())
            {
                if (!patternDict.ContainsKey(item))
                {
                    patternDict.Add(item, index);
                    patternText.Append(index);
                    index++;
                }
                else
                {
                    patternText.Append(patternDict[item]);
                }
            }

            foreach (var word in words)
            {
                Dictionary<char, int> wordDict = new Dictionary<char, int>();
                StringBuilder wordsText = new StringBuilder();
                index = 0;

                foreach (var item in word.ToCharArray())
                {
                    if (!wordDict.ContainsKey(item))
                    {
                        wordDict.Add(item, index);
                        wordsText.Append(index);
                        index++;
                    }
                    else
                    {
                        wordsText.Append(wordDict[item]);
                    }
                }

                if (patternText.ToString() == wordsText.ToString()) result.Add(wordsText.ToString());
            }

            return result;
        }
    }
}
