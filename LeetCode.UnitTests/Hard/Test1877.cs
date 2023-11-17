using LeetCode.Problems.Hard;
using NUnit.Framework;

namespace LeetCode.UnitTests.Hard
{
    /// <summary>
    /// Test for solution of problem 1877. Minimize Maximum Pair Sum in Array
    /// https://leetcode.com/problems/minimize-maximum-pair-sum-in-array/description/
    /// </summary>
    [TestFixture]
    public class Test1877
    {
        private Problem1877 _solution;

        [OneTimeSetUp]
        public void Setup()
        {
            _solution = new Problem1877();
        }

        [TestCase(7, 3, 5, 2, 3)]
        [TestCase(8, 3, 5, 4, 2, 4, 6)]
        public void MinPairSumTest(int expected, params int[] nums)
        {
            int actual = _solution.MinPairSum(nums);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}