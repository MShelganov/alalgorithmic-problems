using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alalgorithmic.Lib
{
    public static class LeetCodeSolution
    {
        public static string IntToRoman(int num)
        {
            var romanNumbersDictionary = new Dictionary<string, int>
            {
                {
                    "I", 1
                },
                {
                    "IV", 4
                },
                {
                    "V", 5
                },
                {
                    "IX", 9
                },
                {
                    "X", 10
                },
                {
                    "XL", 40
                },
                {
                    "L", 50
                },
                {
                    "XC", 90
                },
                {
                    "C", 100
                },
                {
                    "CD", 400
                },
                {
                    "D", 500
                },
                {
                    "CM", 900
                },
                {
                    "M", 1000
                }
            };

            var tempNumber = num;
            var result = new StringBuilder();
            foreach (var roman in romanNumbersDictionary.Reverse())
            {
                if (tempNumber <= 0)
                    break;

                while (tempNumber >= roman.Value)
                {
                    result.Append(roman.Key);
                    tempNumber -= roman.Value;
                }
            }

            return result.ToString();
        }

        public static int RomanToInt(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            var romanValues = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int result = 0;
            int prev = romanValues[s[0]];
            for (int i = 1; i < s.Length; i++)
            {
                int current = romanValues[s[i]];
                if (current > prev)
                {
                    result -= prev;
                }
                else
                {
                    result += prev;
                }

                prev = current;
            }

            result += prev;
            return result;
        }
    }
}

