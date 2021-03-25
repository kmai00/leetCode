using System;
using System.Collections.Generic;
using System.Linq;
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

            var count = 0;

            var duplicateCount = new Dictionary<int, int>();
            var uniqueNumber = new List<int>();
            foreach (var num in nums)
            {
                var value = duplicateCount.ContainsKey(num) ? duplicateCount[num] + 1 : 1; // This operation isn't needed
                duplicateCount[num] = value;

                if (value == 1)
                {
                    uniqueNumber.Add(num);
                }
            }

            for (var i = 0; i < uniqueNumber.Count - 1; i++)
            {
                for (var j = i + 1; j < uniqueNumber.Count; j++)
                {
                    var num1 = uniqueNumber[i];
                    var num2 = uniqueNumber[j];
                    var result = Math.Abs(num1 - num2);
                    if (result == k)
                    {
                        count++;
                    }
                }
            }

            if (k == 0)
            {
                var duplicates = duplicateCount.Where(kp => kp.Value > 1).Select(kp => kp.Value).ToList();
                foreach (var dup in duplicates)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
