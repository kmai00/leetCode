using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Problem1238
    {
        public IList<int> CircularPermutation(int n, int start)
        {

            var totalAmount = (int)Math.Pow(2, n);
            var result = new List<int>();

            var initialList = new List<int>();
            for (var i = 0; i < totalAmount; i++)
            {
                initialList.Add(i);
            }

            if (start == 0)
            {
                var midPoint = (totalAmount / 2) - 1;
                var midToEndList = initialList.Skip(midPoint);
                midToEndList = midToEndList.Reverse();
                result = initialList.Take(midPoint - 2).ToList();
                result.AddRange(midToEndList);
            }
            else
            {
                var temp = new int[totalAmount];
                for (int i = 0; i < totalAmount; i++)
                {
                    var newIndex = (i + 1) % totalAmount;
                    temp[newIndex] = initialList[i];
                }
                result = temp.ToList();
            }

            return result;
        }
    }
}
