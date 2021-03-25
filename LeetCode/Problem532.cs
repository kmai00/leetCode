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
            var uniqueNumbers = new HashSet<int>();
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
                    uniqueNumbers.Add(num);
                    duplicates.Add(num, false);
                }
            }

            if (k == 0)
            {
                return duplicateCount;
            }

            foreach (var uniqueNumber in uniqueNumbers)
            {
                var result = uniqueNumber + k;
                if (uniqueNumbers.Contains(result)){
                    count++;
                }
            }


            return count;
        }
    }
}
