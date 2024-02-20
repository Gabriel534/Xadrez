using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Entities.Comparators;
using Xadrez.Entities.Utilities;

namespace Xadrez.Entities.Pieces
{
    internal class Queen : Piece
    {
        public Queen(TypePiece type, XadrezPoint point) : base(type, point) { }

        public override List<XadrezPoint> GetPossibleMoves(List<Piece> pieces)
        {
            // Cria a lista de pontos
            List<XadrezPoint> result = new List<XadrezPoint>();


            // Determina qual a máxima e mínima casa que as posições possíveis podem chegar
            int Maximo = 8;
            int Minimo = 1;

            // Ordena a lista pelo valor X da peça de forma Crescente
            pieces.Sort(ComparePiece.CompareByX);

            // Verifica todos os lugares possíveis para peça pelo eixo x
            // Verifica as peças a esquerda
            foreach (Piece p in pieces)
            {
                if (p.PiecePoint.Y == PiecePoint.Y && p.PiecePoint.X > this.PiecePoint.X)
                {
                    if (p.Type == this.Type)
                    {
                        Maximo = p.PiecePoint.X - 1;
                        break;
                    }
                    else
                    {
                        Maximo = p.PiecePoint.X;
                        break;
                    }
                }
            }

            // Ordena a lista pelo valor X da peça de forma Decrescente
            pieces.Sort(ComparePiece.CompareByXInverse);

            // Verifica as peças a direita
            foreach (Piece p in pieces)
            {
                if (p.PiecePoint.Y == PiecePoint.Y && p.PiecePoint.X < this.PiecePoint.X)
                {
                    if (p.Type == this.Type)
                    {
                        Minimo = p.PiecePoint.X + 1;
                        break;
                    }
                    else
                    {
                        Minimo = p.PiecePoint.X;
                        break;
                    }
                }
            }

            // Adiciona as posições da esquerda e da direita
            for (int i = this.PiecePoint.X + 1; i < Maximo + 1; i++)
            {
                result.Add(new XadrezPoint(i, this.PiecePoint.Y));
            }

            for (int i = Minimo; i < this.PiecePoint.X; i++)
            {
                result.Add(new XadrezPoint(i, this.PiecePoint.Y));
            }

            // Refaz as variáveis de controle
            Maximo = 8;
            Minimo = 1;

            // Reordena as peças pelo Y agora
            pieces.Sort(ComparePiece.CompareByY);

            // Verifica as peças abaixo
            foreach (Piece p in pieces)
            {
                if (p.PiecePoint.X == PiecePoint.X && p.PiecePoint.Y > this.PiecePoint.Y)
                {
                    if (p.Type == this.Type)
                    {
                        Maximo = p.PiecePoint.Y - 1;
                        break;
                    }
                    else
                    {
                        Maximo = p.PiecePoint.Y;
                        break;
                    }
                }
            }

            // Ordena a lista pelo valor Y da peça de forma decrescente
            pieces.Sort(ComparePiece.CompareByYInverse);

            // Verifica as peças abaixo
            foreach (Piece p in pieces)
            {
                if (p.PiecePoint.X == PiecePoint.X && p.PiecePoint.Y < this.PiecePoint.Y)
                {
                    if (p.Type == this.Type)
                    {
                        Minimo = p.PiecePoint.Y + 1;
                        break;
                    }
                    else
                    {
                        Minimo = p.PiecePoint.Y;
                        break;
                    }
                }
            }

            // Adiciona as posições de cima e de baixo
            for (int i = this.PiecePoint.Y + 1; i < Maximo + 1; i++)
            {
                result.Add(new XadrezPoint(this.PiecePoint.X, i));
            }

            for (int i = Minimo; i < this.PiecePoint.Y; i++)
            {
                result.Add(new XadrezPoint(this.PiecePoint.X, i));
            }

            //------------------------------------------------------------------------------------------------------------------------------------------

            int cont = 1;
            XadrezPoint point;
            Piece piece;

            // Verifica as casas disponíveis na diagonal direita abaixo
            while (cont + this.PiecePoint.X < 9 && cont + this.PiecePoint.Y < 9)
            {
                point = new XadrezPoint(this.PiecePoint.X + cont, this.PiecePoint.Y + cont);
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

            // Verifica as casas disponíveis na diagonal direita acima
            while (cont + this.PiecePoint.X < 9 && this.PiecePoint.Y - cont > 0)
            {
                point = new XadrezPoint(this.PiecePoint.X + cont, this.PiecePoint.Y - cont);
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
                point = new XadrezPoint(this.PiecePoint.X - cont, this.PiecePoint.Y + cont);
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
                point = new XadrezPoint(this.PiecePoint.X - cont, this.PiecePoint.Y - cont);
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
            return "Q";
        }
    }
}
