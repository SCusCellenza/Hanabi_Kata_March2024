
namespace Hanabi_Kata_March2024
{
    internal class GameFactory
    {
        public List<Player> Players = new List<Player>();


        internal Game TryCreateGame(int numberOfPlayers)
        {
            Deck cardDeck = new Deck();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                Players.Add(new Player(cardDeck.DealHand(4)));
            }
            return new Game(cardDeck, Players);
        }
    }
}