using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    // Pascal Triangles
    public class Problem119
    {
        public IList<int> GetRow(int rowIndex)
        {
            var results = new int[rowIndex + 1][];
            results[0] = new int[1] { 1 };

            for (var pascalRow = 1; pascalRow <= rowIndex; pascalRow++)
            {
                results[pascalRow] = new int[pascalRow + 1];
                var previousLevel = results[pascalRow - 1];

                // Populate the edges;
                results[pascalRow][0] = 1;
                var resultEndIndex = results[pascalRow].Length - 1;
                results[pascalRow][resultEndIndex] = 1;

                for (var valueIndex = 1; valueIndex < results[pascalRow].Length - 1; valueIndex++)
                {
                    var leftValue = previousLevel[valueIndex - 1];
                    var rightValue = previousLevel[valueIndex];
                    results[pascalRow][valueIndex] = leftValue + rightValue;
                }
            }

            return results[rowIndex].ToList();
        }
    }
}
