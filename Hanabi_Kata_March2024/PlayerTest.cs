

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

            Player player = new Player(playersHand);
        }
        public void WhenPlayerIsCreated_ThenPlayerHasHasAHandOfNCards()
        {
            //Arrange

            //Act

            //Assert
            Assert.Equal(playersHand, player.hand);
        }

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

        public void WhenAplayerGivesAnInformationForAColor_ThenItContainsTheColorToIndicate()
        {
            //Arrange

            //Act
            Information information = player.GiveColorInformation();

            //Assert
            Assert.NotNull(information.Color);
        }

        public void WhenAPlayerGivesAnInformationForANumber_ThenItContainsTheNumberToIndicate()
        {
            //Arrange

            //Act
            Information information = player.GiveNumberInformation();

            //Assert
            Assert.NotNull(information.CardNumber);
        }

        public void WhenAPlayerPlaysACard_ThenTheCardIsRemovedFromTheHand()
        {
            //Arrange
            int initialHandCount = player.hand.Count;

            //Act
            Card card = player.PlayCard();

            //Assert
            Assert.Equal(initialHandCount - 1, player.hand.Count);
            Assert.Equal(playersHand[0], card);
        }

        public void WhenAPlayerDicardsACard_ThenTheCardIsRemovedFromTheHand()
        {
            //Arrange
            int initialHandCount = player.hand.Count;

            //Act
            Card card = player.DiscardCard();

            //Assert
            Assert.Equal(initialHandCount - 1, player.hand.Count);
            Assert.Equal(playersHand[0], card);
        }
    }
}