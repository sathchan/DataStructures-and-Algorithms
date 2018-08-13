using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class ShortestSubArrayLength
    {
        //{1, 11, 100, 1, 0, 200, 3, 2, 1, 250}, sum = 280
        //48, 99, 37, 4, -31 140
        public int Main(int[] A, int K)
        {
            int length = int.MaxValue, start = 0, sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (i < A.Length)
                    sum = sum + A[i];

                if (sum > K || sum == K)
                {
                    length = Math.Min((i - 1) + 1, length);
                }

                while (sum > K)
                {
                    sum = sum - A[start];
                    start++;
                }                

                
                
            }

            return (length == int.MaxValue) ? -1 : length;
        }
    }
}
