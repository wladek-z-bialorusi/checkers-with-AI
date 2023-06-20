using CheckersWithAI.ConsoleUI.Interfaces;
using CheckersWithAI.ConsoleUI.Models;

namespace CheckersWithAI.ConsoleUI
{
    internal class ConsoleMoveInput : IMoveInput
    {
        public Move GetMove()
        {
            string? input;
            while (true)
            {
                input = Console.ReadLine();
                if (IsValid(input))
                {
                    return new Move(input[0], input[1] - '0', input[3], input[4] - 1);
                }
            }
        }

        private static bool IsValid(string? input)
            => input != null &&
                input.Length == 2 &&
                input[0] >= Constants.minLetter &&
                input[0] <= Constants.maxLetter &&
                input[1] >= '0' + Constants.minNumber &&
                input[1] <= '0' + Constants.maxNumber &&
                input[2] == ' ' &&
                input[3] >= Constants.minLetter &&
                input[3] <= Constants.maxLetter &&
                input[4] >= '0' + Constants.minNumber &&
                input[4] <= '0' + Constants.maxNumber;
    }
}
