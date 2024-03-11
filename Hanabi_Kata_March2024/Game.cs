

namespace Hanabi_Kata_March2024
{
    internal class Game
    {
        const int MAX_ALLOWED_MISTAKES = 3;
        public int NumberOfMistakesMade { get; private set; }
        public Game()
        {
            NumberOfMistakesMade = 0;
        }

        internal bool IsLost()
        {
            if (NumberOfMistakesMade == MAX_ALLOWED_MISTAKES) return true;
            return false;
        }

        internal bool IsOver()
        {
            if (IsLost()) return true;
            return false;
        }

        internal void MistakeIsMade()
        {
            NumberOfMistakesMade++;
        }
    }
}