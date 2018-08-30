using System;

namespace AlgorithmsLibrary.Medium
{
    /*
     
        Counting Bits
        ----------------

        Given a non negative integer number num. For every numbers i in the range 0 ≤ i ≤ num calculate the number of 1's in their binary representation and return them as an array.

        Example 1:

        Input: 2
        Output: [0,1,1]
        Example 2:

        Input: 5
        Output: [0,1,1,2,1,2]

        338: https://leetcode.com/problems/counting-bits/description/
     */

    public class NumOf1sInBinary
    {
        public int[] CountBits(int num)
        {
            if (num == 0) return new int[] { 0 };

            int[] result = new int[++num]; int index = -1;
            for (int i = 0; i < num; i++)
            {
                int value = i;
                string binary = Convert.ToString(value, 2);

                int count1 = 0;
                foreach (var charItem in binary.ToCharArray())
                {
                    if (charItem == '1') count1++;
                }

                result[++index] = count1;
            }

            return result;
        }
    }
}
