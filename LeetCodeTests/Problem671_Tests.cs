using LeetCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTests
{
    [TestFixture]
    public class Problem671_Tests
    {
        [Test]
        public void Example_1()
        {
            var tree = new TreeNode
            {
                val = 2,
                left = new TreeNode
                {
                    val = 2
                },
                right = new TreeNode
                {
                    val = 5,
                    left = new TreeNode
                    {
                        val = 5
                    },
                    right = new TreeNode
                    {
                        val = 7
                    }

                }
            };

            var _sut = new Problem671();
            var result = _sut.FindSecondMinimumValue(tree);
            Assert.AreEqual(5, result);

        }
    }
}
