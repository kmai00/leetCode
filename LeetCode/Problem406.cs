using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    // Queue Reconstruction by height
    public class Problem406
    {
        public int[][] ReconstructQueue(int[][] people)
        {
            var heighSorted = people.OrderByDescending(p => p[0]).ThenBy(p => p[1]);

            var orderedQueue = new List<int[]>();
            foreach (var person in heighSorted)
            {
                orderedQueue.Insert(person[1], person);
            }


            return orderedQueue.ToArray();
           }
    }
}
