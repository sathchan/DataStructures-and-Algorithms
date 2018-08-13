using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class FindAndReplaceString
    {
        //S = "abcd", indexes = [0,2], sources = ["a","cd"], targets = ["eee","ffff"]
        //eeebffff - effffbcd
        //"vyeqmeyggv"
        //[4,0,7]
        //["mey","vye","ggv"]
        //["bq","aa","aqq"]
        public string Main(string S, int[] indexes, string[] sources, string[] targets)
        {
            string modifiedString = S; int modifiedIndex = 0;

            for (int i = 0; i < indexes.Length; i++)
            {
                int subStringLength = sources[i].Length;
                string subString = S.Substring(indexes[i], subStringLength);
                

                if (subString.Equals(sources[i]))
                {
                    modifiedString = modifiedString.Remove(modifiedIndex, subStringLength);
                    modifiedString = modifiedString.Insert(modifiedIndex, targets[i]);
                    modifiedIndex += targets[i].Length + 1;
                }
            }

            return modifiedString;
        }

        public string FindReplaceString(string S, int[] indexes, string[] sources, string[] targets)
        {
            List<Tuple<int, int>> sorted = new List<Tuple<int, int>>();
            for (int i = 0; i < indexes.Length; i++)
            {
                sorted.Add(new Tuple<int, int>(indexes[i], i));
            }

            // Sort list in descending order
            sorted.Sort((a, b) => -1 * a.Item1.CompareTo(b.Item1)); // <-- key to solution

            for (int i = 0; i < sorted.Count; i++)
            {
                int startIndex = sorted[i].Item1;
                string source = sources[sorted[i].Item2];
                string target = targets[sorted[i].Item2];

                if (S.Substring(startIndex, source.Length) == source)
                {
                    S = S.Substring(0, startIndex) + target + S.Substring(startIndex + source.Length);
                }
            }

            return S;
        }
    }
}
