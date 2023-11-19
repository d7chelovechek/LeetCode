namespace LeetCode.Problems.Hard
{
    /// <summary>
    /// Solution for problem 1980. Find Unique Binary String
    /// https://leetcode.com/problems/find-unique-binary-string/description/
    /// </summary>
    public class Problem1980
    {
        public string FindDifferentBinaryString(string[] nums)
        {
            HashSet<int> values = nums.Select(n => Convert.ToInt32(n, 2)).ToHashSet();

            string binaryString = string.Empty;

            // 65535 is 1111111111111111 in binary
            for (var value = 0; value <= 65535; value++)
            {
                if (!values.Contains(value))
                {
                    binaryString = Convert.ToString(value, 2);

                    break;
                }
            }

            return binaryString.PadLeft(nums.Length, '0');
        }
    }
}