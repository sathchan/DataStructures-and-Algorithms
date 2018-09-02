using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class IsMonotonicArray
    {
        public bool IsMonotonic(int[] A)
        {
            if (!IsMonotonicIncreasing(A) && !IsMonotonicDecreasing(A)) return false;
            return true;
        }

        public bool IsMonotonicIncreasing(int[] A)
        {
            int i = 0;
            for (int j = 1; j < A.Length; j++)
            {
                if (A[i] <= A[j]) i++;
                else return false;
            }

            return true;
        }

        public bool IsMonotonicDecreasing(int[] A)
        {
            int i = 0;
            for (int j = 1; j < A.Length; j++)
            {
                if (A[i] >= A[j]) i++;
                else return false;
            }

            return true;
        }

    }

}
