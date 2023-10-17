using LeetCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTests
{
    [TestFixture]
    public class Problem9_Tests
    {
        private Problem9 sut;
        public Problem9_Tests()
        {
            sut = new Problem9();
        }


        [Test]
        public void Example1_Ok()
        {
            var result = sut.IsPalindrome(121);
            Assert.IsTrue(result);
        }
        
        [Test]
        public void Example2_Ok()
        {
            var result = sut.IsPalindrome(-121);
            Assert.IsFalse(result);
        }
        
        [Test]
        public void Example3_Ok()
        {
            var result = sut.IsPalindrome(10);
            Assert.IsFalse(result);
        }
    }
}
