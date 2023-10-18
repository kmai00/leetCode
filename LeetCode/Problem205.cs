using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Problem205
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var charMap = new Dictionary<char, char>();
            for (var i = 0; i < s.Length; i++)
            {
                var sChar = s[i];
                var tChar = t[i];

                if (charMap.ContainsKey(sChar))
                {
                    var tCandidate = charMap[sChar];

                    if (tCandidate != tChar)
                    {
                        return false;
                    }
                }
                else
                {
                    if (charMap.ContainsValue(tChar)) {
                        return false;
                    }
                    charMap.Add(sChar, tChar);
                }
            }

            return true;
        }
    }
}
