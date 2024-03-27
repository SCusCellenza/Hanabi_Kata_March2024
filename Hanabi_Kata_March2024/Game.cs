


using Xunit.Sdk;

namespace Hanabi_Kata_March2024
{
    internal class Game
    {
        const int MAX_ALLOWED_MISTAKES = 3;
        const int MAX_COMPLETED_SEQUENCES = 5;

        public int NumberOfMistakesMade { get; private set; }
        public int NumberOfCompletedSequences { get; private set; }


        public bool AllPlayersPlayedDuringLastRound { get; internal set; }

        public Deck Deck;

        public Game(Deck deck)
        {
            NumberOfMistakesMade = 0;
            NumberOfCompletedSequences = 0;
            AllPlayersPlayedDuringLastRound = false;
            Deck = deck;
        }
        internal void MistakeIsMade()
        {
            NumberOfMistakesMade++;
        }

        internal void ASequenceIsCompleted()
        {
            NumberOfCompletedSequences++;
        }

        public bool IsInItsLastRound()
        {
            if (Deck.Count() > 0) { return false; }
            return true;
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
            //TODO : not implemented
            if (AllPlayersPlayedDuringLastRound) return true;
            
            return false;
        }


        internal bool IsWon()
        {
            if (NumberOfCompletedSequences == MAX_COMPLETED_SEQUENCES) return true;
            return false;
        }

    }
}