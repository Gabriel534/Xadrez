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
        public Pawn(TypePiece type, Point point) : base(type, point)
        {
        }

        public override List<Point> GetPossibleMoves(List<Piece> pieces)
        {
            List<Point> list = new List<Point>();

            // Percorre por todas as peças do jogo e faz as tarefaz dependendo do tipo da peça
            if (Type == TypePiece.BLACK)
            {
                foreach (Piece p in pieces)
                {
                    // Detecta peças que possam ser comidas
                    if (p.PiecePoint.Y == (PiecePoint.Y + 1) && !p.Equals(this) && p.Type != Type)
                    {
                        if (p.PiecePoint.X == (PiecePoint.X + 1) || p.PiecePoint.X == (PiecePoint.X - 1))
                        {
                            list.Add(p.PiecePoint);
                        }
                    }

                }
            }
            else if (Type == TypePiece.WHITE)
            {
                foreach (Piece p in pieces)
                {
                    if (p.PiecePoint.Y == (PiecePoint.Y - 1) && !p.Equals(this) && p.Type != Type)
                    {
                        if (p.PiecePoint.X == (PiecePoint.X + 1) || p.PiecePoint.X == (PiecePoint.X - 1))
                        {
                            list.Add(p.PiecePoint);
                        }
                    }
                }
            }

            // Verifica posição que pode ser colocada a frente do peão
            if (Type == TypePiece.BLACK)
            {
                Piece piece = pieces.Find(x => x.PiecePoint.Y == (PiecePoint.Y + 1) && (x.PiecePoint.X == PiecePoint.X));

                if (piece == null) { 
                    list.Add(new Point(PiecePoint.X, PiecePoint.Y+1));
                }


                if (PiecePoint.Y == 2)
                {
                    Piece piece2 = pieces.Find(x => x.PiecePoint.Y == (PiecePoint.Y + 2));
                    if (piece2 == null && piece == null)
                    {
                        list.Add(new Point(PiecePoint.X, PiecePoint.Y + 2));
                    }
                }
            }
            else if (Type == TypePiece.WHITE)
            {
                Piece piece = pieces.Find(x => x.PiecePoint.Y == (PiecePoint.Y - 1) && (x.PiecePoint.X == PiecePoint.X));

                if (piece == null)
                {
                    list.Add(new Point(PiecePoint.X, PiecePoint.Y - 1));
                }


                if (PiecePoint.Y == 7)
                {
                    Piece piece2 = pieces.Find(x => x.PiecePoint.Y == (PiecePoint.Y - 2));
                    if (piece2 == null && piece==null)
                    {
                        list.Add(new Point(PiecePoint.X, PiecePoint.Y - 2));
                    }
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
