using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    /*
        Find and Replace Pattern
        --------------------------
        You have a list of words and a pattern, and you want to know which words in words matches the pattern.

        A word matches the pattern if there exists a permutation of letters p so that after replacing every letter x in the pattern with p(x), we get the desired word.

        (Recall that a permutation of letters is a bijection from letters to letters: every letter maps to another letter, and no two letters map to the same letter.)

        Return a list of the words in words that match the given pattern. 

        You may return the answer in any order.

 

        Example 1:

        Input: words = ["abc","deq","mee","aqq","dkd","ccc"], pattern = "abb"
        Output: ["mee","aqq"]
        Explanation: "mee" matches the pattern because there is a permutation {a -> m, b -> e, ...}. 
        "ccc" does not match the pattern because {a -> c, b -> c, ...} is not a permutation,
        since a and b map to the same letter.
 

        Note:

        1 <= words.length <= 50
        1 <= pattern.length = words[i].length <= 20

        https://leetcode.com/problems/find-and-replace-pattern/description/        
         
     */

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

                if (patternText.ToString() == wordsText.ToString())
                {
                    result.Add(word);
                } 
            }

            return result;
        }
    }
}
