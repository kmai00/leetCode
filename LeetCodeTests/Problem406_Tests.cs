using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Problem406_Tests
    {
        Problem406 _sut;

        [SetUp]
        public void Setup() {
            _sut = new Problem406(); 
        }

        [Test]
        public void Example_1()
        {
            var input = new int[][]{
                new[] { 7,0 },
                new[] { 4,4 },
                new[] { 7,1 },
                new[] { 5,0 },
                new[] { 6,1 },
                new[] { 5,2 }
            };

            var expected = new int[][]{
                new[] { 5,0 },
                new[] { 7,0 },
                new[] { 5,2 },
                new[] { 6,1 },
                new[] { 4,4 },
                new[] { 7,1 }
            };

            var actual = _sut.ReconstructQueue(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Example_2()
        {
            var input = new int[][]{
                new[] { 6,0 },
                new[] { 5,0 },
                new[] { 4,0 },
                new[] { 3,2 },
                new[] { 2,2 },
                new[] { 1,4 }
            };

            var expected = new int[][]{
                new[] { 4,0 },
                new[] { 5,0 },
                new[] { 2,2 },
                new[] { 3,2 },
                new[] { 1,4 },
                new[] { 6,0 }
            };

            var actual = _sut.ReconstructQueue(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Example_3()
        {
            var input = new int[][]{
                new[] { 9,0 },
                new[] { 7,0 },
                new[] { 1,9 },
                new[] { 3,0 },
                new[] { 2,7 },
                new[] { 5,3 },
                new[] { 6,0 },
                new[] { 3,4 },
                new[] { 6,2 },
                new[] { 5,2 },
            };

            var expected = new int[][]{
                new[] { 3,0 },
                new[] { 6,0 },
                new[] { 7,0 },
                new[] { 5,2 },
                new[] { 3,4 },
                new[] { 5,3 },
                new[] { 6,2 },
                new[] { 2,7 },
                new[] { 9,0 },
                new[] { 1,9 },
            };

            var actual = _sut.ReconstructQueue(input);
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Sorting_0()
        {
            var input = new int[][]{
                new[] { 9,0 },
                new[] { 4,0 },
                new[] { 1,2 },
            };

            var expected = new int[][]{
                new[] { 4,0 },
                new[] { 9,0 },
                new[] { 1,2 },
            };

            var actual = _sut.ReconstructQueue(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
