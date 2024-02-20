using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Xadrez.Entities;
using Xadrez.Entities.Comparators;
using Xadrez.Entities.Pieces;
using Xadrez.Entities.Utilities;
using Xadrez.Exceptions;
using Xadrez.Services;

namespace Xadrez
{
    internal class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main(string[] args)
        {

            Board tabuleiro = new Board(
                new Pawn(TypePiece.BLACK, new XadrezPoint(1, 2)),
                new Pawn(TypePiece.BLACK, new XadrezPoint(2, 2)),
                new Pawn(TypePiece.BLACK, new XadrezPoint(3, 2)),
                new Pawn(TypePiece.BLACK, new XadrezPoint(4, 2)),
                new Pawn(TypePiece.BLACK, new XadrezPoint(5, 2)),
                new Pawn(TypePiece.BLACK, new XadrezPoint(6, 2)),
                new Pawn(TypePiece.BLACK, new XadrezPoint(7, 2)),
                new Pawn(TypePiece.BLACK, new XadrezPoint(8, 2)),
                new Pawn(TypePiece.WHITE, new XadrezPoint(1, 7)),
                new Pawn(TypePiece.WHITE, new XadrezPoint(2, 7)),
                new Pawn(TypePiece.WHITE, new XadrezPoint(3, 7)),
                new Pawn(TypePiece.WHITE, new XadrezPoint(4, 7)),
                new Pawn(TypePiece.WHITE, new XadrezPoint(5, 7)),
                new Pawn(TypePiece.WHITE, new XadrezPoint(6, 7)),
                new Pawn(TypePiece.WHITE, new XadrezPoint(7, 7)),
                new Pawn(TypePiece.WHITE, new XadrezPoint(8, 7)),
                new Tower(TypePiece.BLACK, new XadrezPoint(1, 1)),
                new Tower(TypePiece.WHITE, new XadrezPoint(1, 8)),
                new Tower(TypePiece.BLACK, new XadrezPoint(8, 1)),
                new Tower(TypePiece.WHITE, new XadrezPoint(8, 8)),
                new King(TypePiece.BLACK, new XadrezPoint(5, 1)),
                new King(TypePiece.WHITE, new XadrezPoint(5, 8)),
                new Bishop(TypePiece.WHITE, new XadrezPoint(3, 8)),
                new Bishop(TypePiece.WHITE, new XadrezPoint(6, 8)),
                new Bishop(TypePiece.BLACK, new XadrezPoint(3, 1)),
                new Bishop(TypePiece.BLACK, new XadrezPoint(6, 1)),
                new Queen(TypePiece.WHITE, new XadrezPoint(4, 8)),
                new Queen(TypePiece.BLACK, new XadrezPoint(4, 1)),
                new Horse(TypePiece.BLACK, new XadrezPoint(2, 1)),
                new Horse(TypePiece.BLACK, new XadrezPoint(7, 1)),
                new Horse(TypePiece.WHITE, new XadrezPoint(2, 8)),
                new Horse(TypePiece.WHITE, new XadrezPoint(7, 8)));

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new TelaXadrez(tabuleiro));



        }
    }
}
