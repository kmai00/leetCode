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
            // Let's try something dumb first...

            var numberTracker = new HashSet<int>(); // Key and count
            var biggestCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var smallCount = 0;
                var bigCount = 0;
                var isOnlyKey = true;
                var key = nums[i];
                if (numberTracker.Contains(key))
                {
                    continue; //skip cause we already counted you
                }
                else
                {
                    smallCount = 1;
                    bigCount = 1;
                }

                for (int j = i + 1; j < nums.Length; j++)
                {
                    var candidate = nums[j];
                    // Count for when I'm the smallest
                    // Count for when I'm the biggest
                    // Take the bigger Count

                    if (candidate == key) // TODO need to count whenever it's not the only one in the list...
                    {
                        smallCount++;
                        bigCount++;
                    }
                    else if (key + 1 == candidate)
                    {
                        bigCount++;
                        isOnlyKey = false;
                    }
                    else if (key - 1 == candidate)
                    {
                        smallCount++;
                        isOnlyKey = false;
                    }

                }

                var higherCount = isOnlyKey ? 0 : Math.Max(smallCount, bigCount);

                if (higherCount > biggestCount)
                {
                    biggestCount = higherCount;
                }

            }

            return biggestCount;
        }
    }
}
