

namespace Hanabi_Kata_March2024
{
    public class PlayerTest
    {
        [Theory]
        [InlineData(2, 5)]
        [InlineData(4, 4)]
        public void AtTheGameStart_APlayerReceivedANumberOfCardsDependingOfTheNumberOfPlayers(int numberOfPlayers, int numberOfExepectedDeckCards)
        {
            //Arrange
            Player player = new Player(numberOfPlayers);

            //Act

            //Assert
            Assert.Equal(numberOfExepectedDeckCards, player.numberOfCardsInDeck);
        }

        public void PlayerShouldPickACardFromTheDeck_WhenHePlaysACard()
        {
            // Arrange
            Player player = new Player(2);

            // Act


            // Assert


        }

    }
}