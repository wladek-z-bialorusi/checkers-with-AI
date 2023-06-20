using CheckersWithAI.ConsoleUI.Models;

namespace CheckersWithAI.ConsoleUI.Interfaces
{
    internal interface IBoard
    {
        /// <returns>Was any piece captured.</returns>
        bool PlayerMakesMove(Move move);

        /// <returns>Was any piece captured.</returns>
        bool AIMakesMove();

        GameStatus GameStatus { get; }
    }
}
