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
            var duplicateCount = 0;

            var duplicates = new Dictionary<int, bool>();
            var uniqueNumber = new List<int>();
            foreach (var num in nums)
            {
                if (duplicates.ContainsKey(num) && !duplicates[num])
                {
                    duplicateCount++;
                    duplicates[num] = true;
                }
                else if (duplicates.ContainsKey(num) && duplicates[num])
                {
                    continue;
                }
                else
                {
                    uniqueNumber.Add(num);
                    duplicates.Add(num, false);
                }
            }

            if (k == 0)
            {
                return duplicateCount;
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


            return count;
        }
    }
}
