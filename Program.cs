using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Entities;
using Xadrez.Entities.Pieces;
using Xadrez.Entities.Utilities;

namespace Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board tabuleiro = new Board(
                new Pawn(TypePiece.BLACK, new Point(1, 2)),
                new Pawn(TypePiece.BLACK, new Point(2, 2)),
                new Pawn(TypePiece.BLACK, new Point(3, 2)),
                new Pawn(TypePiece.BLACK, new Point(4, 2)),
                new Pawn(TypePiece.BLACK, new Point(5, 2)),
                new Pawn(TypePiece.BLACK, new Point(6, 2)),
                new Pawn(TypePiece.BLACK, new Point(7, 2)),
                new Pawn(TypePiece.BLACK, new Point(8, 2)),
                new Pawn(TypePiece.WHITE, new Point(1, 7)),
                new Pawn(TypePiece.WHITE, new Point(2, 7)),
                new Pawn(TypePiece.WHITE, new Point(3, 7)),
                new Pawn(TypePiece.WHITE, new Point(4, 7)),
                new Pawn(TypePiece.WHITE, new Point(5, 7)),
                new Pawn(TypePiece.WHITE, new Point(6, 7)),
                new Pawn(TypePiece.WHITE, new Point(7, 7)),
                new Pawn(TypePiece.WHITE, new Point(8, 7)));
            tabuleiro.RefreshBoard();
        }
    }
}
