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
        static Piece? PreviousPiece;

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

            int number = int.Parse(pieceButton.Name.Substring(1));


            // Come a peça caso a peça anterior permita
            if (PreviousPiece != null && pieceButton.BackColor == GlobalVariables.COLOR_BACK_SELECTED_BUTTONS)
            {
                if (PreviousPiece.GetPossibleMoves(Tabuleiro.Pieces).Find(x => x.Equals(XadrezTools.ConvertNumberIntoAPoint(number))) != null)
                {
                    PreviousPiece.MakeMovement(XadrezTools.ConvertNumberIntoAPoint(number), Tabuleiro.Pieces);
                    Tabuleiro.UpdateBoardWithHighlightedPieces(new List<XadrezPoint>(), this);
                    PreviousPiece = null;
                    return;
                }
            }


            // Se não houver imagem e nem peça anterior, ele apenas some com as marcações
            if (pieceButton.Image == null)
            {
                Tabuleiro.UpdateBoardWithHighlightedPieces(new List<XadrezPoint>(), this);
                PreviousPiece = null;
                return;
            }
            

            // Encontra a peça correspondente ao botão
            Piece? piece = Tabuleiro.Pieces.Find(x => x.PiecePoint.Equals(XadrezTools.ConvertNumberIntoAPoint(number)));

            // Se encontrar uma peça selecionada ele mostra os possíveis movimentos no tabuleiro
            if (piece != null)
            {
                Tabuleiro.UpdateBoardWithHighlightedPieces(piece.GetPossibleMoves(Tabuleiro.Pieces), this);
                PreviousPiece = piece;
                return;
            }

        }

    }
}
