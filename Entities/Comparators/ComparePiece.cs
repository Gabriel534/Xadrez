
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Entities.Utilities;

namespace Xadrez.Entities.Comparators
{
    internal static class ComparePiece
    {
        public static int CompareByX(Piece piece1, Piece piece2)
        {
            return piece1.PiecePoint.X.CompareTo(piece2.PiecePoint.X);
        }

        public static int CompareByY(Piece piece1, Piece piece2)
        {
            return piece1.PiecePoint.Y.CompareTo(piece2.PiecePoint.Y);
        }

        public static int CompareByXInverse(Piece piece1, Piece piece2)
        {
            return piece2.PiecePoint.X.CompareTo(piece1.PiecePoint.X);
        }

        public static int CompareByYInverse(Piece piece1, Piece piece2)
        {
            return piece2.PiecePoint.Y.CompareTo(piece1.PiecePoint.Y);
        }
    }
}
