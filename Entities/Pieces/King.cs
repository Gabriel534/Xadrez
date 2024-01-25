using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Entities.Utilities;

namespace Xadrez.Entities.Pieces
{
    internal class King : Piece
    {
        public King(TypePiece type, Point point) : base(type, point)
        {
        }

        public override List<Point> GetPossibleMoves(List<Piece> pieces)
        {
            List<Point> result = new List<Point>();
            if (this.PiecePoint.X != 8)
            {
                result.Add(new Point(this.PiecePoint.X + 1, this.PiecePoint.Y));
            }
            if (this.PiecePoint.X != 1)
            {
                result.Add(new Point(this.PiecePoint.X - 1, this.PiecePoint.Y));
            }
            if (this.PiecePoint.Y != 1)
            {
                result.Add(new Point(this.PiecePoint.X, this.PiecePoint.Y - 1));
            }
            if (this.PiecePoint.Y != 8)
            {
                result.Add(new Point(this.PiecePoint.X, this.PiecePoint.Y + 1));
            }

            Point pointEqual;

            foreach (Piece piece in pieces)
            {
                pointEqual = result.Find(point => point.X == piece.PiecePoint.X && point.Y == piece.PiecePoint.Y);
                if (pointEqual != null && piece.Type == this.Type)
                {
                    result.Remove(pointEqual);
                }
            }

            return result;
        }

        public override string ToString()
        {
            return "K";
        }
    }
}
