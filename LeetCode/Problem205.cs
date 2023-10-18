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

            var sCharMap = new Dictionary<char, char>();
            var tCharMap = new Dictionary<char, char>();
            for (var i = 0; i < s.Length; i++)
            {
                var sChar = s[i];
                var tChar = t[i];

                if (sCharMap.ContainsKey(sChar) && tCharMap.ContainsKey(tChar))
                {
                    var tCandidate = sCharMap[sChar];
                    var sCandidate = tCharMap[tChar];

                    if (sChar != sCandidate || tCandidate != tChar)
                    {
                        return false;
                    }
                }
                else if (sCharMap.ContainsKey(sChar) && !tCharMap.ContainsKey(tChar)) {
                    return false;
                }
                else if (!sCharMap.ContainsKey(sChar) && tCharMap.ContainsKey(tChar)) {
                    return false;
                }
                else
                {
                    sCharMap.Add(sChar, tChar);
                    tCharMap.Add(tChar, sChar);
                }
            }

            return true;
        }
    }
}
