using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Problem9
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false; // There will be a negative sign so it will not be true
            }

            var reverseDigits = new List<int>();

            var value = x;
            while (value > 0)
            {
                var digit = value % 10;
                reverseDigits.Add(digit);
                value = value / 10;
            }

            var orderedDigits = reverseDigits.ToList(); // Make a copy
            orderedDigits.Reverse();

            for (var i = 0; i < orderedDigits.Count; i++)
            {
                if (orderedDigits[i] != reverseDigits[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
