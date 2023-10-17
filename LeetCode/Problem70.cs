using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Problem70
    {
        public int ClimbStairs(int n)
        {
            var answer = ClimbStairs(n, new Dictionary<int, int>());
            return answer;
        }

        private int ClimbStairs(int target, Dictionary<int, int> memoized)
        {
            if (target == 0)
            {
                return 1;
            }
            else if (target < 0)
            {
                return 0; //Not possible
            }
            else if (memoized.ContainsKey(target)) { 
                return memoized[target];
            }

            var possibleWays = ClimbStairs(target - 1, memoized) + ClimbStairs(target - 2, memoized);
            memoized.Add(target, possibleWays);

            return possibleWays;
        }
    }
}
