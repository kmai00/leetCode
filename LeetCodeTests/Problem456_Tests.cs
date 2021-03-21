using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    public class Problem456_Tests
    {

        Problem456 _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Problem456();
        }

        [Test]
        public void OrderedArray()
        {
            var nums = new int[] { 1, 2, 3, 4 };
            var result = _sut.Find132Pattern(nums);
            Assert.IsFalse(result);
        }

        [Test]
        public void UnsortedArray()
        {
            var nums = new int[] { 3, 1, 4, 2 };
            var result = _sut.Find132Pattern(nums);
            Assert.IsTrue(result);
        }

        [Test]
        public void NegativeArray()
        {
            var nums = new int[] { -1, 3, 2, 0 };
            var result = _sut.Find132Pattern(nums);
            Assert.IsTrue(result);
        }

        [Test]
        public void Example_1()
        {
            var nums = new int[] { 1, 3, 2, 4, 5, 6, 7, 8, 9, 10 };
            var result = _sut.Find132Pattern(nums);
            Assert.IsTrue(result);
        }

        [Test]
        public void Example_2()
        {
            var nums = new int[] { -2, 1, 2, -2, 1, 2 };
            var result = _sut.Find132Pattern(nums);

            Assert.IsTrue(result);
        }

        [Test]
        public void Example_3()
        {
            var nums = new int[] { 1, 0, 1, -4, -3 };
            var result = _sut.Find132Pattern(nums);

            Assert.IsFalse(result);
        }

        [Test]
        public void Example_4()
        {
            var nums = new int[] { 3, 5, 0, 3, 4 };
            var result = _sut.Find132Pattern(nums);

            Assert.IsTrue(result);
        }

        [Test]
        public void Example_5()
        {

            var nums = new int[] { 1, 4, 0, -1, -2, -3, -1, -2 };
            var result = _sut.Find132Pattern(nums);

            Assert.IsTrue(result);
        }

    }
}