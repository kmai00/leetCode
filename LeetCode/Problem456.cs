using System;
using System.Linq;

namespace LeetCode
{
    //Problem 456 - Medium
    // 132 problem

    //Given an array of n integers nums, a 132 pattern is a subsequence of three integers nums[i], nums[j] and nums[k] such that i < j < k and nums[i] < nums[k] < nums[j].
    //Return true if there is a 132 pattern in nums, otherwise, return false.

    public class Problem456
    {
        // Idea number one: Binary tree

        public bool Find132Pattern(int[] nums)
        {
            if (!nums.Any())
            {
                return false;
            }

            //Choose Pivot
            // Find lowest on the left half
            // Find anything greater than left 
            // returns true if lowest on the right is bigger than left but also smaller than the pivot

            var pivotIndex = nums.Length / 2;

            return Find132Pattern(pivotIndex, 0, nums.Length - 1, nums);
        }

        public bool Find132Pattern(int pivotIndex, int leftEnd, int rightEnd, int[] nums)
        {
            var pivotValue = nums[pivotIndex];

            var leftNums = new int[pivotIndex];
            if (!leftNums.Any())
            {
                return false;
            }
            Array.Copy(nums, 0, leftNums, 0, pivotIndex);
            var leftMin = leftNums.Min();

            var rightNumsAmount = nums.Length - pivotIndex - 1;
            var rightNums = new int[rightNumsAmount];
            if (!rightNums.Any())
            {
                return false;
            }
            Array.Copy(nums, pivotIndex + 1, rightNums, 0, rightNumsAmount);
            foreach (var rightValue in rightNums)
            {
                if (rightValue < pivotValue && rightValue > leftMin)
                {
                    return true;
                }
            }


            //It's cause....when i go into the deeper layer...i need to check all left pivots, then all right pivots

            var leftPivot = pivotIndex - 1;
            var rightPivot = pivotIndex + 1;

            var hasPattern = false;
            if (leftPivot <= 0 || leftPivot <= leftEnd)
            {
                hasPattern = false;
            }
            else
            {

                hasPattern = Find132Pattern(leftPivot, leftEnd, leftPivot, nums);
            }

            if (!hasPattern)
            {
                if (rightPivot >= nums.Length - 1 || rightPivot >= rightEnd)
                {
                    hasPattern = false;
                }
                else
                {
                    hasPattern = Find132Pattern(rightPivot, rightPivot, rightEnd, nums);
                }
            }

            return hasPattern;
        }
    }
}
