using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    // Implement strStr()/indexOf
    // Return -1, when cannot be found
    // Return 0, on empty string
    // Return x, which the first occurence of the substring
    public class Problem28
    {
        public int StrStr(string haystack, string needle)
        {
            // Attempt 2
            // Count the "correctness"
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            if (needle.Length > haystack.Length)
            {
                return -1;
            }

            var sizeLimit = haystack.Length - needle.Length;
            var correctness = 0;
            for (var startingIndex = 0; startingIndex <= sizeLimit; startingIndex++)
            {
                for (var j = 0; j < needle.Length; j++)
                {
                    if (haystack[startingIndex + correctness] != needle[j])
                    {
                        break;
                    }
                    correctness++;
                }

                if (correctness == needle.Length)
                {
                    return startingIndex;
                }
                correctness = 0;
            }

            return -1;
        }

        public int StrStr_Attempt1(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            if (needle.Length > haystack.Length)
            {
                return -1;
            }

            // Find all potential candidate
            // Then string compare to see if it's the same

            var candidates = new List<string>();
            var candidatesIndex = new List<int>();
            for (var i = 0; i + needle.Length <= haystack.Length; i++)
            {
                if (haystack[i] != needle[0])
                {
                    continue;
                }

                var candidate = haystack.Substring(i, needle.Length);
                candidatesIndex.Add(i);
                candidates.Add(candidate);
            }

            var startingIndex = -1;
            for (var i = 0; i < candidates.Count; i++)
            {
                var candidate = candidates[i];
                if (candidate == needle)
                {
                    startingIndex = candidatesIndex[i];
                    break;
                }
            }

            return startingIndex;
        }
    }
}
