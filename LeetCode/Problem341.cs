using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    // 341. Flatten Nested List Iterator
    // Medium

    // You are given a nested list of integers nestedList.Each element is either an integer or a list whose elements may also be integers or other lists.Implement an iterator to flatten it.

    // Implement the NestedIterator class:

    // NestedIterator(List < NestedInteger > nestedList) Initializes the iterator with the nested list nestedList.
    // int next() Returns the next integer in the nested list.
    // boolean hasNext() Returns true if there are still some integers in the nested list and false otherwise.
    public class Problem341
    {
        private Queue<int> flattenIntegers;

        public Problem341(List<NestedInteger> nestedList)
        {
            flattenIntegers = new Queue<int>();
            var stack = new Stack<NestedInteger>(); // maybe depth first search or something

            // reverse add, since we're pulling from the top
            for (var i = nestedList.Count - 1; i >= 0; i--)
            {
                stack.Push(nestedList[i]);
            }

            while (stack.TryPop(out var nestedInteger))
            {
                if (nestedInteger.IsInteger())
                {
                    flattenIntegers.Enqueue(nestedInteger.GetInteger());
                }

                var innerList = nestedInteger.GetList();
                if (innerList != null)
                {
                    for (var i = innerList.Count - 1; i >= 0; i--)
                    {

                        stack.Push(innerList[i]);
                    }
                }
            }
        }

        public bool HasNext()
        {
            return flattenIntegers.Any();
        }

        public int Next()
        {
            return flattenIntegers.Dequeue();
        }
    }

    // This is the interface that allows for creating nested lists.
    // You should not implement it, or speculate about its implementation
    public interface NestedInteger
    {

        // @return true if this NestedInteger holds a single integer, rather than a nested list.
        bool IsInteger();

        // @return the single integer that this NestedInteger holds, if it holds a single integer
        // Return null if this NestedInteger holds a nested list
        int GetInteger();

        // @return the nested list that this NestedInteger holds, if it holds a nested list
        // Return null if this NestedInteger holds a single integer
        IList<NestedInteger> GetList();
    }

}
