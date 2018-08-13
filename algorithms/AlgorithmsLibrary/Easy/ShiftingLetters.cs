using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class ShiftingLetters
    {
        public string Main(string S, int[] shifts)
        {
            for (int i = 0; i < shifts.Length; i++) // 3 5 9
            {
                for (int j = 0; j < i + 1; j++) //a b c
                {
                    int counter = shifts[i];
                    while (counter != 0)
                    {
                        int temp = (S[j] == 'z' ? 'a' : (char)(S[j] + 1));
                        S = S.Remove(j, 1);
                        S = S.Insert(j, ((char)temp).ToString());                                               
                        counter--;
                    }
                }
            }

            return S;
        }
    }
}
