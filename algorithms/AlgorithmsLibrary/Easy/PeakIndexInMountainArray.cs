using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class PeakIndexInMountainArray
    {
        public int Main(int[] A)
        {
            int i = 0, j = 1;

            while (j <= A.Length - 1)
            {
                if (A[i] > A[j])
                {
                    return i;
                }

                i++; j++;
            }

            return 0;
        }
    }
}
