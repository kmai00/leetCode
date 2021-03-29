using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    // Problem 594. Longest Harmonious Subsequence
    // Easy

    //We define a harmonious array as an array where the difference between its maximum value and its minimum value is exactly 1.

    //Given an integer array nums, return the length of its longest harmonious subsequence among all its possible subsequences.

    //A subsequence of array is a sequence that can be derived from the array by deleting some or no elements without changing the order of the remaining elements.

    public class Problem594
    {
        public int FindLHS(int[] nums)
        {
            var numberCount = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (numberCount.ContainsKey(num))
                {
                    numberCount[num]++;
                }
                else
                {
                    numberCount[num] = 1;
                }
            }

            var biggestCount = 0;
            foreach (var number in numberCount)
            {
                var bigPartner = number.Key + 1;
                var smallCount = 0;
                if (numberCount.ContainsKey(bigPartner))
                {
                    smallCount = number.Value + numberCount[bigPartner];
                }

                var smallPartner = number.Key - 1;
                var bigCount = 0;
                if (numberCount.ContainsKey(smallPartner))
                {
                    bigCount = number.Value + numberCount[smallPartner];
                }

                var result = Math.Max(bigCount, smallCount);
                if (result > biggestCount)
                {
                    biggestCount = result;
                }
            }

            return biggestCount;
        }
    }
}
