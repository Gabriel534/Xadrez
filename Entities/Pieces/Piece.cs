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
        public TypePiece TypePiece { get; set; }

        protected Piece(TypePiece type, Point point) { 

            PiecePoint = point;
            TypePiece = type;
        }

        protected abstract List<Point> GetPossibleMoves(List<Piece> points); //Possíveis locais para se colocar uma peça

        protected virtual void MakeMovement(Point point, List<Piece> points)
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

        
    }
}
