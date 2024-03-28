

namespace Hanabi_Kata_March2024
{
    public class PlayerTest
    {
        internal List<Card> playersHand = new List<Card> { };
        internal Player player;

        public PlayerTest()
        {
            // Constructor is called before each test method
            playersHand.AddRange( new List<Card>
                {   new Card(1, CardColors.RED),
                    new Card(2, CardColors.RED),
                    new Card(3, CardColors.RED),
                    new Card(4, CardColors.RED),
                    new Card(5, CardColors.RED) });

            player = new Player(playersHand);
        }

        [Fact]
        public void WhenPlayerIsCreated_ThenPlayerReceivesAHandOfCards()
        {
            //Arrange

            //Act

            //Assert
            Assert.Equal(playersHand, player.hand);
        }

        [Fact]
        public void WhenAPlayerGivesAnInformation_ThenItContainsThePositionsOfTheCardsIndicated()
        {
            //Arrange

            //Act
            Information information1 = player.GiveColorInformation();
            Information information2 = player.GiveNumberInformation();

            //Assert
            Assert.NotNull(information1.Positions);
            Assert.NotNull(information2.Positions);
        }

        [Fact]
        public void WhenAplayerGivesAnInformationForAColor_ThenItContainsTheColorToIndicate()
        {
            //Arrange

            //Act
            Information information = player.GiveColorInformation();

            //Assert
            Assert.NotNull(information.Color);
        }

        [Fact]
        public void WhenAPlayerGivesAnInformationForANumber_ThenItContainsTheNumberToIndicate()
        {
            //Arrange

            //Act
            Information information = player.GiveNumberInformation();

            //Assert
            Assert.NotNull(information.CardNumber);
        }

        [Fact]
        public void WhenAPlayerPlaysACard_ThenTheCardIsRemovedFromTheHand()
        {
            //Arrange
            int initialHandCount = player.hand.Count;

            //Act
            Card card = player.PlayCard();

            //Assert
            Assert.Equal(initialHandCount - 1, player.hand.Count);
        }

        [Fact]
        public void WhenAPlayerDicardsACard_ThenTheCardIsRemovedFromTheHand()
        {
            //Arrange
            int initialHandCount = player.hand.Count;

            //Act
            Card card = player.DiscardCard();

            //Assert
            Assert.Equal(initialHandCount - 1, player.hand.Count);
        }

        [Fact]
        public void WhenAPlayerPicksACard_ThenItIsAddedToTheHand()
        {
            //Arrange
            Card card = new Card(5, CardColors.BLUE);
            bool cardIsInitialyInHand = player.hand.Contains(card);

            //Act
            player.DiscardCard();
            player.PickACard(card);
            bool cardIsInHandAfterwards = player.hand.Contains(card);

            //Assert
            Assert.False(cardIsInitialyInHand);
            Assert.True(cardIsInHandAfterwards);
        }
    }
}