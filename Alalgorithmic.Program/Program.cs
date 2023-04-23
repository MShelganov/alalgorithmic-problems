using System;
using Alalgorithmic.Lib;

namespace Alalgorithmic_problems
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 0, 0, 0, 1, 1, 0, 0, 1, 0, 1, 1, 0 };
            Console.WriteLine(Solution.ContinuousNumberOfOneInTheArray(arr));
            Console.ReadLine();
        }
    }
}
