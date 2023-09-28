using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public static class Problem832
    {
        // Can use bitwise function to transform the value.

        public static int[][] FlipAndInvertImage(int[][] image)
        {
            var result = new List<int[]>();
            foreach (var img in image)
            {
                var mirroredImage = img.Reverse().ToArray();
                var reversedValue = ReverseValue(mirroredImage);
                result.Add(reversedValue);
            }

            return result.ToArray();
        }

        public static int[] ReverseValue(int[] img)
        {
            var result = new int[img.Length];
            for (var i = 0; i < img.Length; i++)
            {
                result[i] = img[i] == 1 ? 0 : 1;
            }
            return result;
        }
    }
}
