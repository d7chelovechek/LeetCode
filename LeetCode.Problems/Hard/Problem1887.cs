namespace LeetCode.Problems.Hard
{
    /// <summary>
    /// Solution for problem 1887. Reduction Operations to Make the Array Elements Equal
    /// https://leetcode.com/problems/reduction-operations-to-make-the-array-elements-equal/description/
    /// </summary>
    public class Problem1887
    {
        public int ReductionOperations(int[] nums)
        {
            Array.Sort(nums, (i, j) => j.CompareTo(i));

            int currentValue = nums[0];
            var frequence = 1;

            var result = 0;

            for (var index = 1; index < nums.Length; index++)
            {
                if (nums[index].Equals(currentValue))
                {
                    frequence++;

                    continue;
                }

                result += frequence;
                frequence++;

                currentValue = nums[index];
            }

            return result;
        }
    }
}