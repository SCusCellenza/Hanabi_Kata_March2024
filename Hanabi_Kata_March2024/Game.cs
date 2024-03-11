

namespace Hanabi_Kata_March2024
{
    internal class Game
    {

        public int NumberOfMistakesMade { get; private set; }
        public Game()
        {
            NumberOfMistakesMade = 0;
        }


        internal bool IsLost()
        {
            if (NumberOfMistakesMade == 3) return true;
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