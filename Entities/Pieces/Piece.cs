﻿using System;
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
        public XadrezPoint PiecePoint { get; set; }
        public TypePiece Type { get; set; }

        public Piece Clone()
        {
            return (Piece)this.MemberwiseClone();
        }

        protected Piece(TypePiece type, XadrezPoint point) { 

            PiecePoint = point;
            Type = type;
        }

        public abstract List<XadrezPoint> GetPossibleMoves(List<Piece> pieces); //Possíveis locais para se colocar uma peça

        public virtual void MakeMovement(XadrezPoint point, List<Piece> pieces)
        {
            // Coloca uma peça no lugar especificado e, caso haja alguma peça, ela come a peça
            foreach (XadrezPoint p in GetPossibleMoves(pieces))
            {
                if (p.Equals(point))
                {
                    foreach(Piece piece in pieces)
                    {
                        if (point.Equals(piece.PiecePoint))
                        {
                            if (piece.ToString() == "K")
                            {
                                MessageBox.Show("Impossível comer o rei diretamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            pieces.Remove(piece);
                            break;
                        }
                    }
                    PiecePoint = point;
                    return;
                }
            }
            throw new InvalidPointException("Ponto selecionado invalido");
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
