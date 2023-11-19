using LeetCode.Problems.Hard;
using NUnit.Framework;

namespace LeetCode.UnitTests.Hard
{
    /// <summary>
    /// Test for solution of problem 1887. Reduction Operations to Make the Array Elements Equal
    /// https://leetcode.com/problems/reduction-operations-to-make-the-array-elements-equal/description/
    /// </summary>
    [TestFixture]
    public class Test1887
    {
        private Problem1887 _solution;

        [OneTimeSetUp]
        public void Setup()
        {
            _solution = new Problem1887();
        }

        [TestCase(3, 5, 1, 3)]
        [TestCase(0, 1, 1, 1)]
        [TestCase(4, 1, 1, 2, 2, 3)]
        public void ReductionOperationsTest(int expected, params int[] nums)
        {
            int actual = _solution.ReductionOperations(nums);

            Assert.That(
                actual, 
                Is.EqualTo(expected), 
                "Actual value is not equal to expected value!");
        }
    }
}