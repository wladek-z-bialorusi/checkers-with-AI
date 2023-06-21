using CheckersWithAI.ConsoleUI.Enums;
using CheckersWithAI.ConsoleUI.Interfaces;
using CheckersWithAI.ConsoleUI.Models;
using System;
using System.Text;

namespace CheckersWithAI.ConsoleUI
{
    internal class Board : IBoard
    {
        private readonly Dictionary<(int x, int y), Piece> board;

        public Board()
        {
            board = new Dictionary<(int x, int y), Piece>();
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    if (i % 2 == j % 2)
                    {
                        if (i <= 2)
                        {
                            board.Add((i, j), Piece.Human);
                        }
                        else if (i >= 5)
                        {
                            board.Add((i, j), Piece.AI);
                        }
                        else
                        {
                            board.Add((i, j), Piece.None);
                        }
                    }
                }
            }

        }

        public GameStatus GameStatus
        {
            get
            {
                if (board.All(b => b.Value == Piece.Human || b.Value == Piece.HumanKing))
                {
                    return GameStatus.HumanWon;
                }

                if (board.All(b => b.Value == Piece.AI || b.Value == Piece.AIKing))
                {
                    return GameStatus.HumanWon;
                }

                return GameStatus.Running;
            }
        }

        public bool AIMakesMove()
        {
            throw new NotImplementedException();
        }

        public bool PlayerMakesMove(Move move)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            char[,] array2d = new char[8, 16];
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    if (i % 2 == j % 2)
                    {
                        switch (board[(i, j)])
                        {
                            case Piece.None:
                                array2d[i, j * 2] = ' ';
                                array2d[i, j * 2 + 1] = ' ';
                                break;
                            case Piece.AI:
                                array2d[i, j * 2] = '┌';
                                array2d[i, j * 2 + 1] = '┐';
                                break;
                            case Piece.Human:
                                array2d[i, j * 2] = '╔';
                                array2d[i, j * 2 + 1] = '╗';
                                break;
                            case Piece.AIKing:
                                array2d[i, j * 2] = '└';
                                array2d[i, j * 2 + 1] = '┘';
                                break;
                            case Piece.HumanKing:
                                array2d[i, j * 2] = '╚';
                                array2d[i, j * 2 + 1] = '╝';
                                break;
                        }
                    }
                    else
                    {
                        array2d[i, j * 2] = '█';
                        array2d[i, j * 2 + 1] = '█';
                    }
                    
                }
            }

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("  A B C D E F G H   ");
            stringBuilder.AppendLine();
            for (int i = 0; i < array2d.GetLength(0); ++i)
            {
                stringBuilder.Append((char)('1' + i));
                stringBuilder.Append(' ');
                for (int j = 0; j < array2d.GetLength(1); ++j)
                {
                    stringBuilder.Append(array2d[i, j]);
                }

                stringBuilder.Append(' ');
                stringBuilder.Append((char)('1' + i));
                stringBuilder.Append('\n');
            }

            stringBuilder.AppendLine();
            stringBuilder.AppendLine("  A B C D E F G H   ");

            return stringBuilder.ToString();
        }
    }
}