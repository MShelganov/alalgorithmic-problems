using System.Linq;

namespace Alalgorithmic.Lib
{
    public static class SplitString
    {
        public static string[] Solution(string str)
        {
            str = str.Length % 2 == 1 ? str + "_" : str;
            var count = str.Length / 2;
            var charArray = new string[count];
            for (var i = 0; i < count; i++)
            {
                charArray[i] = str.Substring(i * 2, 2);
            }

            return charArray;
        }
    }
}

