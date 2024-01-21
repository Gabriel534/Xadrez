using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Entities.Utilities;
using Xadrez.Exceptions;

namespace Xadrez.Entities
{
    internal class Board
    {
        public List<Piece> Pieces = new List<Piece>();
        public Board(params Piece[] pieces)
        {
            foreach (Piece piece in pieces)
            {
                foreach (Piece piece2 in Pieces)
                {
                    if (piece.PiecePoint.Equals(piece2.PiecePoint))
                    {
                        throw new InvalidPointException("Ponto utilizado já utilizado por outra peça");
                    }
                }
                Pieces.Add(piece);
            }
        }

        public void UpdateBoardWithHighlightedPieces(List<Point> points) // Recebe os pontos que ele deve destacar na tela
        {
            bool PointBool;

            // Limpa o console
            //Console.Clear();

            // Percorre os pontos no tabuleiro
            for (int i = 1; i < 9; i++)
            {
                Console.Write(i);
                for (int j = 1; j < 9; j++)
                {

                    PointBool = false;

                    // Coloca o fundo como padrão Preto
                    System.Console.BackgroundColor = ConsoleColor.Black;

                    // Verifica se o ponto deve ser destacado ou não no tabuleiro
                    foreach (Point p in points)
                    {
                        if (p.Equals(new Point(j, i)))
                        {
                            System.Console.BackgroundColor = ConsoleColor.White;
                        }
                    }

                    // Verifica se tem peças a serem colocadas nesta posição

                    foreach (Piece piece in Pieces)
                    {
                        if (piece.PiecePoint.X == j && piece.PiecePoint.Y == i)
                        {
                            if (piece.Type == TypePiece.BLACK)
                            {
                                System.Console.ForegroundColor = ConsoleColor.DarkYellow;
                            }

                            Console.Write(" " + piece.ToString());
                            PointBool = true;
                            System.Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }


                    // Caso não houver peças na posição, é colocado um traço
                    if (!PointBool)
                    {
                        Console.Write(" -");
                    }
                }
                // No final é quebradoa  linha
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
    }
}
