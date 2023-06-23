using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Problem1480
    {
        public int[] RunningSum(int[] nums)
        {
            var resultList = new int[nums.Length];
            var currentResult = nums[0];
            resultList[0] = currentResult;

            for (var i = 1; i < nums.Length; i++) {
                currentResult += nums[i];
                resultList[i] = currentResult; 
            }

            return resultList;
        }
    }
}
