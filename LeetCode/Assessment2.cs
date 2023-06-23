using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Assessment2
    {
        // We need to cut the trees in order from smallest to biggest
        // We can go up, down, left, right
        // Once we have a map of the tree, we can count from there

        // 0 = block path
        // 1 = empty
        // everything else is the order

        // The idea is to get my current tree value
        // Walk until I see the next one
        // this is like a breath first search thing

        public int CutOffTree(List<List<int>> forest)
        {
            var treesToCut = forest.SelectMany(f => f).Where(f => f > 1).Count();
            var steps = GetNextTree(forest, 0, 0, forest[0][0], 0, ref treesToCut);
            return steps;
        }

        public int GetNextTree(List<List<int>> forest, int startingRow, int startingCol, int previousTreeValue, int startinStep, ref int treesToCut)
        {
            var currentTreeValue = forest[startingRow][startingCol];
            if (currentTreeValue == 0)
            {
                return -1;
            }

            if (currentTreeValue == previousTreeValue + 1)
            {
                treesToCut--;
                return 1;
            }

            // Check bottom
            // TODO update the check
            var bottomStep = GetNextTree(forest, startingRow, startingCol + 1, currentTreeValue, startinStep, ref treesToCut);
            // Check right
            var rightStep = GetNextTree(forest, startingRow + 1, startingCol, currentTreeValue, startinStep, ref treesToCut);

            if (bottomStep == -1 && rightStep != -1)
            {
                return startinStep + rightStep;
            }
            else if (rightStep == -1 && bottomStep != -1)
            {
                return startinStep + bottomStep;
            }

            if (treesToCut != 0)
            {
                // Keep going down or right
            }
            else
            {
                return startinStep + Math.Min(bottomStep, rightStep);
            }
        }
    }
}
