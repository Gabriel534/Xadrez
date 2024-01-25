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
                new King(TypePiece.BLACK, new Point(5, 1)),
                new King(TypePiece.WHITE, new Point(5, 8)),
                new Bishop(TypePiece.WHITE, new Point(3, 8)),
                new Bishop(TypePiece.WHITE, new Point(6, 8)),
                new Bishop(TypePiece.BLACK, new Point(3, 1)),
                new Bishop(TypePiece.BLACK, new Point(6, 1)),
                new Queen(TypePiece.WHITE, new Point(4,8)),
                new Queen(TypePiece.BLACK, new Point(4, 1)));

            string posString;
            Piece piece;
            Point point;
            Point pointAttack;
            List<Point> PossiblePoints = new List<Point>();

            while (true)
            {

                point = null;
                PossiblePoints.Clear();

                // Atualiza o tabuleiro na tela
                tabuleiro.UpdateBoardWithHighlightedPieces(PossiblePoints);

                // Obtém a posição desejada
                Console.Write("Origem: \n:> ");
                posString = Console.ReadLine();

                try
                {
                    point = XadrezTools.ConvertStringIntoPoint(posString);
                }
                catch (InvalidStringPointException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                // Procura a peça mencionada pela posição
                piece = tabuleiro.Pieces.Find(p => p.PiecePoint.Equals(point));

                // Se não encontrar a peça, manda mensagem e reinicia o loop
                if (piece == null)
                {
                    Console.WriteLine("Peça não encontrada");
                    PossiblePoints.Clear();
                    continue;
                }


                PossiblePoints = piece.GetPossibleMoves(tabuleiro.Pieces);

                // Atualiza novamente o tabuleiro na tela com os movimentos
                tabuleiro.UpdateBoardWithHighlightedPieces(PossiblePoints);
                Console.Write("Destino:\n:> ");
                posString = Console.ReadLine();

                try
                {
                    pointAttack = XadrezTools.ConvertStringIntoPoint(posString);
                }
                catch (InvalidStringPointException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                try
                {
                    piece.MakeMovement(pointAttack, tabuleiro.Pieces);
                }
                catch (InvalidPointException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
        }


    }
}
