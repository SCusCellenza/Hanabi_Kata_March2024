


namespace Hanabi_Kata_March2024
{
    public class DeckTest
    {
        [Fact]
        public void DeckShouldBeFilledWith50Cards_WhenTheGameStarts()
        {
            // Arrange
            Deck deck = new Deck();

            // Act

            // Assert
            Assert.Equal(50, deck.Count());
        }

        [Theory]
        [InlineData(1, 3)]
        [InlineData(2, 2)]
        [InlineData(3, 2)]
        [InlineData(4, 2)]
        [InlineData(5, 1)]
        public void DeckShouldContain3CardsOfNumberOneForEachColor_WhenTheGameStarts(int cardValue, int expectedNumber)
        {
            // Arrange
            Deck deck = new Deck();

            // Act

            // Assert
            Assert.Equal(expectedNumber, deck.CountCardsOfColorAndValue(CardColors.RED, cardValue));
            Assert.Equal(expectedNumber, deck.CountCardsOfColorAndValue(CardColors.BLUE, cardValue));
            Assert.Equal(expectedNumber, deck.CountCardsOfColorAndValue(CardColors.WHITE, cardValue));
            Assert.Equal(expectedNumber, deck.CountCardsOfColorAndValue(CardColors.GREEN, cardValue));
            Assert.Equal(expectedNumber, deck.CountCardsOfColorAndValue(CardColors.YELLOW, cardValue));
        }

        [Fact]
        public void DeckShouldContainOneLessCard_WhenItDistributeACard()
        {
            // Arrange
            Deck deck = new Deck();
            int initialCount = deck.Count();

            // Act
            deck.DistributeCard();

            // Assert
            Assert.Equal(initialCount - 1, deck.Count());
        }
        
    }
}