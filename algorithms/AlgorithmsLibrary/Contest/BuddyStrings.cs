using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsLibrary
{
    public class BuddyStrings
    {
        public bool Main(string A, string B)
        {
            if (A == null || B == null) return false;
            if (A.Length != B.Length) return false;
            if (A.Length < 2 || B.Length < 2) return false; // not swappable

            if (A.Equals(B))
            {
                return HasDuplicatedLetter(A);
            }
            else
            {
                int diffCount = 0; // counter of different positions
                int diff = 0; // total difference between A and B
                for (int i = 0; i < A.Length; i++)
                {
                    char a = A[i];
                    char b = B[i];
                    if (a != b)
                    {
                        diffCount++;
                        if (diffCount > 2) return false; // impossible to swap if different places is more than 2
                        diff += a - b;
                    }
                }

                if (diff != 0) return false; // diff shoud be 0 if A and B contain same characters
                return true;
            }
        }

        private bool HasDuplicatedLetter(String s)
        {
            int[] temp = new int[128]; // A and B consist only of lowercase letters.
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (temp[ch] != 0)
                {
                    return true;
                }
                else
                {
                    temp[ch]++;
                }
            }
            return false;
        }
    }
}
