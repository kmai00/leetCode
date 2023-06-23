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

        // Why don't I just search?
        // And as I walk the path, I can check if the path is block... if all path is blocked then return -1
        // Keep track of the starting cost of each objet

        public int CutOffTree(List<List<int>> forest)
        {

            var queue = new Queue<StartingPoint>();
            queue.Enqueue(new StartingPoint(0, 0));

            // Under assumption that starting one is the lowest
            var treesToCut = forest.SelectMany(f => f).Where(f => f > 1).Count();
            var treeToCutNext = forest[0][0] + 1;
            var steps = 0;
            while (queue.TryDequeue(out var startingPoint))
            {
                var currentTreeValue = forest[startingPoint.row][startingPoint.col];

                if (treeToCutNext == currentTreeValue)
                {
                    treesToCut--;
                    treeToCutNext++;
                    queue.Clear();
                }

                if (treesToCut == 0)
                {
                    break;
                }

                steps++;
                // Handle North
                if (startingPoint.row > 0)
                {
                    queue.Enqueue(new StartingPoint(startingPoint.row - 1, startingPoint.col));
                }
                // Handle West
                if (startingPoint.col > 0)
                {
                    queue.Enqueue(new StartingPoint(startingPoint.row, startingPoint.col -1));
                }
                // Handle East
                if (startingPoint.col < forest[0].Count)
                {
                    queue.Enqueue(new StartingPoint(startingPoint.row, startingPoint.col + 1));
                }
                // Handle South
                if (startingPoint.row < forest.Count)
                {
                    queue.Enqueue(new StartingPoint(startingPoint.row + 1, startingPoint.col));
                }

            }

            return steps;

        }
    }

    public class StartingPoint
    {
        public StartingPoint(int row, int col)
        {
            this.row = row;
            this.col = col;
        }

        public int row;
        public int col;
    }
}
