using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class KDistanceForSimilarStrings
    {
        public int Main(string A, string B)
        {
            int differences = int.MaxValue;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != B[i])
                {
                    int[] swapIndex = new int[] { };
                    int counter = 0;
                    for (int j = i + 1; j < B.Length; j++)
                    {
                        if (B[j] == A[i])
                        {
                            swapIndex[counter] = j;                           
                        }                            
                    }

                    for (int k = 0; k < swapIndex.Length; k++)
                    {
                        char temp = B[i];
                        B = B.Remove(i, 1);
                        B = B.Insert(i, A[i].ToString());
                        //B = B.Remove(swapIndex, 1);
                        //B = B.Insert(swapIndex, temp.ToString());
                    }


                    

                    differences++;
                }
            }

            return differences;
        }
    }
}
