using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    // K-diff Pairs in an Array
    // Medium

    // Given an array of integers nums and an integer k, return the number of unique k-diff pairs in the array.

    // A k-diff pair is an integer pair (nums[i], nums[j]), where the following are true:

    // 0 <= i, j<nums.length
    // i != j
    // |nums[i] - nums[j]| == k
    // Notice that |val| denotes the absolute value of val.

    public class Problem532
    {
        public int FindPairs(int[] nums, int k)
        {
            // Unique number and the amount of number that can be paired to equal k
            // Need to add non zero to the end to get count

            var uniqueNumberPairCount = new Dictionary<string, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < nums.Length; j++)
                {
                    var num1 = nums[i];
                    var num2 = nums[j];
                    var keyPair = $"{Math.Min(num1, num2)}-{Math.Max(num1, num2)}";
                    if (i == j || uniqueNumberPairCount.ContainsKey(keyPair))
                    {
                        continue;
                    }

                    var result = Math.Abs(num1 - num2);
                    if (result == k)
                    {
                        uniqueNumberPairCount.Add(keyPair, 0);
                    }
                }
            }

            return uniqueNumberPairCount.Keys.Count;
        }
    }
}
