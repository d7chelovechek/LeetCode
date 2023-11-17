namespace LeetCode.Problems.Hard
{
    /// <summary>
    /// Solution for problem 1877. Minimize Maximum Pair Sum in Array
    /// https://leetcode.com/problems/minimize-maximum-pair-sum-in-array/description/
    /// </summary>
    public class Problem1877
    {
        public int MinPairSum(int[] nums)
        {
            Array.Sort(nums);

            var maxSum = int.MinValue;

            for (var index = 0; index < nums.Length / 2; index++)
            {
                maxSum = Math.Max(
                    maxSum, 
                    nums[index] + nums[nums.Length - 1 - index]);
            }

            return maxSum;
        }
    }
}