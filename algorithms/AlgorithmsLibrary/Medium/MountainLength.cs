using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class MountainLength
    {
        public int Main(int[] A)
        {
            bool isMountainStarted = false, isPeakReached = false;
            int mountainLengthCounter = 0, tempMountainLengthCounter = 0;

            if (A.Length == 0) return 0;

            int temp = A[0];

            for (int i = 1; i < A.Length; i++) //0-2, 1-1, 2-4, 3-7, 4-3, 5-2, 6-5
            {
                if (temp < A[i] && !isMountainStarted)
                {
                    isMountainStarted = true;
                    tempMountainLengthCounter++;
                    continue;
                }
                if (temp < A[i] && !isPeakReached)
                {
                    tempMountainLengthCounter++;
                }
                else if (temp > A[i] && isMountainStarted)
                {
                    isPeakReached = true;
                    tempMountainLengthCounter++;
                }
                else if (temp > A[i] && isPeakReached)
                {
                    tempMountainLengthCounter++;
                }
                else if (temp < A[i] && isPeakReached)
                {
                    isMountainStarted = false;
                    isPeakReached = false;
                    mountainLengthCounter = (Math.Max(mountainLengthCounter, tempMountainLengthCounter) + 1);
                    tempMountainLengthCounter = 0;
                }

                temp = A[i];
            }

            return mountainLengthCounter;

        }

        public int longestMountain(int[] A)
        {
            int res = 0, up = 0, down = 0;
            for (int i = 1; i < A.Length; ++i)
            {
                if (down > 0 && A[i - 1] < A[i] || A[i - 1] == A[i]) up = down = 0;
                if (A[i - 1] < A[i]) up++;
                if (A[i - 1] > A[i]) down++;
                if (up > 0 && down > 0 && up + down + 1 > res) res = up + down + 1;
            }
            return res;
        }
    }
}
