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
        public Pawn(TypePiece type,  Point point) : base(type, point)
        {
        }

        protected override List<Point> GetPossibleMoves(List<Piece> pieces)
        {
            List<Point> list = new List<Point>();

            // Detecta peças que podem ser pegas
            foreach (Piece p in pieces)
            {
                if (p.PiecePoint.Y == (PiecePoint.Y + 1) && !pieces.Equals(this))
                {
                    if (p.PiecePoint.X == (PiecePoint.X + 1) || p.PiecePoint.X == (PiecePoint.X - 1))
                    {
                        list.Add(p.PiecePoint);
                    }
                }
            }

            //Detecta demais posições
            switch (PiecePoint.Y)
            {
                case 2:
                    
                    foreach (Piece p in pieces)
                    {
                        if (p.PiecePoint.Y ==)
                    }
                    list.Add(new Point(PiecePoint.X, PiecePoint.Y + 2));
                    list.Add(new Point(PiecePoint.X, PiecePoint.Y + 1));

                    return list;

                case 8: return new List<Point> { null };
                default: return new List<Point> { new Point(PiecePoint.X, PiecePoint.Y + 2) };
            }
        }
    }
}
