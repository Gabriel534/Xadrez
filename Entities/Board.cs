using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez.Entities
{
    internal class Board
    {
        List<Piece> Pieces = new List<Piece>();
        public Board(params Piece[] pieces)
        {
            foreach (Piece piece in pieces)
            {
                Pieces.Add(piece);
            }
        }

        public void RefreshBoard()
        {
            bool PointBool;

            // Limpa o console
            Console.Clear();

            for (int i = 1; i < 9; i++)
            {
                Console.Write(i);
                for (int j = 1; j < 9; j++)
                {

                    PointBool = false;

                    // Verifica se tem peças a serem colocadas nesta posição

                    foreach (Piece piece in Pieces)
                    {
                        if (piece.PiecePoint.X == j && piece.PiecePoint.Y == i)
                        {
                            Console.Write(" " + piece.ToString());
                            PointBool = true;
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
        }
    }
}
