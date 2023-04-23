using System;
using System.Linq;
using System.Text.RegularExpressions;

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

        public static int MaxArea(int[] height)
        {
            int maxArea = 0;
            int left = 0;
            int right = height.Length - 1;
            while (left < right)
            {
                int area = Math.Min(height[left], height[right]) * (right - left);
                maxArea = Math.Max(maxArea, area);
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxArea;
        }


        public static int ContinuousNumberOfOneInTheArray(int[] units)
        {
            if (units is null || units.Length == 0)
                return 0;

            var n = units.Length;
            var i = 0;
            while (i < n && units[i] == 0)
            {
                i++;
            }

            int j = n - 1;
            while (j >= 0 && units[j] == 0)
            {
                j--;
            }

            var temp_arr = units[i..(j + 1)].ToList();
            for (var z = 0; z < temp_arr.Count - 1; z++)
            {
                if (temp_arr[z] == 0 && temp_arr[z + 1] != 0)
                {
                    temp_arr.RemoveAt(z);
                }
            }

            int maxLen = 0;
            int curLen = 0;
            for (int x = 1; x < temp_arr.Count; x++)
            {
                if (temp_arr[x] == 1)
                {
                    curLen++;
                }
                else
                {
                    maxLen = Math.Max(maxLen, curLen);
                    curLen = 0;
                }
            }

            return Math.Max(maxLen, curLen);
        }
    }
}
