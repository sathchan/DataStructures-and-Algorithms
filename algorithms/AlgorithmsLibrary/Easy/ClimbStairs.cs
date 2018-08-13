using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class ClimbStairs
    {
        public int Main(int n)
        {
            if (n == 0) return 1;

            return n * Main(n - 1);
        }
    }
}
