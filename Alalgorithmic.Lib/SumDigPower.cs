using System;
using System.Collections.Generic;

namespace Alalgorithmic.Lib
{
	public static class SumDigPower
	{
        public static long DigPow(int n, int p)
        {
            var numStr = n.ToString();
            long digPowNum = 0;
            for (int i = 0; i < numStr.Length; i++)
            {
                var num = long.Parse(numStr[i].ToString());
                digPowNum += Convert.ToInt64(Math.Pow(num, p + i));
            }

            var result = Math.DivRem(digPowNum, n, out long divRem);
            if (divRem != 0)
                return -1;

            return result;
        }

        // Another way
        public static long DigPowLog10(long n, long p)
        {
            long remainDigits = (int)Math.Log10(n) + 1;
            long computedPows = 0;
            long remain = n;

            while (remain > 0)
            {
                remainDigits--;
                computedPows += (long)Math.Pow(remain % 10, p + remainDigits);
                remain /= 10;
            }

            if (computedPows % n == 0)
            {
                return computedPows / n;
            }

            return -1;
        }

        public static long[] SumDigPow(long a, long b)
        {
            if (a > b)
            {
                (a, b) = (b, a);
            }

            var resultList = new List<long>();
            for (var i = a; i < b + 1; i++)
            {
                var sum = DigPow(i);
                if (i == sum)
                    resultList.Add(i);
            }

            return resultList.ToArray();
        }

        public static long DigPow(long n)
        {
            var numStr = n.ToString();
            long digPowNum = 0;
            for (int i = 0; i < numStr.Length; i++)
            {
                var num = long.Parse(numStr[i].ToString());
                digPowNum += Convert.ToInt64(Math.Pow(num, 1 + i));
            }

            return digPowNum;
        }
    }
}
