using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class JewelsAndStones
    {
        public int Main(string J, string S)
        {
            int numOfJewels = 0;
            foreach (var jewel in J)
            {
                foreach (var stone in S)
                {
                    if ((int)jewel == (int)stone) numOfJewels++;
                }
            }

            return numOfJewels;
        }
    }
}
