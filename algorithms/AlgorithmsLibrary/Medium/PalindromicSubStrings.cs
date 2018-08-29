namespace AlgorithmsLibrary.Medium
{
    /*
     
        Palindromic Substrings
        -----------------------

        Given a string, your task is to count how many palindromic substrings in this string.

        The substrings with different start indexes or end indexes are counted as different substrings even they consist of same characters.

        Example 1:
        Input: "abc"
        Output: 3
        Explanation: Three palindromic strings: "a", "b", "c".

        Example 2:
        Input: "aaa"
        Output: 6
        Explanation: Six palindromic strings: "a", "a", "a", "aa", "aa", "aaa".
        
        Note:
        The input string length won't exceed 1000.

        647: https://leetcode.com/problems/palindromic-substrings/description/     
     */

    public class PalindromicSubStrings
    {
        int count;
        public int CountSubstrings(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            for (int i = 0; i < s.Length; i++)
            {
                CountSubstringsHelper(s, i, i);     //odd length
                CountSubstringsHelper(s, i, i + 1);  //even length
            }
            return this.count;
        }

        private void CountSubstringsHelper(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length)
            {
                if (s[left--] == s[right++])
                    this.count++;
                else
                    break;
            }
        }
    }
}
