using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsLibrary
{
    public class GoatLatin
    {
        public string Main(string S)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            StringBuilder goatLatin = new StringBuilder();
            int counter = 1;

            foreach (var word in S.Split(" "))
            {
                if (vowels.Contains(word[0]))
                {
                    goatLatin.Append(word + "ma");
                }
                else
                {
                    string replaceWord = word[0].ToString();                    
                    goatLatin.Append(word.Remove(0, 1) + replaceWord + "ma");
                }

                int i = counter;

                while (i > 0)
                {
                    goatLatin.Append("a");
                    i--;
                }

                counter++;
                goatLatin.Append(" ");

            }

            return goatLatin.ToString().Remove(goatLatin.Length - 1);
        }
    }
}
