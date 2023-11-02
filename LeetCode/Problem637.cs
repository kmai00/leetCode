using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class AverageNode
    {
        public double Sum;
        public double Count;
        public double Average => Sum / Count;
    }

    public class Problem637
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            var sumOfLevel = new Dictionary<int, AverageNode>();
            DFS(root, 0, sumOfLevel);

            var result = sumOfLevel.Select(s => s.Value.Average).ToList();

            return result;
        }

        public void DFS(TreeNode node, int level, Dictionary<int, AverageNode> sumOfLevel)
        {
            if (node is null)
            {
                return;
            }

            var value = node.val;
            if (sumOfLevel.ContainsKey(level))
            {
                var averageNode = sumOfLevel[level];
                averageNode.Sum += value;
                averageNode.Count++;
                sumOfLevel[level] = averageNode;
            }
            else
            {
                sumOfLevel.Add(level, new AverageNode
                {
                    Sum = value,
                    Count = 1
                });
            }

            DFS(node.left, level + 1, sumOfLevel);
            DFS(node.right, level + 1, sumOfLevel);
        }
    }
}
