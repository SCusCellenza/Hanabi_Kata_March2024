


namespace Hanabi_Kata_March2024
{
    internal class Player
    {
        public int numberOfCardsInDeck;

        public Player(int numberOfPlayers)
        {
            if (numberOfPlayers < 4) 
            {
                numberOfCardsInDeck = 5;
                return;
            }
            numberOfCardsInDeck = 4;
        }


    }
}