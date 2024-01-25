using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Entities.Utilities;

namespace Xadrez.Entities.Pieces
{
    internal class Pawn : Piece
    {
        private int ValueMove; // Indica se a possível localização da casa é em cima ou em baixo dependendo do sinal deste valor, que é pra ser 1
        public Pawn(TypePiece type, Point point) : base(type, point)
        {
        }

        public override List<Point> GetPossibleMoves(List<Piece> pieces)
        {
            List<Point> list = new List<Point>();

            if (Type == TypePiece.BLACK)
            {
                ValueMove = 1;
            }
            else if (Type == TypePiece.WHITE)
            {
                ValueMove = -1;
            }


            // Percorre por todas as peças do jogo e faz as tarefaz dependendo do tipo da peça
            foreach (Piece p in pieces)
            {
                // Detecta peças que possam ser comidas
                if (p.PiecePoint.Y == (PiecePoint.Y + ValueMove) && !p.Equals(this) && p.Type != Type)
                {
                    if (p.PiecePoint.X == (PiecePoint.X + ValueMove) || p.PiecePoint.X == (PiecePoint.X + ((-1) * ValueMove)))
                    {
                        list.Add(p.PiecePoint);
                    }
                }

            }


            // Verifica posição que pode ser colocada a frente do peão

            Piece piece = null;
            piece = pieces.Find(x => x.PiecePoint.Y == (PiecePoint.Y + ValueMove) && (x.PiecePoint.X == PiecePoint.X));



            if (piece == null)
            {
                list.Add(new Point(PiecePoint.X, PiecePoint.Y + ValueMove));
            }

            if (Type == TypePiece.BLACK && PiecePoint.Y == 2)
            {
                Piece piece2 = null;
                piece2 = pieces.Find(x => x.PiecePoint.Y == (PiecePoint.Y + 2) && x.PiecePoint.X == PiecePoint.X);
                if (piece2 == null && piece == null)
                {
                    list.Add(new Point(PiecePoint.X, PiecePoint.Y + 2));
                }

            }
            else if (Type == TypePiece.WHITE && PiecePoint.Y == 7)
            {
                Piece piece2 = null;
                piece2 = pieces.Find(x => x.PiecePoint.Y == (PiecePoint.Y - 2) && x.PiecePoint.X == PiecePoint.X);
                if (piece2 == null && piece == null)
                {
                    list.Add(new Point(PiecePoint.X, PiecePoint.Y - 2));

                }
            }
            return list;
        }

        public override string ToString()
        {
            return "P";
        }
    }
}

