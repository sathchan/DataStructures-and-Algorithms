using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class PalindromeInteger
    {
        //Method -1: Reverse the Int 
        public bool IsPalindrome1(int num)
        {
            if (Math.Sign(num) == -1) return false;
            if (num == 0) return true;

            int temp = num;
            int counter = 0, reversedNum = 0;
            while (temp != 0)
            {
                int y = temp % 10;
                temp /= 10;

                reversedNum += y * (int)Math.Pow(10, num.ToString().ToCharArray().Length - counter - 1);
                counter++;
            }

            return (reversedNum == num) ? true : false;
        }

        //Method -2: Comparison with First & Last & so-on - 4987894
        public bool IsPalindrome2(int num)
        {
            int[] numArray = Array.ConvertAll(num.ToString("0").ToCharArray(), ch => ch - '0');

            for (int i = 0, j = numArray.Length - 1; i < numArray.Length && j >= 0; i++, j-- )
	        {
                if (numArray[i] != numArray[j]) return false;
            }

            return true;
        }
    }
}
