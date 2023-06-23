using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Assessment1
    {
        // Input
        // paragraph is a string of a setence
        // banned is an array of words that's banned

        // Out
        // string value of the most repeated non-banned words

        public string MostCommonWord(string paragraph, string[] banned)
        {
            // TODO loop character filter to clean this up (handling ending punction)
            var cleanParagraph = paragraph.Replace('!', ' ');
            cleanParagraph = cleanParagraph.Replace('?', ' ');
            cleanParagraph = cleanParagraph.Replace(';', ' ');
            cleanParagraph = cleanParagraph.Replace('.', ' ');
            cleanParagraph = cleanParagraph.Replace(',', ' ');
            cleanParagraph = cleanParagraph.Replace('\'', ' ');
            cleanParagraph = cleanParagraph.ToLower();

            var wordDict = new Dictionary<string, int>();
            var cleanBanned = banned.ToHashSet(StringComparer.OrdinalIgnoreCase);
            var words = cleanParagraph.Split(' ').Where(c => !string.IsNullOrWhiteSpace(c)).ToList();
            foreach (var word in words)
            {
                if (cleanBanned.Contains(word))
                {
                    continue;
                }

                if (wordDict.ContainsKey(word))
                {
                    wordDict[word]++;
                }
                else
                {
                    wordDict[word] = 1;
                }
            }

            var mostRepeatedWord = wordDict.Aggregate((cur, next) => cur.Value > next.Value ? cur : next).Key;
            return mostRepeatedWord;
        }

    }
}
