using System;
using System.Collections.Generic;

namespace AlgorithmsLibrary
{
    /*
     * https://leetcode.com/problems/two-sum/description/ 
     * 
     *      int[] nums = new int[] { 5, 3, 2, 17, 7, 11, 15 };
            var result = obj.TwoSum(nums, 9);
            Console.WriteLine("The indices are {0}, {1}", result[0].ToString() , result[1]);
     * 
     */

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numsHash = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!numsHash.ContainsKey(nums[i]))
                    numsHash.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int lookup = target - nums[i];

                if (numsHash.ContainsKey(lookup))
                {
                    int hashValue = 0;
                    numsHash.TryGetValue(lookup, out hashValue);
                    return new int[] { i, hashValue };
                }

            }

            return new int[2];
        }
    }
}
