using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Entities.Pieces;
using Xadrez.Entities.Utilities;
using Xadrez.Exceptions;
using Xadrez.Services;

namespace Xadrez.Entities
{
    internal class Board
    {
        public List<Piece> Pieces = new List<Piece>();
        public HashSet<Piece> BkpPieces = new HashSet<Piece>();

        // Teste delegate
        //private delegate bool RetornaXeque(Piece p, Piece king);

        public Board(params Piece[] pieces)
        {
            // Adiciona todas as peças ao tabuleiro
            foreach (Piece piece in pieces)
            {
                foreach (Piece piece2 in Pieces)
                {
                    if (piece.PiecePoint.Equals(piece2.PiecePoint))
                    {
                        throw new InvalidPointException("Ponto utilizado já utilizado por outra peça");
                    }
                }
                Pieces.Add(piece);
                BkpPieces.Add(piece);
            }

        }

        // Mostra no terminal quais peças foram comidas
        public void UpdateBoardWithHighlightedPieces(List<Point> points) // Recebe os pontos que ele deve destacar na tela
        {
            bool PointBool;

            // Limpa o console
            //Console.Clear();

            // Percorre os pontos no tabuleiro
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {

                    PointBool = false;

                    // Coloca o fundo como padrão Preto
                    System.Console.BackgroundColor = ConsoleColor.Black;

                    // Verifica se o ponto deve ser destacado ou não no tabuleiro
                    foreach (Point p in points)
                    {
                        if (p.Equals(new Point(j, i)))
                        {
                            System.Console.BackgroundColor = ConsoleColor.White;
                        }
                    }

                    // Verifica se tem peças a serem colocadas nesta posição

                    foreach (Piece piece in Pieces)
                    {
                        if (piece.PiecePoint.X == j && piece.PiecePoint.Y == i)
                        {
                            if (piece.Type == TypePiece.BLACK)
                            {
                                System.Console.ForegroundColor = ConsoleColor.DarkYellow;
                            }

                            Console.Write(" " + piece.ToString());
                            PointBool = true;
                            System.Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }


                    // Caso não houver peças na posição, é colocado um traço
                    if (!PointBool)
                    {
                        Console.Write(" -");
                    }
                }
                // No final é quebradoa  linha
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        // Obtém quais peças foram comidas no tabuleiro
        public string GetEatedPieces(TypePiece type)
        {
            string result = "[";

            List<Piece> difference = new List<Piece>();

            difference = BkpPieces.Except(Pieces).ToList();

            foreach (Piece piece in difference)
            {
                if (piece.Type == type)
                {
                    result += piece.ToString();
                    result += ", ";
                }
            }
            if (result.Length > 2) result = result.Substring(0, result.Length - 2);

            result += "]";
            return result;

        }

        // Obtém um objeto Point a partir de coordenadas do terminal
        public Point GetPointTerminal()
        {
            string posString;
            Point point;

            posString = Console.ReadLine();

            // Converte um texto em um ponto
            try
            {
                point = XadrezTools.ConvertStringIntoPoint(posString);
            }
            catch (InvalidStringPointException e)
            {
                Console.WriteLine("Ponto inválido");
                return null;
            }

            return point;
        }

        // Obtém um objeto peça a partir de coordenadas do terminal
        public Piece GetPieceTerminal()
        {
            Piece piece;
            Point point;

            // Converte um texto em um ponto
            try
            {
                point = GetPointTerminal();
            }
            catch (InvalidStringPointException e)
            {
                return null;
            }

            // Procura a peça mencionada pela posição
            piece = this.Pieces.Find(p => p.PiecePoint.Equals(point));

            // Se não encontrar a peça, manda mensagem e reinicia o loop
            if (piece == null)
            {
                Console.WriteLine("Peça não encontrada");

                return null;
            }

            // retorna a peça
            return piece;
        }

        // Faz o loop do jogo no terminal
        public void LoopGame()
        {
            string posString;
            Piece piece;
            Point pointAttack;
            List<Point> PossiblePoints = new List<Point>();

            while (true)
            {
                PossiblePoints.Clear();

                // Atualiza o tabuleiro na tela
                this.UpdateBoardWithHighlightedPieces(PossiblePoints);

                // mostra as peças comidas de cada jogador
                Console.WriteLine("Preto: " + this.GetEatedPieces(TypePiece.BLACK));
                Console.WriteLine("Branco: " + this.GetEatedPieces(TypePiece.WHITE));

                // Obtém a posição desejada
                Console.Write("Origem: \n:> ");

                piece = GetPieceTerminal();
                if (piece == null)
                {
                    PossiblePoints.Clear();
                    continue;
                }

                PossiblePoints = FilterPieceMovement(piece);

                PossiblePoints.ForEach(Console.WriteLine);

                // Atualiza novamente o tabuleiro na tela com os movimentos
                this.UpdateBoardWithHighlightedPieces(PossiblePoints);

                Console.WriteLine("Preto: " + this.GetEatedPieces(TypePiece.BLACK));
                Console.WriteLine("Branco: " + this.GetEatedPieces(TypePiece.WHITE));

                // Pede a posição do destino ao usuário
                Console.Write("Destino:\n:> ");

                try
                {
                    pointAttack = this.GetPointTerminal();
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                try
                {
                    CheckPieceMovement(piece, pointAttack);
                }
                catch (InvalidPointException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (System.NullReferenceException e)
                {
                    Console.WriteLine("Comandos inválidos");
                    continue;
                }
            }
        }

        // Controla o movimento das peças e impõe regras gerais do jogo, como o xeque do rei e etc
        public List<Point> FilterPieceMovement(Piece piece)
        {
            // Encontra um rei da mesma cor da peça
            Piece king = Pieces.Find(x => x.ToString() == "K" && x.Type == piece.Type);

            // Obtém os possíveis movimentos da peça
            List<Point> moves = piece.GetPossibleMoves(this.Pieces);

            // Encontra xeques com o rei especificado anteriormente
            List<Piece> xeques = Pieces.FindAll(RetornaXeque(piece, king));

            xeques.ForEach(Console.WriteLine);

            // se não achar nenhum xeque, retorna os movimentos normalmente
            if (xeques.Count == 0)
            {
                return moves;
            }

            // Se achar xeque, só pode mover o rei ou usar a peça para matar a peça que causou o xeque

            Point pointMove;

            List<Point> newMoves = new List<Point>();
            foreach (Piece p in xeques)
            {
                pointMove = moves.Find(x => p.PiecePoint.Equals(x));
                if(pointMove != null)
                {
                    newMoves.Add(pointMove);
                }
                
            }

            // Se a peça for um rei, adiciona os movimentos para escapar também
            if (piece is King)
            {
                foreach(Point move in moves)
                {
                    if(Pieces.Find(x=> x.PiecePoint.Equals(move)) == null)
                    {
                        Console.WriteLine(move);
                        newMoves.Add(move);
                    }
                }
            }

            return newMoves;
        }

        //Func<Piece, bool> RetornaXeque(Piece piece, Piece king)
        // Closure que retorna outra função
        Predicate<Piece> RetornaXeque(Piece piece, Piece king)
        {
            return (x) =>
            {
                List<Point> possibilidades = x.GetPossibleMoves(Pieces);

                foreach (Point p in possibilidades)
                {

                    if (p.Equals(king.PiecePoint) && piece.Type != x.Type)
                    {
                        return true;
                    }

                }
                return false;
            };


        }


        // Faz o movimento apenas se for permitido oelo FilterPieceMovement
        public void CheckPieceMovement(Piece piece, Point pointAttack)
        {

            Point p = FilterPieceMovement(piece).Find(x => pointAttack.Equals(x));


            if (p == null)
            {
                throw new InvalidPointException("Ponto de ataque da peça inválido");
            }
            piece.MakeMovement(pointAttack, this.Pieces);
        }
    }
}

