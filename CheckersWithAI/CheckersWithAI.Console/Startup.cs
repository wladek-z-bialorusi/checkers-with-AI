﻿using CheckersWithAI.ConsoleUI.Enums;
using CheckersWithAI.ConsoleUI.Interfaces;

namespace CheckersWithAI.ConsoleUI
{
    internal class StartUp
    {
        internal static void Run()
        {
            IBoard? board = new Board();
            Graphics.Display(board);
            Console.Read();
            //while (board.GameStatus == GameStatus.Running)
            //{
            //    board.PlayerMakesMove(new ConsoleMoveInput().GetMove());
            //    Graphics.Display(board);
            //    board.AIMakesMove();
            //    Graphics.Display(board);
            //}

            //if (board.GameStatus == GameStatus.PlayerWon)
            //{
            //    Console.WriteLine("You won!");
            //}
            //else
            //{
            //    Console.WriteLine("AI won! (and soon will take over the world ;))");
            //}
        }
    }
}
