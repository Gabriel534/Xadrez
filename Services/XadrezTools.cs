using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Entities;
using Xadrez.Entities.Utilities;
using Xadrez.Exceptions;

namespace Xadrez.Services
{
    internal static class XadrezTools
    {

        // Converte um ponto em uma string ex saída: f8, g4
        public static string ConvertPointIntoString(Point point)
        {
            switch(point.X)
            {
                case 1: return "a" + point.Y;
                case 2: return "b" + point.Y;
                case 3: return "c" + point.Y;
                case 4: return "d" + point.Y;
                case 5: return "e" + point.Y;
                case 6: return "f" + point.Y;
                case 7: return "g" + point.Y;
                case 8: return "h" + point.Y;
                default: throw new InvalidPointException("Ponto recebido inválido para o Xadrez");
            }
        }
        // Converte uma string em um ponto


        // ex de entrada: f8, g4

        public static int ConvertPointIntoANumber(XadrezPoint point)
        {
            int result = 0;
            result += (point.Y-1) * 8;
            result += point.X;
            return result;
        }

        public static XadrezPoint ConvertNumberIntoAPoint(int number)
        {
            int x, y;
            if(number%8 == 0)
            {
                x = 8;
            }
            else
            {
                x = number%8;
            }

            y = (int)Math.Ceiling((double)number / 8);

            return new XadrezPoint(x, y);
        }

        public static XadrezPoint ConvertStringIntoPoint(string pos)
        {
            int x;
            int y;

            pos = pos.Trim();

            if (pos.Length != 2)
            {
                throw new InvalidStringPointException("A string deve ter 2 caracteres, sendo o primeiro de 'a' a 'g', e o segundo um número de 1 a 8");
            }

            string letter = pos.Substring(0, 1);

            y = int.Parse(pos.Substring(1, 1));

            switch (char.Parse(letter))
            {
                case 'a':
                    x = 1;
                    break;
                case 'b':
                    x = 2;
                    break;
                case 'c':
                    x = 3;
                    break;
                case 'd':
                    x = 4;
                    break;
                case 'e':
                    x = 5;
                    break;
                case 'f':
                    x = 6;
                    break;
                case 'g':
                    x = 7;
                    break;
                case 'h':
                    x = 8;
                    break;
                default: throw new InvalidStringPointException("Letra inválida (de 'a' a 'g' apenas)");
            }

            try
            {
                return new XadrezPoint(x, y);
            }
            catch (InvalidPointException)
            {
                throw new InvalidStringPointException("Numero inválido (de 1 a 8 apenas)");
            }
        }
    }
}
