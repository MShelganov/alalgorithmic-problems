using System;

namespace Alalgorithmic.Lib
{
	public static class Solution
	{
        public static int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length - 1; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    var sum = nums[i] + nums[j];
                    if (sum == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return Array.Empty<int>();
        }

        public static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            int dividedByTen = x;
            int reversed = 0;
            while (dividedByTen > 0)
            {
                int digit = dividedByTen % 10;
                reversed = reversed * 10 + digit;
                dividedByTen /= 10;
            }

            return x == reversed;
        }

        public static bool IsMatch(string s, string p)
        {
            int m = s.Length;
            int n = p.Length;
            bool[,] dp = new bool[m + 1, n + 1];
            dp[0, 0] = true;
            for (int j = 1; j <= n; j++)
            {
                if (p[j - 1] == '*')
                {
                    dp[0, j] = dp[0, j - 1];
                }
            }

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (p[j - 1] == s[i - 1] || p[j - 1] == '.')
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else if (p[j - 1] == '*')
                    {
                        dp[i, j] = dp[i - 1, j] || dp[i, j - 1];
                    }
                }
            }

            return dp[m, n];
        }
    }
}
