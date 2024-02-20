using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xadrez.Entities;
using Xadrez.Services;

namespace Xadrez
{
    internal partial class TelaXadrez : Form
    {
        Board Tabuleiro;

        public TelaXadrez(Board board)
        {
            InitializeComponent();
            Tabuleiro = board;
            Tabuleiro.UpdateBoardWithHighlightedPieces(new List<XadrezPoint>(), this);
        }

        private void TelaXadrez_Load(object sender, EventArgs e)
        {
            
        }

        private void Piece_Click(object sender, EventArgs e)
        {
            if (sender is not Button)
            {
                throw new InvalidCastException("Evento iniciado fora de um botão");
            }

            Button pieceButton = (Button)sender;

            if (pieceButton.Image == null)
            {
                return;
            }

            int number = int.Parse(pieceButton.Name.Substring(1));

            Piece piece = Tabuleiro.Pieces.Find(x => x.PiecePoint.Equals(XadrezTools.ConvertNumberIntoAPoint(number)));

            if (piece != null)
            {
                Tabuleiro.UpdateBoardWithHighlightedPieces(piece.GetPossibleMoves(Tabuleiro.Pieces), this);
            }

        }

    }
}
