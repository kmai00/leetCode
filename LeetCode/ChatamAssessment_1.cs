using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Stats
    {
        // Total number of all words in the document
        public int NumberOfAllWords { get; set; }

        // Returns number of words that consist only from digits e.g. 13455, 98374
        public int NumberOfWordsThatContainOnlyDigits { get; set; }

        // Returns number of words that start with a lower letter e.g. a, d, z
        public int NumberOfWordsStartingWithSmallLetter { get; set; }

        // Returns number of words that start with a capital letter e.g. A, D, Z
        public int NumberOfWordsStartingWithCapitalLetter { get; set; }

        // Returns the first longest word in the document
        public string TheLongestWord { get; set; }

        // Returns the first shortest word in the document
        public string TheShortestWord { get; set; }
    }

    public class ChatamAssessment_1
    {
        public Stats Analyze(string document)
        {
            if (document == null)
            {
                throw new ArgumentNullException();
            }

            //I'm assuming no stats on empty documents
            if (string.IsNullOrWhiteSpace(document))
            {
                return new Stats();
            }

            //There might be some bad data between each words which results in empty entries
            var words = document.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var onlyDigitCount = 0;
            var startLowercaseCount = 0;
            var startUppercaseCount = 0;

            var longestWord = string.Empty;
            var shortestWord = string.Empty;
            foreach (var word in words)
            {

                var isDigit = word.All(char.IsDigit);
                if (isDigit)
                {
                    onlyDigitCount++;
                }

                var startingChar = word[0];
                if (char.IsLower(startingChar))
                {
                    startLowercaseCount++;
                }
                //Explicit checking in case words start with symbols/digits
                if (char.IsUpper(startingChar))
                {
                    startUppercaseCount++;
                }

                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }

                if (word.Length < shortestWord.Length || string.IsNullOrEmpty(shortestWord))
                {
                    shortestWord = word;
                }
            };

            return new Stats
            {
                NumberOfAllWords = words.Length,
                NumberOfWordsThatContainOnlyDigits = onlyDigitCount,
                NumberOfWordsStartingWithSmallLetter = startLowercaseCount,
                NumberOfWordsStartingWithCapitalLetter = startUppercaseCount,
                TheLongestWord = longestWord,
                TheShortestWord = shortestWord,
            };
        }
    }
}
