using System;

namespace AlgorithmsLibrary
{
    /*
        Arbitrary Product
        -------------

        Example1:
        Input = {2, 3}, {6} 
        Output = {1, 3, 8}

        Example2:
        Input = {2, 3}, {4, 6} 
        Output = {1, 0, 5, 8}
     */

    public class ArbitraryIntProduct
    {
        public int[] Main(int[] A, int[] B)
        {
            int total = 0;

            for (int i = A.Length - 1; i >= 0; i--)
            {
                int rowSum = 0;
                for (int j = B.Length - 1; j >= 0; j--)
                {
                    rowSum += (A[i] * B[j]) * Convert.ToInt32(Math.Pow(10, ((B.Length - 1) - j)));
                }

                total += rowSum * Convert.ToInt32(Math.Pow(10, ((A.Length - 1) - i)));
            }

            return Array.ConvertAll(total.ToString("0").ToCharArray(), ch => ch - '0');
        }

    }
}