using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    // Replace element on the right with the greatest number
    // Last one is always -1
    public class Problem1299
    {
        public int[] ReplaceElements(int[] arr)
        {
            var answer = new int[arr.Length];
            var maxValue = -1;
            answer[arr.Length - 1] = maxValue;
            for (int i = arr.Length - 1; i > 0 ; i--)
            {
                var currentValue = arr[i];
                if (currentValue > maxValue)
                {
                    maxValue = arr[i];
                }
                answer[i - 1] = maxValue;
            }

            return answer;
        }
    }
}
