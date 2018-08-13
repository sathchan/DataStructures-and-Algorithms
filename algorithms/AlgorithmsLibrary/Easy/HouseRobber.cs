using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class HouseRobber
    {
        public int Main(int[] nums) //2112
        {
            int a = 0; //2 3
            int b = 0; //2 4

            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0) 
                {
                    a = Math.Max(a + nums[i], b); //2 3
                }
                else
                {
                    b = Math.Max(a, b + nums[i]); //2 4
                }
            }

            return Math.Max(a, b);
        }
    }
}
