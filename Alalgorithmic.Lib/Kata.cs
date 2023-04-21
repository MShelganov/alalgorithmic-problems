﻿using System;
using System.Text;

namespace Alalgorithmic.Lib
{
    public static class Kata
    {
        public static int MaxSequence(int[] arr)
        {
            if (arr.Length == 0)
                return 0;

            int maxSum = arr[0];
            int currentSum = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                currentSum = Math.Max(arr[i], currentSum + arr[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }

        /// <summary>
        /// In this kata, you have an input string and you should check whether it is a valid message.
        /// To decide that, you need to split the string by the numbers, and then compare the numbers
        /// with the number of characters in the following substring.
        /// </summary>
        public static bool IsAValidMessage(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                return true;

            if (!int.TryParse(message[0].ToString(), out _)
                || int.TryParse(message[message.Length - 1].ToString(), out _))
                return false;

            var number = new StringBuilder();
            var word = new StringBuilder();
            var i = 0;
            while (i < message.Length)
            {
                while (char.IsDigit(message[i]))
                {
                    number.Append(message[i]);
                    i++;
                }

                while (i < message.Length
                    && char.IsLetter(message[i]))
                {
                    word.Append(message[i]);
                    i++;
                }

                if (int.Parse(number.ToString()) != word.ToString().Length)
                    return false;

                number.Clear();
                word.Clear();
            }

            return true;
        }
    }
}
