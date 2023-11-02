using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Problem226
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;

            // Trying to invert with BFS
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();
                if (currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                }
                if (currentNode.right != null)
                {
                    queue.Enqueue(currentNode.right);
                }

                var temp = currentNode.left;
                currentNode.left = currentNode.right;
                currentNode.right = temp;
            }

            return root;
        }
    }
}
