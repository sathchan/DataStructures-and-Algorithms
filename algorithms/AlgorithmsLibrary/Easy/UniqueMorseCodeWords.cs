using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class UniqueMorseCodeWords
    {
        public int Main(string[] words)
        {
            string[] alphabets = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

            Dictionary<string, string> transformationDict = new Dictionary<string, string>();            

            foreach (var item in words)
            {
                StringBuilder transformation = new StringBuilder();
                foreach (char itemChar in item)
                {
                    transformation.Append(alphabets[(int)itemChar - 97]);
                }

                if (!transformationDict.ContainsKey(transformation.ToString()))
                {
                    transformationDict.Add(transformation.ToString(), transformation.ToString());                    
                }
            }
            
            return transformationDict.Count;

        }
    }
}
