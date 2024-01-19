using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Exceptions;

namespace Xadrez.Entities
{
    internal class Point
    {

        private int _x;
        private int _y;

        public int X
        {
            set
            {
                if (value <= 8 && value > 0)
                {
                    _x = value;
                }
                else
                {
                    throw new InvalidPointException("Ponto definido cai fora do tabuleiro 8x8");
                }
            }
            get { return _x; }
        }

        public int Y
        {
            set
            {
                if (value <= 8 && value > 0)
                {
                    _y = value;
                }
                else
                {
                    throw new InvalidPointException("Ponto definido cai fora do tabuleiro 8x8");
                }
            }
            get { return _y; }
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return "X: "
                + X
                + ", Y: "
                + Y;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Point)) return false;

            Point p = (Point)obj;
            if (p.X == X && p.Y == Y) return true;
            return false;
        }



    }
}
