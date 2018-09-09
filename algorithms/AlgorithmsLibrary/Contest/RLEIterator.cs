using System.Collections.Generic;

namespace AlgorithmsLibrary
{
    public class RLEIterator
    {
        int[] IteratedA = null; int nextIndex = 0;
        public RLEIterator(int[] A)
        {
            List<int> tempIterator = new List<int>();
            IteratedA = new int[A.Length];
            for (int i = 0; i < A.Length; i += 2)
            {
                for (int j = 0; j < A[i]; j++)
                {
                    tempIterator.Add(A[i + 1]);
                }
            }

            IteratedA = tempIterator.ToArray();
        }

        public int Next(int n)
        {
            int output = -1;
            nextIndex += n;

            if (IteratedA.Length < nextIndex)
            {
                IteratedA = new int[] { }; //Reset so next value is taken from the latest
                return output;
            }
            else
            {
                return IteratedA[nextIndex -1];
            }           
        }
    }
}
