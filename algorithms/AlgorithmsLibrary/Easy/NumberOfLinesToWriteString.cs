using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class NumberOfLinesToWriteString
    {
        public int[] Main(int[] widths, string S)
        {
            int lineCounter = 0, unitCounter = 0;

            foreach (var item in S)
            {
                int index = (int)item - 97;
                if (unitCounter + widths[index] > 100)
                {
                    lineCounter++;
                    unitCounter = widths[index];
                }
                else
                {
                    unitCounter += widths[index];
                }
            }

            lineCounter = (unitCounter > 0) ? ++lineCounter : lineCounter;

            return new int[] { lineCounter, unitCounter };

        }
    }
}
