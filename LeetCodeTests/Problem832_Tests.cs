using LeetCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTests
{
    [TestFixture]
    public class Problem832_Tests
    {
        [Test]
        public void Example1()
        {
            var image = new int[][] {
            new int[] { 1, 1, 0 },
            new int[] { 1, 0, 1 },
            new int[] { 0, 0, 0 }
        };
            var result = Problem832.FlipAndInvertImage(image);

            var expected = new int[][] {
                new int[]{ 1,0,0 },
                new int[]{ 0,1,0 },
                new int[] { 1,1,1}
            };

            Assert.AreEqual(expected, result);
        }
    }
}
