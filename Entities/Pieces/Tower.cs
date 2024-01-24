using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Entities.Comparators;
using Xadrez.Entities.Utilities;
using Xadrez.Entities.Comparators;

namespace Xadrez.Entities.Pieces
{
    internal class Tower : Piece
    {
        public Tower(TypePiece type, Point point) : base(type, point) { }


        public override List<Point> GetPossibleMoves(List<Piece> pieces)
        {
            // Cria a lista de pontos
            List<Point> result = new List<Point>();


            // Determina qual a máxima e mínima casa que as posições possíveis podem chegar
            int Maximo = 8;
            int Minimo = 1;

            // Ordena a lista pelo valor X da peça de forma Crescente
            pieces.Sort(ComparePiece.CompareByX);

            // Verifica todos os lugares possíveis para peça pelo eixo x
            // Verifica as peças a esquerda
            foreach (Piece piece in pieces)
            {
                if (piece.PiecePoint.Y == PiecePoint.Y && piece.PiecePoint.X > this.PiecePoint.X)
                {
                    if (piece.Type == this.Type)
                    {
                        Maximo = piece.PiecePoint.X - 1;
                        break;
                    }
                    else
                    {
                        Maximo = piece.PiecePoint.X;
                        break;
                    }
                }
            }

            // Ordena a lista pelo valor X da peça de forma Decrescente
            pieces.Sort(ComparePiece.CompareByXInverse);

            // Verifica as peças a direita
            foreach (Piece piece in pieces)
            {
                if (piece.PiecePoint.Y == PiecePoint.Y && piece.PiecePoint.X < this.PiecePoint.X)
                {
                    if (piece.Type == this.Type)
                    {
                        Minimo = piece.PiecePoint.X + 1;
                        break;
                    }
                    else
                    {
                        Minimo = piece.PiecePoint.X;
                        break;
                    }
                }
            }

            // Adiciona as posições da esquerda e da direita
            for(int i = this.PiecePoint.X+1; i<Maximo+1; i++)
            {
                result.Add(new Point(i, this.PiecePoint.Y));
            }

            for (int i = Minimo; i < this.PiecePoint.X; i++)
            {
                result.Add(new Point(i, this.PiecePoint.Y));
            }

            // Refaz as variáveis de controle
            Maximo = 8;
            Minimo = 1;

            // Reordena as peças pelo Y agora
            pieces.Sort(ComparePiece.CompareByY);

            // Verifica as peças abaixo
            foreach (Piece piece in pieces)
            {
                if (piece.PiecePoint.X == PiecePoint.X && piece.PiecePoint.Y > this.PiecePoint.Y)
                {
                    if(piece.Type == this.Type)
                    {
                        Maximo = piece.PiecePoint.Y - 1;
                        break;
                    }else
                    {
                        Maximo = piece.PiecePoint.Y;
                        break;
                    }
                }
            }

            // Ordena a lista pelo valor Y da peça de forma decrescente
            pieces.Sort(ComparePiece.CompareByYInverse);

            // Verifica as peças abaixo
            foreach (Piece piece in pieces)
            {
                if (piece.PiecePoint.X == PiecePoint.X && piece.PiecePoint.Y < this.PiecePoint.Y)
                {
                    if (piece.Type == this.Type)
                    {
                        Minimo = piece.PiecePoint.Y + 1;
                        break;
                    }
                    else
                    {
                        Minimo = piece.PiecePoint.Y;
                        break;
                    }
                }
            }

            // Adiciona as posições de cima e de baixo
            for (int i = this.PiecePoint.Y + 1; i < Maximo + 1; i++)
            {
                result.Add(new Point(this.PiecePoint.X, i));
            }

            for (int i = Minimo; i < this.PiecePoint.Y; i++)
            {
                result.Add(new Point(this.PiecePoint.X, i));
            }


            return result;
        }

        public override string ToString()
        {
            return "T";
        }

    }
}
