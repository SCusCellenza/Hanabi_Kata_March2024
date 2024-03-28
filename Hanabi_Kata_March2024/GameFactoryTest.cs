


namespace Hanabi_Kata_March2024
{
    public class GameFactoryTest
    {
        [Fact]
        public void WhenGameFactoryIsCalled_ThenGameIsCreated()
        {
            //Arrange
            int numberOfPlayers = 2;
            GameFactory gameFactory = new GameFactory();

            //Act
            Game game  = gameFactory.TryCreateGame(numberOfPlayers);

            //Assert
            Assert.NotNull(game);
        }

        [Fact]
        public void WhenGameFactoryIsCalled_ThenACollectionOfNPlayersIsCreated()
        {
            //Arrange
            int numberOfPlayers = 2;
            GameFactory gameFactory = new GameFactory();

            //Act
            Game game = gameFactory.TryCreateGame(numberOfPlayers);

            //Assert
            Assert.Equal(numberOfPlayers, gameFactory.Players.Count());
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        public void WhenAGameFactoryIsCalledFor2or3Players_ThenEachPlayerReceives5Cards(int numberOfPlayers)
        {
            //Arrange
            GameFactory gameFactory = new GameFactory();

            //Act
            Game game = gameFactory.TryCreateGame(numberOfPlayers);

            //Assert
            Assert.Equal(5, game.Players[0].hand.Count());
            Assert.Equal(5, game.Players[1].hand.Count());
        }

        [Theory]
        [InlineData(4)]
        [InlineData(5)]
        public void WhenAGameFactoryIsCalledFor4or5Players_ThenEachPlayerReceives4Cards(int numberOfPlayers)
        {
            //Arrange
            GameFactory gameFactory = new GameFactory();

            //Act
            Game game = gameFactory.TryCreateGame(numberOfPlayers);

            //Assert
            Assert.Equal(4, game.Players[0].hand.Count());
            Assert.Equal(4, game.Players[1].hand.Count());
        }

        [Fact]
        public void WhenAGameFactoryIsCalledFor2Players_ThenDeckContains40Cards()
        {
            //Arrange
            GameFactory gameFactory = new GameFactory();
            int numberOfPlayers = 2;

            //Act
            Game game = gameFactory.TryCreateGame(numberOfPlayers);

            //Assert
            Assert.Equal(40, game.Deck.Count());
        }

        [Theory]
        [InlineData(1)]
        [InlineData(6)]
        public void WhenAGameFactoryIsCalledForLessThan2PlayersOrMoreThan5Players_ThenErrorIsThrown(int numberOfPlayers)
        {
            //Arrange
            GameFactory gameFactory = new GameFactory();

            //Act
            Action act = () => gameFactory.TryCreateGame(numberOfPlayers);

            //Assert
            Assert.Throws<ArgumentException>(act);
        }
    }
}