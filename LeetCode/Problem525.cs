using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LeetCode
{
    // binary array - nums
    // Return max length of contiguous subarray with equal number of 0 and 1
    public class Problem525
    {
        public int FindMaxLength(int[] nums)
        {
            // Value, Index
            var valueDict = new Dictionary<int, int>();
            valueDict.Add(0, -1);
            var maxLength = 0;
            var count = 0;
            for (var i = 0; i < nums.Count(); i++) {
                count = count + (nums[i] == 1 ? 1 : -1);
                if (valueDict.ContainsKey(count))
                {
                    maxLength = Math.Max(maxLength, i - valueDict[count]);
                }
                else { 
                    valueDict.Add(count, i);
                }
            }

            return maxLength;
        }
    }
}
