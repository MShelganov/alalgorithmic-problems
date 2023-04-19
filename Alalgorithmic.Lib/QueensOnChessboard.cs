using System;
using System.Collections.Generic;

namespace Alalgorithmic.Lib
{
	public static class QueensOnChessboard
	{
        /// <summary>
        /// Given a chessboard of size M by M, on which N queens are placed.
        /// The task is to find the queen that attacks the largest number of
        /// other queens, using an algorithm with linear memory complexity.
        /// </summary>
        /// <param name="queens">N-size list of queens on chessboard.</param>
        /// <returns>
        ///     Finded the queen that attacks the largest number of other queens
        /// </returns>
        public static List<(int X, int Y)> FindAttackingQueens(IList<(int Row, int Col)> queens)
		{
            int n = queens.Count;
            int[] rows = new int[n];
            int[] cols = new int[n];
            int[] diag1 = new int[2 * n - 1];
            int[] diag2 = new int[2 * n - 1];

            for (int i = 0; i < n; i++)
            {
                int row = queens[i].Row - 1;
                int col = queens[i].Col - 1;
                rows[row]++;
                cols[col]++;
                diag1[row + col]++;
                diag2[row - col + n - 1]++;
            }

            int maxAttacks = 0;
            var attackingQueens = new List<(int Row, int Col)>();
            for (int i = 0; i < n; i++)
            {
                int row = queens[i].Row - 1;
                int col = queens[i].Col - 1;
                int attacks = rows[row] + cols[col] + diag1[row + col] + diag2[row - col + n - 1] - 4;
                if (attacks > maxAttacks)
                {
                    maxAttacks = attacks;
                    attackingQueens.Clear();
                    attackingQueens.Add(queens[i]);
                }
                else if (attacks == maxAttacks)
                {
                    attackingQueens.Add(queens[i]);
                }
            }
            return attackingQueens;
        }
    }
}
