using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Entities.Utilities;

namespace Xadrez.Entities.Pieces
{
    internal class Bishop: Piece
    {
        public Bishop(TypePiece type, Point point) : base(type, point) { }

        public override List<Point> GetPossibleMoves(List<Piece> pieces)
        {
            List<Point> result = new List<Point>();

            int cont = 1;
            Point point;
            Piece piece;

            // Verifica as casas disponíveis na diagonal direita abaixo
            while(cont + this.PiecePoint.X <9 && cont + this.PiecePoint.Y < 9)
            {
                point = new Point(this.PiecePoint.X + cont, this.PiecePoint.Y + cont);
                piece = pieces.Find(p => p.PiecePoint.Equals(point));
                if(piece != null)
                {
                    if(piece.Type != Type)
                    {
                        result.Add(point);
                    }
                    break;
                }

                result.Add(point);
                cont++;
            }

            // Reinicia o contador
            cont = 1;

            // Verifica as casas disponíveis na diagonal direita acima
            while (cont + this.PiecePoint.X < 9 && this.PiecePoint.Y - cont > 0)
            {
                point = new Point(this.PiecePoint.X + cont, this.PiecePoint.Y - cont);
                piece = pieces.Find(p => p.PiecePoint.Equals(point));
                if (piece != null)
                {
                    if (piece.Type != Type)
                    {
                        result.Add(point);
                    }
                    break;
                }

                result.Add(point);
                cont++;
            }

            // Reinicia o contador
            cont = 1;

            // Verifica as casas disponíveis na diagonal esquerda abaixo
            while (this.PiecePoint.X - cont > 0 && this.PiecePoint.Y + cont < 9)
            {
                point = new Point(this.PiecePoint.X - cont, this.PiecePoint.Y + cont);
                piece = pieces.Find(p => p.PiecePoint.Equals(point));
                if (piece != null)
                {
                    if (piece.Type != Type)
                    {
                        result.Add(point);
                    }
                    break;
                }

                result.Add(point);
                cont++;
            }

            // Reinicia o contador
            cont = 1;

            // Verifica as casas disponíveis na diagonal esquerda acima
            while (this.PiecePoint.X - cont > 0 && this.PiecePoint.Y - cont > 0)
            {
                point = new Point(this.PiecePoint.X - cont, this.PiecePoint.Y - cont);
                piece = pieces.Find(p => p.PiecePoint.Equals(point));
                if (piece != null)
                {
                    if (piece.Type != Type)
                    {
                        result.Add(point);
                    }
                    break;
                }

                result.Add(point);
                cont++;
            }

            return result;
        }

        public override string ToString()
        {
            return "B";
        }
    }
}
