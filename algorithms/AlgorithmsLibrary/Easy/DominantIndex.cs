using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class DominantIndex
    {
        public int Main(int[] nums)
        {
            if (nums == null || nums.Length == 0) return -1;
            if (nums.Length == 1) return 0;

            int firstLargestIndex = 0, firstLargestValue = 0, secondLargestIndex = 0, secondLargestValue = 0;

            if (nums[0] > nums[1])
            {
                firstLargestIndex = 0; firstLargestValue = nums[0];
                secondLargestIndex = 1; secondLargestValue = nums[1];
            }
            else
            {
                firstLargestIndex = 1; firstLargestValue = nums[1];
                secondLargestIndex = 0; secondLargestValue = nums[0];
            }


            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i] > firstLargestValue)
                {
                    secondLargestIndex = firstLargestIndex;
                    secondLargestValue = firstLargestValue;
                    firstLargestIndex = i;
                    firstLargestValue = nums[i];
                }
                else if (nums[i] > secondLargestValue)
                {
                    secondLargestIndex = i;
                    secondLargestValue = nums[i];                    
                }
            }

            return (secondLargestValue * 2 <= firstLargestValue) ? firstLargestIndex : -1;
        }
    }
}
