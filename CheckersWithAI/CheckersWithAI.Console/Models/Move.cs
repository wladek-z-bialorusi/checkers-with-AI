namespace CheckersWithAI.ConsoleUI.Models
{
    internal class Move
    {
        public Move(char letter, int number)
        {
            Letter = letter;
            Number = number;
        }

        public char Letter { get; }

        public int Number { get; }
    }
}
