using LeetCode.Problems.Hard;
using NUnit.Framework;

namespace LeetCode.UnitTests.Hard
{
    /// <summary>
    /// Test for solution of problem 1980. Find Unique Binary String
    /// https://leetcode.com/problems/find-unique-binary-string/description/
    /// </summary>
    [TestFixture]
    public class Test1980
    {
        private Problem1980 _solution; 

        [OneTimeSetUp]
        public void Setup()
        {
            _solution = new Problem1980();
        }

        [TestCase("01", "10")]
        [TestCase("00", "01")]
        [TestCase("111", "011", "001")]
        public void FindDifferentBinaryStringTest(params string[] nums)
        {
            string actual = _solution.FindDifferentBinaryString(nums);

            Assert.That(actual, Is.Not.Null, "Actual value is null!");

            Assert.That(
                actual.Length,
                Is.EqualTo(nums.Length),
                "Actual value's length is not equal to nums length!");

            Assert.That(
                nums, 
                Is.Not.Contains(actual), 
                "Actual value is not unique in nums array!");
        }
    }
}