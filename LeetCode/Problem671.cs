using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{

    //Second smallest number

    public class SmallNumbers
    {
        public int smallestNumber;
        public int CandidateForSecondSmallest;
    }

    public class Problem671
    {
        public int FindSecondMinimumValue(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var smallNumbers = new SmallNumbers
            {
                smallestNumber = root.val,
                CandidateForSecondSmallest = -1
            };

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

                var currentVal = currentNode.val;
                if (smallNumbers.smallestNumber == currentVal)
                {
                    continue;
                }

                //Establish upper bound
                var currentValue = currentNode.val;
                if (smallNumbers.CandidateForSecondSmallest == -1) { 
                    smallNumbers.CandidateForSecondSmallest = currentValue;
                }

                // If we have a value that's smaller than upper bound, but bigger than the smallest- it's now the second
                if (smallNumbers.CandidateForSecondSmallest > currentVal && smallNumbers.smallestNumber < currentVal)
                {
                    smallNumbers.CandidateForSecondSmallest = currentVal;
                }
                else if (smallNumbers.smallestNumber > currentVal) {
                    var secondSmallest = smallNumbers.smallestNumber;
                    smallNumbers.smallestNumber = currentVal;
                    smallNumbers.CandidateForSecondSmallest = secondSmallest;
                }

            }

            return smallNumbers.CandidateForSecondSmallest;
        }
    }
}
