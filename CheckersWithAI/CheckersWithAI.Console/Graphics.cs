using CheckersWithAI.ConsoleUI.Interfaces;

namespace CheckersWithAI.ConsoleUI
{
    internal static class Graphics
    {
        internal static void Display(IBoard board)
        {
            Console.SetCursorPosition(0, 1);
            Console.WriteLine(board.ToString());
            Console.SetCursorPosition(0, 0);
        }
    }
}
