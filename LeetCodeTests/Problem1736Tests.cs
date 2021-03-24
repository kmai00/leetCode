using LeetCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTests
{
    [TestFixture]
    public class Problem1736Tests
    {

        Problem1736 _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Problem1736();
        }

        [Test]
        public void latestSingleMinute()
        {
            var time = "23:5?";

            var result = _sut.MaximumTime(time);

            Assert.AreEqual("23:59", result);
        }

        [Test]
        public void latestTenthMinute()
        {
            var time = "23:?9";

            var result = _sut.MaximumTime(time);

            Assert.AreEqual("23:59", result);
        }

        [Test]
        public void latestTenthAndSingleMinute()
        {
            var time = "23:??";

            var result = _sut.MaximumTime(time);

            Assert.AreEqual("23:59", result);
        }

        [Test]
        public void latestSingleHour()
        {
            var time = "2?:59";

            var result = _sut.MaximumTime(time);

            Assert.AreEqual("23:59", result);
        }

        [Test]
        public void latestTenthHour_20s()
        {
            var time = "?3:59";

            var result = _sut.MaximumTime(time);

            Assert.AreEqual("23:59", result);
        }

        [Test]
        public void latestTenthHour_10s()
        {
            var time = "?4:59";

            var result = _sut.MaximumTime(time);

            Assert.AreEqual("14:59", result);
        }

        [Test]
        public void latestTime_AllMissing()
        {
            var time = "??:??";

            var result = _sut.MaximumTime(time);

            Assert.AreEqual("23:59", result);
        }

        [Test]
        public void Exmaple_1()
        {
            var time = "0?:3?";

            var result = _sut.MaximumTime(time);

            Assert.AreEqual("09:39", result);


        }
    }
}
