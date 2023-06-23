using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    // binary array - nums
    // Return max length of contiguous subarray with equal number of 0 and 1
    public class Problem525
    {
        // Equal number of 0 and 1..means... even number array...so odds are out
        // Take max length of the array
        // -- If odd, then potential max is odd - 1
        // -- If even, then potential is the even
        // If the sub array there doesn't fit then let's subtract 2...and organize the array into sub array

        public int FindMaxLength(int[] nums)
        {
            if (nums.Count() == 1)
            {
                return 0;
            }

            var partitionSize = nums.Count();
            if (nums.Count() % 2 == 1)
            {
                partitionSize = partitionSize - 1;
            }

            var balanceCount = 0;
            var startingIndex = 0;
            while (true)
            {
                var endingIndex = startingIndex + partitionSize;
                if (endingIndex > nums.Count() && startingIndex < nums.Count())
                {
                    partitionSize = partitionSize - 2;
                    startingIndex = 0;
                    continue;
                }

                if (partitionSize <= 0) {
                    return 0;
                }

                if (startingIndex >= nums.Count())
                {
                    break;
                }

                for (var i = startingIndex; i < endingIndex; i++)
                {
                    if (nums[i] == 0)
                    {
                        balanceCount--;
                    }
                    else if (nums[i] == 1)
                    {
                        balanceCount++;
                    }
                }

                if (balanceCount == 0)
                {
                    return partitionSize;
                }

                startingIndex++;
                balanceCount = 0;
            }

            return 0;

        }
    }
}
