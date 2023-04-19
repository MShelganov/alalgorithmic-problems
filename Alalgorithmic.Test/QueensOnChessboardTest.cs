using System;
using System.Collections.Generic;
using Alalgorithmic.Lib;
using NUnit.Framework;

namespace Alalgorithmic.Test
{
    [TestFixture]
	public class QueensOnChessboardTest
	{
        /// <summary>
        /// Given a chessboard of size M by M, on which N queens are placed.
		/// The task is to find the queen that attacks the largest number of
		/// other queens, using an algorithm with linear memory complexity.
        /// </summary>
        [Test]
		public void FindMostAttacksQueenTest1()
        {
            List<(int Row, int Col)> queens = new List<(int, int)> { (4, 1), (2, 2), (3, 3), (4, 4) };
            List<(int Row, int Col)> attackingQueens = QueensOnChessboard.FindAttackingQueens(queens);
            Assert.That(attackingQueens, Has.Count.EqualTo(1));
            Assert.Multiple(() =>
            {
                Assert.That(attackingQueens[0].Row, Is.EqualTo(4));
                Assert.That(attackingQueens[0].Col, Is.EqualTo(4));
            });
        }

        [Test]
		public void FindMostAttacksQueenTest2()
        {
            List<(int Row, int Col)> queens = new List<(int, int)> { (1, 1), (2, 2) };
            List<(int Row, int Col)> attackingQueens = QueensOnChessboard.FindAttackingQueens(queens);
            Assert.That(attackingQueens, Has.Count.EqualTo(2));
            Assert.Multiple(() =>
            {
                Assert.That(attackingQueens[0].Row, Is.EqualTo(1));
                Assert.That(attackingQueens[0].Col, Is.EqualTo(1));
                Assert.That(attackingQueens[1].Row, Is.EqualTo(2));
                Assert.That(attackingQueens[1].Col, Is.EqualTo(2));
            });
        }
    }
}

