


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

        //[Fact]
        //public void WhenGameFactoryIsCalled_ThenACollectionOfNPlayersIsCreated()
        //{
        //    //Arrange
        //    int numberOfPlayers = 2;
        //    GameFactory gameFactory = new GameFactory();

        //    //Act
        //    Game game  = gameFactory.TryCreateGame(numberOfPlayers);

        //    //Assert
        //    Assert.Equal(numberOfPlayers, gameFactory.Players.Count());
        //}
    }
}