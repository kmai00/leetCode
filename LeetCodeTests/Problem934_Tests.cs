using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Problem934_Tests
    {
        public Problem934 sut;

        public Problem934_Tests()
        {
            sut = new Problem934();
        }

        [Test]
        public void Example1_Ok()
        {
            var grid = new int[][] {
               new int[] { 0, 1 },
                new int[] { 1, 0 }
            };

            var result = sut.ShortestBridge(grid);

            Assert.AreEqual(1, result);
        }
    }
}
