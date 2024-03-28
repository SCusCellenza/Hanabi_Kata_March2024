
namespace Hanabi_Kata_March2024
{
    internal class GameFactory
    {
        public List<Player> Players = new List<Player>();
        public Deck cardDeck { get; private set; }


        internal Game TryCreateGame(int numberOfPlayers)
        {
            if (numberOfPlayers < 2 || numberOfPlayers > 5)
            {
                throw new System.ArgumentException("Number of players must be between 2 and 5");
            }
            cardDeck = new Deck();
            DealHands(numberOfPlayers, cardDeck);

            return new Game(cardDeck, Players);
        }

        private void DealHands(int numberOfPlayers, Deck cardDeck)
        {
            int numberOfCardsPerPlayer;

            if (numberOfPlayers == 2 || numberOfPlayers == 3)
            {
                numberOfCardsPerPlayer = 5;
            }
            else
            {
                numberOfCardsPerPlayer = 4;
            }

            for (int i = 0; i < numberOfPlayers; i++)
            {
                Players.Add(new Player(cardDeck.DealHand(numberOfCardsPerPlayer)));
            }
        }
    }
}