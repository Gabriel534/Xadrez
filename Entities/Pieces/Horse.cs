using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Entities.Utilities;

namespace Xadrez.Entities.Pieces
{
    internal class Horse : Piece
    {
        public Horse(TypePiece type, Point point) : base(type, point)
        {
        }

        public override List<Point> GetPossibleMoves(List<Piece> pieces)
        {
            List<Point> result = new List<Point>();
            Point point;
            
            //Adiciona a lista todos os movimentos possíveis do cavalo dentro do tabuleiro
            if (this.PiecePoint.X + 2 < 9 && this.PiecePoint.Y + 1 < 9) result.Add(new Point(this.PiecePoint.X + 2, this.PiecePoint.Y + 1));
            if (this.PiecePoint.X + 2 < 9 && this.PiecePoint.Y - 1 > 0) result.Add(new Point(this.PiecePoint.X + 2, this.PiecePoint.Y - 1));
            if (this.PiecePoint.X - 2 > 0 && this.PiecePoint.Y + 1 < 9) result.Add(new Point(this.PiecePoint.X - 2, this.PiecePoint.Y + 1));
            if (this.PiecePoint.X - 2 > 0 && this.PiecePoint.Y - 1 > 0) result.Add(new Point(this.PiecePoint.X - 2, this.PiecePoint.Y - 1));
            if (this.PiecePoint.X + 1 < 9 && this.PiecePoint.Y + 2 < 9) result.Add(new Point(this.PiecePoint.X + 1, this.PiecePoint.Y + 2));
            if (this.PiecePoint.X + 1 < 9 && this.PiecePoint.Y - 2 > 0) result.Add(new Point(this.PiecePoint.X + 1, this.PiecePoint.Y - 2));
            if (this.PiecePoint.X - 1 > 0 && this.PiecePoint.Y + 2 < 9) result.Add(new Point(this.PiecePoint.X - 1, this.PiecePoint.Y + 2));
            if (this.PiecePoint.X - 1 > 0 && this.PiecePoint.Y - 2 > 0) result.Add(new Point(this.PiecePoint.X - 1, this.PiecePoint.Y - 2));

            foreach(Piece p in pieces)
            {
                point = result.Find(x => x.X == p.PiecePoint.X && x.Y == p.PiecePoint.Y);
                if(point != null && p.Type == this.Type)
                {
                    result.Remove(point);
                }
            }

            return result;
        }

        public override string ToString()
        {
            return "H";
        }
    }
}
