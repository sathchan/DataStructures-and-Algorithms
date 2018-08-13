using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class MaxDistanceToClosest
    {
        public int Main(int[] seats)
        {
            int previous1Index = int.MinValue, maxDistanceIndex = 0, tempDistanceCounter = 0;

            for (int i = 0; i < seats.Length; i++)
            {
                if (seats[i] == 1 && previous1Index != int.MinValue)
                {
                    tempDistanceCounter = Math.Abs(((i + 1) - previous1Index) / 2);
                    previous1Index = i;
                }
                else if (seats[i] == 1)
                {
                    previous1Index = i;
                }

                maxDistanceIndex = (i == seats.Length - 1 && seats[i] == 0) ? Math.Max(i - previous1Index, maxDistanceIndex) : Math.Max(tempDistanceCounter, maxDistanceIndex);
            }

            return maxDistanceIndex;
        }

        public int maxDistToClosest(int[] seats)
        {
            int N = seats.Length;
            int prev = -1, future = 0;
            int ans = 0;

            for (int i = 0; i < N; ++i)
            {
                if (seats[i] == 1)
                {
                    prev = i;
                }
                else
                {
                    while (future < N && seats[future] == 0 || future < i)
                        future++;

                    int left = prev == -1 ? N : i - prev;
                    int right = future == N ? N : future - i;
                    ans = Math.Max(ans, Math.Min(left, right));
                }
            }

            return ans;
        }
    }
}
