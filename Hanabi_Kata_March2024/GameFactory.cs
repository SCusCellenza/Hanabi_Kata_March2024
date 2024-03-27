
namespace Hanabi_Kata_March2024
{
    internal class GameFactory
    {
        public List<Player> Players = new List<Player>();


        internal Game TryCreateGame(int numberOfPlayers)
        {
            Deck CardDeck = new Deck();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                //Players.Add(new Player(numberOfPlayers));
            }
            return new Game(CardDeck);
        }
    }
}