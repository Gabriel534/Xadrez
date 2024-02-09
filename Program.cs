using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Xadrez.Entities;
using Xadrez.Entities.Comparators;
using Xadrez.Entities.Pieces;
using Xadrez.Entities.Utilities;
using Xadrez.Exceptions;
using Xadrez.Services;

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
                new Pawn(TypePiece.WHITE, new Point(8, 7)),
                new Tower(TypePiece.BLACK, new Point(1, 1)),
                new Tower(TypePiece.WHITE, new Point(1, 8)),
                new Tower(TypePiece.BLACK, new Point(8, 1)),
                new Tower(TypePiece.WHITE, new Point(8, 8)),
                new King(TypePiece.BLACK, new Point(5, 4)),
                new King(TypePiece.WHITE, new Point(5, 5)),
                new Bishop(TypePiece.WHITE, new Point(3, 8)),
                new Bishop(TypePiece.WHITE, new Point(6, 8)),
                new Bishop(TypePiece.BLACK, new Point(3, 1)),
                new Bishop(TypePiece.BLACK, new Point(6, 1)),
                new Queen(TypePiece.WHITE, new Point(4, 8)),
                new Queen(TypePiece.BLACK, new Point(4, 1)),
                new Horse(TypePiece.BLACK, new Point(2, 1)),
                new Horse(TypePiece.BLACK, new Point(7, 1)),
                new Horse(TypePiece.WHITE, new Point(2, 8)),
                new Horse(TypePiece.WHITE, new Point(7, 8)));

            tabuleiro.LoopGame();


        }
    }
}
