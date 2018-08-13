using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class DailyTemperatures
    {
        //73, 74, 75, 71, 69, 72, 76, 73
        //1, 1, 4, 2, 1, 1, 0, 0
        public int[] Main(int[] temperatures)
        {
            Stack<int> stack = new Stack<int>();
            int[] ret = new int[temperatures.Length];
            for (int i = 0; i < temperatures.Length; i++)
            {
                while (stack.Count != 0 && temperatures[i] > temperatures[stack.Peek()])
                {
                    int idx = stack.Pop();
                    ret[idx] = i - idx;
                }
                stack.Push(i);
            }
            return ret; 
        }
    }
}
