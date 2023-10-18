using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

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
