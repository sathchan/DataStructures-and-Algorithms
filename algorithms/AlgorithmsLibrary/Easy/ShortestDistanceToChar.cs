using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsLibrary
{
    public class ShortestDistanceToChar
    {
        public int[] Main(string S, char C)
        {
            if (string.IsNullOrEmpty(S) || C == ' ') return null;

            int[] charDistance = new int[S.Length]; int i = 0; int distance = 1;
            int[] shortestDistance = new int[S.Length];
            foreach (var charOfS in S)
            {
                if (charOfS.Equals(C))
                {
                    charDistance[i] = distance;
                    i++;
                }

                distance++;
            }

            for (int j = 1; j <= S.Length; j++)
            {
                int difference = int.MaxValue;
                foreach (var item in charDistance.Where(a => a != 0))
                {
                    difference = Math.Min(Math.Abs(item - j), difference);
                }

                shortestDistance[j - 1] = difference;
            }

            return shortestDistance;
        }
    }
}
