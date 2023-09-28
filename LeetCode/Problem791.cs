using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public static class Problem791
    {
        public static string CustomSortString(string order, string s)
        {
            // I want to check out if the current order char is in s
            // If so then add those until s went through
            // If not and I meet the end of S, then move to the next ordered

            var result = string.Empty;

            var remainingChars = s.ToList();

            foreach (var orderChar in order)
            {
                var i = 0;
                while (i < remainingChars.Count)
                {
                    var potentialChar = remainingChars[i];
                    if (orderChar == potentialChar)
                    {
                        result += potentialChar;
                        remainingChars.RemoveAt(i);
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            return result + string.Join(string.Empty, remainingChars);
        }
    }
}
