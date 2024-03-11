



namespace Hanabi_Kata_March2024
{
    internal class Game
    {
        const int MAX_ALLOWED_MISTAKES = 3;
        const int MAX_COMPLETED_SEQUENCES = 5;

        public int NumberOfMistakesMade { get; private set; }
        public int NumberOfCompletedSequences { get; internal set; }

        public Game()
        {
            NumberOfMistakesMade = 0;
            NumberOfCompletedSequences = 0;
        }

        internal bool IsLost()
        {
            if (NumberOfMistakesMade == MAX_ALLOWED_MISTAKES) return true;
            return false;
        }

        internal bool IsOver()
        {
            if (IsLost()) return true;
            if (IsWon()) return true;
            return false;
        }

        internal void MistakeIsMade()
        {
            NumberOfMistakesMade++;
        }

        internal void ASequenceIsCompleted()
        {
            NumberOfCompletedSequences++;
        }

        internal bool IsWon()
        {
            if (NumberOfCompletedSequences == MAX_COMPLETED_SEQUENCES) return true;
            return false;
        }
    }
}