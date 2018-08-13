using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class HammingDistance
    {
        public int Main(int x, int y)
        {
            string xBinary = Convert.ToString(x, 2);
            string yBinary = Convert.ToString(y, 2);
            int noOfDifferences = 0;

            if (xBinary.Length < yBinary.Length)
            {
                xBinary = xBinary.PadLeft(yBinary.Length, '0');
            }
            else if (yBinary.Length < xBinary.Length)
            {
                yBinary = yBinary.PadLeft(xBinary.Length, '0');
            }

            for (int i = 0, j = 0; i < xBinary.Length && j < yBinary.Length; i++, j++)
            {
                if (xBinary[i] != yBinary[j]) noOfDifferences++;
            }

            return noOfDifferences;
        }
    }
}
