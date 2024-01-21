using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Entities.Utilities;
using Xadrez.Exceptions;

namespace Xadrez.Entities
{
    internal abstract class Piece
    {

        public Point PiecePoint { get; set; }
        public TypePiece Type { get; set; }

        protected Piece(TypePiece type, Point point) { 

            PiecePoint = point;
            Type = type;
        }

        public abstract List<Point> GetPossibleMoves(List<Piece> points); //Possíveis locais para se colocar uma peça

        public virtual void MakeMovement(Point point, List<Piece> points)
        {
            // Coloca uma peça no lugar especificado e, caso haja alguma peça, ela come a peça
            foreach (Point p in GetPossibleMoves(points))
            {
                if (p.Equals(point))
                {
                    foreach(Piece p2 in points)
                    {
                        if (point.Equals(p2.PiecePoint))
                        {
                            points.Remove(p2);
                        }
                    }
                    PiecePoint = p;
                    return;
                }
            }
            throw new InvalidPointException("Ponto selecionaro invalido");
        }

        public override abstract string ToString();

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public sealed override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
